using System;
using System.Collections.Generic;
using System.Text;

namespace ListQuiz
{
    public class QuizViewModel
    {
        public QuizViewModel(string question)
        {
            Question = question;
        }

        public string Question { get; set; }

        static QuizViewModel()
        {
            All = new List<QuizViewModel>{
                new QuizViewModel("Ezio is our ally"),
                new QuizViewModel("Vivere is our ally"),
                new QuizViewModel("Leonardo is our ally"),
                new QuizViewModel("The Creed is our ally"),
                new QuizViewModel("Templars are our ally")
            };
        }
        public static IList<QuizViewModel> All { private set; get; }
    }
}
