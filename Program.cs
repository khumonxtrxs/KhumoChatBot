// Program.cs
using System;

namespace KhumoChatBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntroPage.Show();
            NamePage.AskName(); // 👈 Moves to name prompt after intro, where your name is asked.
        }
    }
}
