﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningExBaseLesson1_3
{
    class Book
    {
        readonly string ddd;
        readonly Author author;
        readonly Title title;
        public Content content;

        public Book(string author, string title, string content)
        {
            this.author = new Author(author);
            this.title = new Title(title);
            this.content = new Content(content);
        }

        public void Show()
        {
            author.Show();
            title.Show();
            content.Show();

        }
    }
}
