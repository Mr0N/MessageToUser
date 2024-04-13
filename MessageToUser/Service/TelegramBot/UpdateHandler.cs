using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;

namespace MessageToUser.Service.TelegramBot
{
    public class UpdateHandler : IUpdateHandler
    {
        public async Task HandlePollingErrorAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cancellationToken)
        {
           // throw new NotImplementedException();
        }

        public async Task HandleUpdateAsync(ITelegramBotClient botClient, Update update, CancellationToken cancellationToken)
        {
          ///  throw new NotImplementedException();
        }
    }
}
