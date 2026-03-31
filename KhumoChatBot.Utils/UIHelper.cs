// UIHelper.cs
using System;
using System.Speech.Synthesis;
using System.Threading;

namespace KhumoChatBot
{
    // This static class contains helper methods for UI features like speech + typing and drawing boxes.
    public static class UIHelper
    {
        /// <summary>
        /// Speaks the given message aloud while simultaneously typing it on the console,
        /// letter by letter, in sync with the speech.
        /// </summary>
        /// <param name="message">The message to speak and type.</param>
        public static void SyncSpeakAndType(string message)
        {
            // Create a new SpeechSynthesizer for text-to-speech
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                // Used to pause execution until speech is complete
                AutoResetEvent speakDone = new AutoResetEvent(false);

                // When speech starts, type the message character by character
                synth.SpeakStarted += (s, e) =>
                {
                    new Thread(() =>
                    {
                        foreach (char c in message)
                        {
                            Console.Write(c);     // Display one character
                            Thread.Sleep(50);     // Small delay for typing effect
                        }
                        Console.WriteLine();     // New line after typing
                    }).Start(); // Run typing on a separate thread so it can sync with speech
                };

                // When speech completes, signal that we can move on
                synth.SpeakCompleted += (s, e) =>
                {
                    speakDone.Set(); // Release the waiting thread
                };

                synth.SpeakAsync(message); // Start speaking the message asynchronously
                speakDone.WaitOne();       // Wait until speech is finished
            }
        }

        /// <summary>
        /// Draws a decorative box around a text message using asterisks (*).
        /// </summary>
        /// <param name="content">The message to display in the box.</param>
        public static void DrawBorderBox(string content)
        {
            int width = 80; // Fixed width of the box
            string horizontal = new string('*', width); // Top/bottom border

            Console.WriteLine(horizontal); // Print top border

            // Split the content into lines and print each with side borders
            string[] lines = content.Split('\n');
            foreach (string line in lines)
            {
                string padded = line.PadRight(width - 4); // Pad line to fit width
                Console.WriteLine("* " + padded + " *");  // Line with side borders
            }

            Console.WriteLine(horizontal); // Print bottom border
        }
    }
}

