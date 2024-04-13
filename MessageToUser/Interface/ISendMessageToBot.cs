using MessageToUser.Model;

namespace MessageToUser.Interface
{
    public interface ISendMessageToBot
    {
        public void SendMessage(IEnumerable<Message> messages);
    }
}
