using MessageToUser.Interface.TelegramUser;
using TLSharp.Core;

namespace MessageToUser.Service.Telegram
{
    public class CreateOrGetSessionTelegram
        (IConfiguration config) : ICreateOrGetSessionTelegram
    {
        public TelegramClient CreateOrGet()
        {
            string apiId = config.GetSection("apiId").Value;
            string apiHash = config.GetSection("apiHash").Value;
            if (apiHash is null || apiId is null)
                throw new Exception("api ID or api Hash is null");
            if (!int.TryParse(apiId, out var id))
                throw new Exception("api id is not integer");
            var client = new TelegramClient(id, apiHash);
            client.ConnectAsync(true);
            for (int i = 0; i < 20; i++)
            {
                if (client.IsConnected)
                    return client;
                Thread.Sleep(1000);
            }
            throw new Exception("Connect to teleram is not good");
        }
    }
}
