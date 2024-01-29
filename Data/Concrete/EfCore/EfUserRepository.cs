using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Data.Concrete.EfCore;
using BlogApp.Entity;
using BlogAppFinal.Data.Abstract;
using SQLitePCL;

namespace BlogAppFinal.Data.Concrete.EfCore
{
    public class EfUserRepository:IUserRepository
    {
        private readonly BlogContext _context;

       

        public EfUserRepository(BlogContext context)
        {
            _context = context;
            
        }
         public IQueryable<User> Users => _context.Users;

        public void CreateUser(User User)
        {
           _context.Users.Add(User);
           _context.SaveChanges();
        }
    
    }
}