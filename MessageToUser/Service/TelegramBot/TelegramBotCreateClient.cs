using MessageToUser.Interface.TelegramBot;
using Telegram.Bot;
using Telegram.Bot.Polling;

namespace MessageToUser.Service.TelegramBot
{
    public class TelegramBotCreateClient(IConfiguration config, IUpdateHandler update) : ITelegramBotCreateClient
    {
        public TelegramBotClient CreateClient()
        {
            string token =  config.GetSection("TokenBot").Value;
            if (token is null)
                throw new Exception("TokenBot is null");
            var bot = new TelegramBotClient(token);
            bot.StartReceiving(update);
            return bot;
        }
    }
}
