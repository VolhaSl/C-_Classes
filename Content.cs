using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExBaseLesson1_3
{
    class Content
    {
         public string text;
        public Content(string content)
        {
            this.text = content;
        }

        public void Show()
        {
            Console.WriteLine("Content: "+ text);
        }
    }
}
