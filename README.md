# AliasGame
Классическая игра «Alias» в сетевом формате, реализованная на C#. В игру нужно играть вчетвером, люди могут подключаться к серверу и соревноваться командами друг с другом.
 
## :notebook: Содержание 
- Правила игры
- Установка
- Технологии
- Ответственные
  
## :memo: Правила :bangbang:
Правила и действия в игре:
1) Игра идёт до 10 очков. Выигрывает та команда, которая первая набирает 10 очков.
2) Игра построена так, что сначала регистрируются 4 клиента, которых случайным образов распределяет на 2 команды.
3) Для начала игры человеку из первой команды нужно нажать на кнопку пропуск, когда все 4 игрока будут готовы.
4) Первый ход начинает человек команды 1, который и начал игру, он должен объяснить выпавшее слово человеку из второй команды за 1 минуту, для коммуникации и объяснения слов в игре сделан текстовый чат. У человека которому объясняют слово есть две кнопки: "Guess" и "Skip",  -  при нажатии на кнопку "Guess" его команде достается очко и ход переходит другой команде, при нажатии на кнопку "Skip" команда теряет одно очко и также происходит переход, при этом если у команды 0 очков, то очки не уходят в минус.
5) Кроме того, стоит отметить, что если человек не угадает слово за отведённое время, то происходит автоматический пропуск слова и смена хода, также как и при нажатии кнопки пропуска слова, команде отгадывающего человека вычитывают 1 очко, если их больше 0.
6) Всего в игре используется 1 базовый набор слов, состоящий из 152 слов, которые находятся в отдельном текстовом файле, слова из этого файла выбираются случайным образом.
7) Также в игре присутствует кнопка "Surrender", то есть один из игроков может выйти досрочно нажав на эту кнопку, чтобы сдаться. если вышло 3 человека из 4, то автоматически побеждает та команда, чей игрок остался последним в игре.

## :hammer: Установка :hammer:
1) Клонирование репозитория
   - клонируйте репозиторий себе на компьютер через команду:
   - git clone https://github.com/Pr0ductor/AliasGame.git
2) Запуск сервера
   - открыть проект в Visual Studio или Rider, настроить конфигурацию запуска и запустить Server
3) Запуск клиентов для игры
   - А) Если Visual Studio:
     - открыть проект в проводнике, перейти в папке AliasClient/bin/Debug/net8.0-windows и открыть 4 клиента AliasClient.exe
   - Б) Если Rider:
     - Настроить конфигурацию запуска, добавить туда 4 клиента и запустить их
   - Зарегистрироваться во всех клиентах, придумав себе никнейм

## :wrench: Технологии
- Server — серверная часть игры, принимает подключения игроков и управляет игровым процессом.
- Client — клиентская часть, через которую игроки взаимодействуют с игрой.
- База данных не используется, вместо нее файл в папке сервера со словами для игры
 
## :construction_worker: Разработчики
- Мы студенты КФУ ИТИС, группа 11-308
- Ефимов Никита и Юсупов Денис
