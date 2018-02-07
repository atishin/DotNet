using todoApp;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webApp.Models;

namespace webApp.Controllers
{
    public class TodoController: Controller {
        
        private TodoDb db = TodoDb.GetDatabase();

        public IActionResult Index() {
            var todos = db.Todos;
            return View("List", todos);
        }

        public IActionResult Remove(int id) {
            var todo = db.Todos.Find(t => t.Id == id);
            return View("Remove", todo);
        }

        [HttpPost]
        public IActionResult Remove(TodoRemoveModel model) {
            var todo = db.Todos.Find(t => t.Id == model.Id);
            // if (model.Confirm) {
                db.Todos.Remove(todo);
            // }
            return Redirect("~/Todo");
        }
    }
    

    
}