using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.Http.Results;
using System.Web.Mvc;
using WebApiTodo.Model;
using WebApiTodo.Service;

namespace WebApiTodo.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class TodoTaskController : ApiController
    {

        
        private readonly IServiceContainer _service;
      public  TodoTaskController(IServiceContainer service)
        {
            this._service = service;
        }
        [System.Web.Http.HttpPost]
        [ResponseType(typeof(TodoTask))]
        public IHttpActionResult PostEmployee(TodoTask todoTask)
        {
            todoTask.Id = _service.AddTask(todoTask.Task);

            return CreatedAtRoute("DefaultApi", new { id = todoTask.Id }, todoTask);
        }


        public JsonResult<List<TodoTask>> Get()
        {
            var todo = _service.GetTodos();
            return Json(todo); //new string[] { "value1", "value2" };
        }

        // PUT: api/Employee/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEmployee(int id, TodoTask todo)
        {

            if (id != todo.Id)
            {
                return BadRequest();
            }

            

            try
            {
                
               
            }
            catch (Exception e)
            {
                
                    return NotFound();
                
            }

            return StatusCode(HttpStatusCode.NoContent);
        }



        // DELETE: api/Employee/5
        [ResponseType(typeof(TodoTask))]
        public IHttpActionResult DeleteEmployee(int id)
        {
            TodoTask todo = _service.GetTaskById(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.IsComplete = true;
            todo.DeletedOn = DateTime.Now;
            _service.MarkFinish(todo.Id);

            return Ok(todo);
        }

    }
}
