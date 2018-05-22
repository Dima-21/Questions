using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_WindowsForms
{
    class Question
    {
        public string question { get; set; }
        public List<string> answers { get; set; }
        public int correct { get; set; }
        public Question(string q, int cor, params string[] answ)
        {
            question = q;
            cor = correct;
            answers = new List<string>(answ);
        }
    }
}
