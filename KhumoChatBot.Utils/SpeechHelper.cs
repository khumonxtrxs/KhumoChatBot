using System.Speech.Synthesis;

namespace KhumoChatBot.Utils
{
    public static class SpeechHelper
    {
        public static void Speak(string text)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.Speak(text);
            }
        }
    }
}
