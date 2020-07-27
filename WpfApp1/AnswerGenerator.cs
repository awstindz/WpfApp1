using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class AnswerGenerator
    {
        string[] answers = new string[] {
        "1","2","3","4","5","6","7","8",
        };
    

    public string GetRandomAnswer(string question)
    {
        Random rnd = new Random();
        return answers[rnd.Next(0, answers.Length)];
    }
    }
}
