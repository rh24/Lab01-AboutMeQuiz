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

        }

        private string[] questions;

        private string[] answers;

        private int[] score;

        public void AskQuestions()
        {
            string[] questions = this.questions;
            string[] answers = this.answers;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                string userInput = Console.ReadLine();
                CheckAnswer()
            }
        }

        static string CheckAnswer(string userInput, int idx)
        {

        }

        public int CalculateScore()
        {

        }
    }
}
