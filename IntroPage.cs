using System;
using KhumoChatBot.Utils;

namespace KhumoChatBot
{
    public static class IntroPage
    {
        public static void Display()
        {
            Console.Title = "Khumo Cybersecurity Chatbot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            SpeechHelper.Speak("Hello! MY NAME IS KHUMO CYBER CHATBOT!. Please Press ENTER to start chatting...");

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
            Press ENTER to chat...
            ");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
