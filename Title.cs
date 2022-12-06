using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExBaseLesson1_3
{
    class Title
    {
        readonly string title;

        public Title(string title)
        {
            this.title = title;
        }

        public void Show()
        {
            Console.WriteLine("Title: " + title);
        }
    }
}
