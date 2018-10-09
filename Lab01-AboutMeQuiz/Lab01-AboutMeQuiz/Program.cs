using System;

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

        static string[] PopulateQuestionsArray()
        {

        }
    }
}
