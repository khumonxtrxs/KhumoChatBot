using System;
using KhumoChatBot.Utils;

namespace KhumoChatBot
{
    public static class NamePage
    {
        public static void AskName()
        {
            Console.Clear();
            UIHelper.DrawBorderBox("👤 Let's Get to Know You");

            UIHelper.SyncSpeakAndType("Before we begin, what is your name?");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            UIHelper.SyncSpeakAndType($"Nice to meet you, {userName}! Let's begin our chat.");
            ChatBot.Start(userName); // start chat and pass name
        }
    }
}
