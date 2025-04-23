// IntroPage.cs
using System;

namespace KhumoChatBot
{
    public static class IntroPage
    {
        public static void Show()
        {
            Console.Clear();
            Console.Title = "CyberSecurity Chatbot";
            Console.ForegroundColor = ConsoleColor.Cyan;

            string asciiArt = @"
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
             \|___|/";

            UIHelper.DrawBorderBox(asciiArt);
            Console.WriteLine();

            UIHelper.SyncSpeakAndType("Hello! My name is Khumo Cyber Chatbot. Please press Enter to start chatting.");

            Console.ResetColor();
            Console.ReadLine();
        }
    }

}
