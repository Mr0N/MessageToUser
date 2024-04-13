using TLSharp.Core;

namespace MessageToUser.Interface.TelegramUser
{
    public interface IAuthorizationInTelegram
    {
        public TelegramClient Authorization(TelegramClient client);
    }
}
