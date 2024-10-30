using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById<T>(int id);

        void Update(User user);
        void Delete(int id);
        void Add(User user);
    }
}
