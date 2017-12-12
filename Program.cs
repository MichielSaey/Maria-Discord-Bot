using Discord;
using Discord.WebSocket;
using System;
using System.Threading.Tasks;



namespace discored_Bot
{
    public class Program
    {
        static void Main(string[] args)
            => new Program().StartAsync().GetAwaiter().GetResult();
      
        public async Task StartAsync()
        {
            var client = new DiscordSocketClient();

            client.Log += Log;
            client.MessageReceived += MessageReceived;

            string token = "Mzg4ODAwNjcwNTE5NTI1Mzc3.DQyiPw.QzFQ9gF4oehdvFUabLyokS_cg7Q"; // Remember to keep this private!
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            // Block this task until the program is closed.
            await Task.Delay(-1);
        }

        private async Task MessageReceived(SocketMessage message)
        {
            if (message.Content == "rubberbanding")
            {
                await message.Channel.SendMessageAsync("SHOT");
            }
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.Co;
        }
    }
}