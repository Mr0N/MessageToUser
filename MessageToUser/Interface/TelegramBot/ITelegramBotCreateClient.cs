using Telegram.Bot;

namespace MessageToUser.Interface.TelegramBot
{
    public interface ITelegramBotCreateClient
    {
        public TelegramBotClient CreateClient();
    }
}
