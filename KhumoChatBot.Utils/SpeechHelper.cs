using System.Speech.Synthesis;

namespace KhumoChatBot.Utils
{
         /// <summary>
        /// Utility class to handle basic text-to-speech functionality.
        /// </summary>
        public static class SpeechHelper
        {
            /// <summary>
            /// Speaks the provided text using the system's speech synthesizer.
            /// This method will block until speaking is complete.
            /// </summary>
            /// <param name="text">The text to be spoken aloud.</param>
            public static void Speak(string text)
            {
                // Create a new instance of the SpeechSynthesizer
                using (SpeechSynthesizer synth = new SpeechSynthesizer())
                {
                    // Speak the text synchronously (waits until done)
                    synth.Speak(text);
                }
            }
        }
    }

