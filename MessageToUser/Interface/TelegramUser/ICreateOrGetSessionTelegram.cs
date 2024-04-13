using TLSharp.Core;

namespace MessageToUser.Interface.TelegramUser
{
    public interface ICreateOrGetSessionTelegram
    {
        public TelegramClient CreateOrGet();
    }
}
