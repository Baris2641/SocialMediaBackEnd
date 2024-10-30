using Core.Entities;

namespace Entities.Concrete
{
    public class  Topic : IEntity
    {
        public int Id { get; set; }
        public string TopicTitle { get; set; }
    }
}
