using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExBaseLesson1_3
{
    class Author
    {
        readonly string author;

        public Author(string author)
        {
            this.author = author;
        }

        public void Show()
        {
            Console.WriteLine("Author: "+ author);
        }
    }
}
