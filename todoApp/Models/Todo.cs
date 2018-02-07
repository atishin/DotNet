using System;

namespace todoApp.Models
{
    public class Todo
    {

        public static int LastInsertId = 0;

        public int Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
    }
}