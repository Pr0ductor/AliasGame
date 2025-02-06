using AliasServer;
using System;
using System.Threading.Tasks;

namespace AliasServer
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Server server = new Server();
            await server.StartAsync(5000);
        }
    }
}