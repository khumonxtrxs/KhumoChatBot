using System;
using KhumoChatBot.Utils;

namespace KhumoChatBot
{
    public static class ChatBot
    {
        public static void Start(string userName)
        {
            Console.Clear();
            UIHelper.DrawBorderBox ($"💬 Welcome {userName}!");

            string input = "";
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"{userName}: ");
                Console.ResetColor();
                input = Console.ReadLine();

                if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
                {
                    UIHelper.SyncSpeakAndType("Goodbye! Stay safe online.");
                    break;
                }

                string response = BotResponse.GetResponse(input.ToLower());
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Khumo: ");
                UIHelper.SyncSpeakAndType(response);
                Console.ResetColor();
            }
        }
    }
}

