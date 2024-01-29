using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entity;

namespace BlogAppFinal.Data.Abstract
{
    public interface IUserRepository
    {
         IQueryable<User> Users {get;}
        void CreateUser(User User);
        
    }

}