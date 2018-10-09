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

        public void AskQuestions()
        {
            string[] questions = this.questions;

            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine(questions[i]);
                Console.ReadLine();
            }
        }

        public string CheckAnswer()
        {

        }
    }
}
