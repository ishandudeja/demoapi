using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTodo.Model
{
    public partial class User : IUser
    {
        public bool Loging(User uModel)
        {
            using (todo_apiEntities1 db = new todo_apiEntities1()) {
              var user=  db.Users.Where(u => u.UserName == uModel.UserName && u.PasswordHash == PasswordHash).FirstOrDefault();
                if (user != null)
                    return true;
            }
            return false;
        }

        public void LogOut()
        {
            throw new NotImplementedException();
        }

        public int Register(User uModel)
        {
            using (todo_apiEntities1 db = new todo_apiEntities1()) {
                db.Entry(uModel).State = System.Data.Entity.EntityState.Added;
             return   db.SaveChanges();
            }
            
        }
    }
}
