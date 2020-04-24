using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class QuestionSample : IQuestion
    {
        public List<ExamQuestion> sample = new List<ExamQuestion>();

        public void Add(ExamQuestion q)
        {
            sample.Add(q);
        
        }
        public void Ask()
        {
            foreach (ExamQuestion element in sample)
            {
                element.Ask();
            }
        }



    }
}
