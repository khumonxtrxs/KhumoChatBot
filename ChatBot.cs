using System;
using KhumoChatBot.Utils;

namespace KhumoChatBot
{
    public class ChatBot
    {
        public void Start()
        {
            SpeechHelper.Speak("Hello! Welcome to the KHUMO CYBER Chatbot. Please enter your name to start.");
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();

            SpeechHelper.Speak($"Alright {userName}, I'm here to help! Ask me anything about cybersecurity.");

            while (true)
            {
                Console.Write("\nYou: ");
                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    string fallback = "I didn’t quite understand that. Could you rephrase?";
                    Console.WriteLine($"Bot: {fallback}");
                    SpeechHelper.Speak(fallback);
                    continue;
                }

                if (input == "exit")
                {
                    string bye = "Goodbye! Stay safe online.";
                    Console.WriteLine($"Bot: {bye}");
                    SpeechHelper.Speak(bye);
                    break;
                }

                string response = BotResponse.GetResponse(input);
                Console.WriteLine($"Bot: {response}");
                SpeechHelper.Speak(response);  // <---- This line speaks the response
            }
        }
    }
}
