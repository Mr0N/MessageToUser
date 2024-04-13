using MessageToUser.Model;

namespace MessageToUser.Interface
{
    public interface IFilterMessage
    {
        public bool CheckMessage(Message msg);
    }
}
