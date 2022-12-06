using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExBaseLesson1_3
{
    class Content
    {
         public string content;
        public Content(string content)
        {
            this.content = content;
        }

        public void Show()
        {
            Console.WriteLine("Content: "+ content);
        }
    }
}
