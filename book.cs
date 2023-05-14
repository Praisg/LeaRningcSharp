using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class book //class called book
    {
        public string author;
        public string title;
        public int pages;

        public book(string autho_r, string titl_e, int page_s) //constructor` a special method in a class
        {
            author = autho_r;
            title = titl_e;
            pages = page_s;

        }
    }
   
}
