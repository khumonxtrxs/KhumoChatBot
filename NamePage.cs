using System;
using KhumoChatBot.Utils;

namespace KhumoChatBot
{
    public static class NamePage
    {
        public static void AskName()
        {
            Console.Clear();
            UIHelper.DrawBorderBox("🙋 Please enter your name:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("You: ");
            Console.ResetColor();
            string name = Console.ReadLine();

            UIHelper.SyncSpeakAndType($"Hi {name}, nice to meet you! Let's talk about cybersecurity.");

            // Start the chatbot conversation with the name
            ChatBot.Start(name);
        }
    }
}
