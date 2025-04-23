using System;

namespace KhumoChatBot
{
    class Program
    {
        static void Main()
        {
            IntroPage.Display();
            Console.Clear();

            ChatBot chatbot = new ChatBot();
            chatbot.Start();
        }
    }
}
