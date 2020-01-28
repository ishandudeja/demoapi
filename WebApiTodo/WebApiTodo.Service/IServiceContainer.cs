using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTodo.Model;

namespace WebApiTodo.Service
{
   public interface IServiceContainer
    {
        bool Loging(User uModel);
        int Register(User uModel);
        void LogOut();
        int AddTask(string todo);
        List<TodoTask> GetTodos();
        TodoTask GetTaskById(int Id);
        bool MarkFinish(int Id);
        List<string> FruitsList();
    }
}
