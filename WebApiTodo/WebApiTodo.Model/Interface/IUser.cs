using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTodo.Model
{
   public interface IUser
    {
        bool Loging(User uModel);
        int Register(User uModel);
        void LogOut();
    }
}
