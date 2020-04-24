using System;
using System.Collections.Generic;

namespace C6
{
    class ExamQuestion : IQuestion
    {
        public string Question { get; private set; }
        public int Points { get; private set; }
        public ExamQuestion(string q, int p)
        {
            Question = q;
            Points = p;
        }
        public void Ask()
        {
            Console.WriteLine(Question + " (" + Points + " pkt).");
        }
    }

}
