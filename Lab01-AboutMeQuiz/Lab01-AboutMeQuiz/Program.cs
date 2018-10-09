using System;
// I want to find the way to write WriteLine() instead of Console.WriteLine() every time.

namespace Lab01_AboutMeQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program game = new Program();

            // populate questions and answers
            game.questions = new string[6] { "In which city was I born?", "What's my favorite ice cream store in Capitol Hill?", "Which instrument did I play while growing up?", "Which sport did I play?", "Which weapon did I fence?", "Guess a number between 1-100. What's my favorite number?" };
            game.answers = new string[6] { "Flushing, NY", "Salt & Straw", "Flute", "Fencing", "Epee", "7" };
            // instantiate score array
            game.score = new bool[6];

            // print questions and answers in console
            game.AskQuestions();

            // calculate right answers
            int totalCorrect = game.CalculateRightAnswers();
            PrintScore(totalCorrect);
            Console.ReadLine();
        }

        // fields belong to each instance of Program (game)
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
            // This is to handle answer checking for only question 6. I anticipate "Input string was not in correct format" printed to the console.
            if (idx == 5)
            {
                try
                {
                    int guess = int.Parse(userInput);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            // case insensitive string comparison that returns a boolean
            return String.Equals(this.answers[idx], userInput, StringComparison.CurrentCultureIgnoreCase);
        }

        public void PrintRightAnswer(int idx, bool gotItRight)
        {
            if (!gotItRight)
            {
                Console.WriteLine($"Wrong. The correct answer is {this.answers[idx]}");
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
           Console.WriteLine($"You got a {correct.ToString()}/6. Thanks for playing!");
           return "Game Over";
        }
    }
}
