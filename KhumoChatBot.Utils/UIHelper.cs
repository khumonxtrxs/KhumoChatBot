// UIHelper.cs
using System;
using System.Speech.Synthesis;
using System.Threading;

namespace KhumoChatBot
{
    public static class UIHelper
    {
        public static void SyncSpeakAndType(string message)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                AutoResetEvent speakDone = new AutoResetEvent(false);

                synth.SpeakStarted += (s, e) =>
                {
                    new Thread(() =>
                    {
                        foreach (char c in message)
                        {
                            Console.Write(c);
                            Thread.Sleep(50);
                        }
                        Console.WriteLine();
                    }).Start();
                };

                synth.SpeakCompleted += (s, e) =>
                {
                    speakDone.Set();
                };

                synth.SpeakAsync(message);
                speakDone.WaitOne();
            }
        }

        public static void DrawBorderBox(string content)
        {
            int width = 80;
            string horizontal = new string('*', width);
            Console.WriteLine(horizontal);

            string[] lines = content.Split('\n');
            foreach (string line in lines)
            {
                string padded = line.PadRight(width - 4);
                Console.WriteLine("* " + padded + " *");
            }

            Console.WriteLine(horizontal);
        }
    }
}
