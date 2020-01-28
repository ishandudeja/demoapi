using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiTodo.Model;

namespace WebApiTodo.Service
{
    public class ServiceContainer : IServiceContainer
    {
        IUser _user; ITodoTask _todoTask;
        public ServiceContainer(IUser user, ITodoTask todoTask) {
            this._todoTask = todoTask;
            this._user = user;
        }

        public int AddTask(string todo)
        {
         return   _todoTask.AddTask(todo);
        }

        public TodoTask GetTaskById(int Id)
        {
          return  _todoTask.GetTaskById(Id);
        }

        public List<TodoTask> GetTodos()
        {
          return  _todoTask.GetTodos();
        }

        public bool Loging(User uModel)
        {
          return  _user.Loging(uModel);
        }

        public void LogOut()
        {
            _user.LogOut();
        }

        public bool MarkFinish(int Id)
        {
          return  _todoTask.MarkFinish(Id);
        }

        public int Register(User uModel)
        {
          return  _user.Register(uModel);
        }

        public List<string> FruitsList() {
            List <string>list = new List<string>() {"Apple","Banana","Orange","Pine Apple","Grapes","Water Malan" };
            return list;
        } 



    }
}
