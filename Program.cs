using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhumoChatBot
{
    using System;
    using System.Speech.Synthesis; // For text-to-speech

    class Program
    {
        static void Main()
        {
            ShowIntroPage();
            Console.Clear(); // Clears the screen after pressing Enter
            StartChatbot();
        }

        static void ShowIntroPage()
        {
            Console.Title = "CyberSecurity Chatbot";
            Console.ForegroundColor = ConsoleColor.Cyan;
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.Speak("Hello! MY NAME IS KHUMO CYBER CHATBOT!. Please Press ENTER to start chatting... ");
            }

            // Display ASCII Art
            Console.WriteLine(@"
     ___  __    ___  ___  ___  ___  _____ ______   ________                                 
|\  \|\  \ |\  \|\  \|\  \|\  \|\   _ \  _   \|\   __  \                                
\ \  \/  /|\ \  \\\  \ \  \\\  \ \  \\\__\ \  \ \  \|\  \                               
 \ \   ___  \ \   __  \ \  \\\  \ \  \\|__| \  \ \  \\\  \                              
  \ \  \\ \  \ \  \ \  \ \  \\\  \ \  \    \ \  \ \  \\\  \                             
   \ \__\\ \__\ \__\ \__\ \_______\ \__\    \ \__\ \_______\                            
    \|__| \|__|\|__|\|__|\|_______|\|__|     \|__|\|_______|                            
                                                                                        
                                                                                        
                                                                                        
 ________      ___    ___ ________  _______   ________  ________  ________  _________   
|\   ____\    |\  \  /  /|\   __  \|\  ___ \ |\   __  \|\   __  \|\   __  \|\___   ___\ 
\ \  \___|    \ \  \/  / | \  \|\ /\ \   __/|\ \  \|\  \ \  \|\ /\ \  \|\  \|___ \  \_| 
 \ \  \        \ \    / / \ \   __  \ \  \_|/_\ \   _  _\ \   __  \ \  \\\  \   \ \  \  
  \ \  \____    \/  /  /   \ \  \|\  \ \  \_|\ \ \  \\  \\ \  \|\  \ \  \\\  \   \ \  \ 
   \ \_______\__/  / /      \ \_______\ \_______\ \__\\ _\\ \_______\ \_______\   \ \__\
    \|_______|\___/ /        \|_______|\|_______|\|__|\|__|\|_______|\|_______|    \|__|
             \|___|/                                                                    
        
        WELCOME MY NAME IS KHUMO CYBER CHATBOT!
        Press ENTER to start chatting...
        ");

            Console.ResetColor();
            Console.ReadLine(); // Waits for user to press Enter
        }

        static void StartChatbot()
        {
            PlayVoiceGreeting();

            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
                synth.Speak($"Welcome, {userName}! Ask me anything about cybersecurity.");

            while (true)
            {
                Console.Write("\nYou: ");
                string userInput = Console.ReadLine()?.ToLower();

                if (userInput == "exit")
                {
                    Console.WriteLine("Goodbye! Stay safe online.");
                    break;
                }

                Console.WriteLine($"Bot: {GetBotResponse(userInput)}");
            }
        }

        static void PlayVoiceGreeting()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.Speak("Hello! Welcome to the KHUMO CYBER Chatbot. Please enter your name to start.");
            }
        }
    }
}