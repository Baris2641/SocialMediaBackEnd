using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTopicDal : EfEntityRepository<Topic, SocialMediaContext>, ITopicDal
    {
    }
}
