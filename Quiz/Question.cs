using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    public class Question
    {
        public string Title { get; set; }
        public Dictionary<string , bool> Options { get; set; }
    }
}
