// Program.cs
using System;

namespace KhumoChatBot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IntroPage.Show();
            NamePage.AskName(); // 👈 Move to name prompt after intro
        }
    }
}
