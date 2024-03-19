using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Terminal
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; }
        public DateTime DueDate { get; set; }

        public Book(string title, string author, string status)
        {
            Title = title;
            Author = author;
            Status = status;
        }
    }
}
