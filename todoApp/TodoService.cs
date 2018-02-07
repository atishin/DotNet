using System;
using System.Collections.Generic;
using todoApp.Models;

namespace todoApp
{
    public class TodoDb
    {

        private static TodoDb db = null;
        public static TodoDb GetDatabase()
        {
            if (db == null)
            {
                db = new TodoDb();
            }
            return db;
        }
        public List<Todo> Todos { get; set; }

        TodoDb()
        {
            Todos = new List<Todo>();
            for (int i = 0; i < 10; i++)
            {
                Todos.Add(new Todo()
                {
                    Id = ++Todo.LastInsertId,
                    Title = string.Format("Todo #{0}", i + 1),
                    Done = false
                });
            }
        }
    }
}
