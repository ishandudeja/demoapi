using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTodo.Model
{
   public interface ITodoTask
    {
        int AddTask(string todo);
        List<TodoTask> GetTodos();
        TodoTask GetTaskById(int Id);
        bool MarkFinish(int Id);
    }
}
