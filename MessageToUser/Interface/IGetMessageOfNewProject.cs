using MessageToUser.Model;

namespace MessageToUser.Interface
{
    public interface IGetMessageOfNewProject
    {
        public IEnumerable<Message> GetMessage();
    }
}
