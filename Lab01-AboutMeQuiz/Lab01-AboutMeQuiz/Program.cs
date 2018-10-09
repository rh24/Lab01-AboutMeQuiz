using System;
// I want to find the way to write WriteLine() instead of Console.WriteLine() every time.

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program game = new Program();
            game.questions = new string[5] { "In which city was I born?", "What's my favorite ice cream store in Capitol Hill?", "Which instrument did I play while growing up?", "Which sport did I play?", "Which weapon did I fence?" };
            game.answers = new string[5] { "Flushing, NY", "Salt & Straw", "Flute", "Fencing", "Epee" };
            game.score = new bool[5];
            game.AskQuestions();
            int totalCorrect = game.CalculateRightAnswers();
            PrintScore(totalCorrect);
            Console.ReadLine();
        }

        private string[] questions;

        private string[] answers;

        private bool[] score;

        public void AskQuestions()
        {
            string[] questions = this.questions;
            string[] answers = this.answers;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userInput = Console.ReadLine();
                int idx = i;
                bool gotItRight = this.CheckAnswer(userInput, idx);
                this.score[idx] = gotItRight;
                this.PrintRightAnswer(idx, gotItRight);
            }

        }

        public bool CheckAnswer(string userInput, int idx)
        {
            return String.Equals(this.answers[idx], userInput, StringComparison.CurrentCultureIgnoreCase);
        }

        public void PrintRightAnswer(int idx, bool gotItRight)
        {
            if (!gotItRight)
            {
                Console.WriteLine("Wrong! ", this.answers[idx]);
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }

        public int CalculateRightAnswers()
        {
            bool[] rightOrWrong = this.score;
            int correct = 0;

            for (int i = 0; i < this.score.Length; i++)
            {
                if (rightOrWrong[i])
                {
                    correct++;
                }
            }

            return correct;
        }

        static string PrintScore(int correct)
        {
           Console.WriteLine($"You got a {correct.ToString()}/5. Thanks for playing!");
           return "Game Over";
        }
    }
}
