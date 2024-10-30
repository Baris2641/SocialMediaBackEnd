using Core.DataAccess;
using DataAccess.Abstract;
using DataAccess.Concrete.Context;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfArticleDal : EfEntityRepository<Article, SocialMediaContext>, IArticleDal
    {
    }
}
