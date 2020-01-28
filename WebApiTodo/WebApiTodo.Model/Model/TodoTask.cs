using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiTodo.Model
{
    public partial class TodoTask : ITodoTask
    {
        public int AddTask(string todo)
        {
            using (todo_apiEntities1 db =new todo_apiEntities1()) {

                TodoTask task = new TodoTask() { Task = todo, UserId = 1, CreatedOn = DateTime.Now };
                db.Entry(task).State = EntityState.Added;
              return  db.SaveChanges();
            }
        }

        public TodoTask GetTaskById(int Id)
        {
            using (todo_apiEntities1 db = new todo_apiEntities1()) {
               TodoTask task= db.TodoTasks.Where(t => t.Id == Id).FirstOrDefault();

                return task;
            }
        }

        public List<TodoTask> GetTodos()
        {
            using (todo_apiEntities1 db=new todo_apiEntities1()){
             return   db.TodoTasks.ToList(); 
            }
        }

        public bool MarkFinish(int Id)
        {
            using (todo_apiEntities1 db = new todo_apiEntities1()) {
               TodoTask task= db.TodoTasks.Where(t => t.Id == Id).FirstOrDefault();
                task.IsComplete = true;
                db.Entry(task).State = EntityState.Modified;
              return  db.SaveChanges()>0;
            }
        }
    }
}
