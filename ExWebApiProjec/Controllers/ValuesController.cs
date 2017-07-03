using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ExWebApiProjec.Models;
using System.Data.Entity;

namespace ExWebApiProjec.Controllers
{
    public class ValuesController : ApiController
    {
        TaskContext db = new TaskContext();
        // GET api/values
        public IEnumerable<Task> GetTasks()
        {
            return db.Tasks;
        }

        // GET api/values/5
        public Task GetTask(int id)
        {
            Task task = db.Tasks.Find(id);
            ModelState.AddModelError("task", "not found in bd"); // хз зачем
            return task;
        }

        // POST api/values
        [HttpPost]
        public void CreateTask([FromBody]Task task)
        {
            bool Valid = true;
            if (task == null)
            {
                ModelState.AddModelError("task", "nuul object!");
                Valid = false;
            }
            if (string.IsNullOrEmpty(task.Description))
            {
                ModelState.AddModelError("task.Description", "Описание не должно быть пустым");
                Valid = false;
            }
            if (Valid)
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
        }

        // PUT api/values/5
        [HttpPut]
        public void EditTask(int id, [FromBody]Task task)
        {
            if (id == task.Id)
            {
                db.Entry(task).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // DELETE api/values/5
        public void DeleteTask(int id)
        {
            Task task = db.Tasks.Find(id);
            if (task != null)
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
        }
    }
}
