using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AliasServer
{
    public class GameLogic
    {
        private List<ClientHandler> _players = new List<ClientHandler>();
        private bool _isStarted = false;
        private Queue<string> _wordsQueue = new Queue<string>();
        private Dictionary<string, int> _scores = new Dictionary<string, int>
        {
            { "Team1", 0 },
            { "Team2", 0 }
        };
        private string _currentWord;
        private string _currentTeam;
        private ClientHandler _currentPlayer;

        public GameLogic()
        {
            LoadWordsFromFile();
            Reset();
        }

        public void ProcessMessage(string message, ClientHandler sender)
        {
            string[] parts = message.Split('|');
            switch (parts[0])
            {
                case "JOIN":
                    string nickname = parts[1];
                    if (_players.Exists(p => p.Nickname == nickname))
                    {
                        sender.SendMessage($"JOIN|ERROR|Nickname already exists.");
                        return;
                    }
                    if (_isStarted)
                    {
                        sender.SendMessage($"JOIN|ERROR|The game is already started, please wait...");
                        return;
                    }
                    sender.SetNickname(nickname);
                    _players.Add(sender);

                    BroadcastMessage($"JOIN|{nickname}");
                    BroadcastPlayersList();
                    CheckForStartGame();
                    break;

                case "LEAVE":
                    nickname = parts[1];
                    var leavingPlayer = _players.Find(p => p.Nickname == nickname);
                    if (leavingPlayer != null)
                    {
                        _players.Remove(leavingPlayer);
                        BroadcastMessage($"LEAVE|{nickname}");
                        BroadcastPlayersList();
                    }
                    if (_players.Count == 1 && _isStarted)
                    {
                        BroadcastMessage($"WIN|{_players[0].Team}");
                    }
                    break;

                case "CHAT":
                    nickname = parts[1];
                    string chatMessage = parts[2];
                    BroadcastMessage($"CHAT|{nickname}|{chatMessage}");
                    break;

                case "GUESS":
                    if (_currentPlayer == sender)
                    {
                        _scores[_currentTeam]++;
                        BroadcastMessage($"GUESS|{_currentTeam}|{_scores[_currentTeam]}");
                        NextTurn();
                    }
                    break;

                case "SKIP":
                    if (_currentPlayer == sender)
                    {
                        // Отнимаем очко у текущей команды (если есть очки)
                        if (_scores[_currentTeam] > 0)
                        {
                            _scores[_currentTeam]--;
                        }

                        // Рассылаем всем клиентам обновленный счет
                        BroadcastMessage($"GUESS|{_currentTeam}|{_scores[_currentTeam]}");

                        // Переходим к следующему ходу
                        NextTurn();
                    }
                    break;

                case "END_TURN":
                    if (_currentPlayer == sender)
                    {
                        // Отнимаем очко у текущей команды (если есть очки)
                        if (_scores[_currentTeam] > 0)
                        {
                            _scores[_currentTeam]--;
                        }

                        // Рассылаем всем клиентам обновленный счет
                        BroadcastMessage($"GUESS|{_currentTeam}|{_scores[_currentTeam]}");

                        // Переходим к следующему ходу
                        NextTurn();
                    }
                    break;

                case "WIN":
                    nickname = parts[1];
                    BroadcastMessage($"WIN|{nickname}");
                    break;
            }
        }

        private void LoadWordsFromFile()
        {
            string wordsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "words.txt");
            if (!File.Exists(wordsFilePath))
            {
                throw new FileNotFoundException("Файл со словами (words.txt) не найден.");
            }

            try
            {
                wordList = File.ReadAllLines(wordsFilePath).ToList();
                ShuffleWords();
            }
            catch (Exception ex)
            {
                throw new IOException($"Ошибка при чтении файла: {ex.Message}");
            }
        }

        private void ShuffleWords()
        {
            Random random = new Random();
            var shuffledWords = wordList.OrderBy(x => random.Next()).ToList();
            _wordsQueue = new Queue<string>(shuffledWords);
        }

        private void NextTurn()
        {
            _currentWord = GetNextWord();
            _currentTeam = _currentTeam == "Team1" ? "Team2" : "Team1";
            _currentPlayer = GetRandomPlayerFromTeam(_currentTeam);

            BroadcastMessage($"NEXT_TURN|{_currentTeam}|{_currentPlayer.Nickname}|{_currentWord}");

            CheckForWinCondition();
        }

        private void CheckForWinCondition()
        {
            if (_scores["Team1"] >= 10 || _scores["Team2"] >= 10)
            {
                string winningTeam = _scores["Team1"] > _scores["Team2"] ? "Team1" : "Team2";
                BroadcastMessage($"WIN|{winningTeam}");
            }
        }

        private string GetNextWord()
        {
            if (_wordsQueue.Count > 0)
            {
                return _wordsQueue.Dequeue();
            }
            else
            {
                ShuffleWords();
                return GetNextWord();
            }
        }

        private ClientHandler GetRandomPlayerFromTeam(string team)
        {
            var teamPlayers = _players.Where(p => p.Team == team).ToList();
            Random random = new Random();
            return teamPlayers[random.Next(teamPlayers.Count)];
        }

        private void BroadcastPlayersList()
        {
            string playersList = string.Join("&&", _players.Select(p => $"{p.Nickname} ({p.Team})"));
            BroadcastMessage($"PLAYERS|{playersList}");
        }

        private void CheckForStartGame()
        {
            if (_players.Count == 4)
            {
                _isStarted = true;

                AssignTeams();

                _currentTeam = "Team1";
                _currentPlayer = GetRandomPlayerFromTeam("Team1");
                _currentWord = GetNextWord();

                BroadcastMessage($"START_GAME|{_currentTeam}|{_currentPlayer.Nickname}|{_currentWord}");
            }
        }

        private void AssignTeams()
        {
            for (int i = 0; i < _players.Count; i++)
            {
                _players[i].Team = i % 2 == 0 ? "Team1" : "Team2";
            }

            BroadcastPlayersList();
        }

        private void BroadcastMessage(string message)
        {
            foreach (var player in _players)
            {
                player.SendMessage(message);
            }
        }

        public void Reset()
        {
            _isStarted = false;
            _players.Clear();
            _scores.Clear();
            _scores["Team1"] = 0;
            _scores["Team2"] = 0;
            _currentWord = null;
            _currentTeam = null;
            _currentPlayer = null;

            Console.WriteLine("Состояние игры сброшено.");
        }

        private List<string> wordList;
    }
}