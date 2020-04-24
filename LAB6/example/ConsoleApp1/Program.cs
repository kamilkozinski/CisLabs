using System;

namespace C6
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ExamQuestion q1 = new ExamQuestion("Pytanie1", 2);
            //  ExamQuestion q2 = new ExamQuestion("Pytanie2", 3);
            //  ExamQuestion q3 = new ExamQuestion("Pytanie3", 2);

            // QuestionSample s1 = new QuestionSample();

            // s1.Add(q1);
            //  s1.Add(q2);
            // s1.Add(q3);

            // s1.Ask();


            IWeatherAlert monday = new RainAlert();
            monday = new WindDecorator(monday);
            monday = new SnowDecorator(monday);

            monday.Alert();


        }
    }
}
