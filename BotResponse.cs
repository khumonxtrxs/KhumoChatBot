
namespace KhumoChatBot
    {
        /// <summary>
        /// Provides simple, rule-based responses to user input.
        /// </summary>
        public static class BotResponse
        {
            /// <summary>
            /// Returns a predefined response based on keywords found in user input.
            /// </summary>
            /// <param name="input">The user's message as input.</param>
            /// <returns>A string response from the bot.</returns>
            public static string GetResponse(string input)
            {
                // Check for known phrases or keywords and return appropriate responses
                if (input.Contains("how are you"))
                    return "I'm just code, but I'm functioning perfectly!";

                else if (input.Contains("purpose"))
                    return "I'm here to answer your cybersecurity questions.";

                else if (input.Contains("what can i ask"))
                    return "You can ask me about password safety, phishing, and safe browsing!";

                else if (input.Contains("password"))
                    return "Use strong passwords with a mix of uppercase, lowercase, numbers, and symbols.";

                else if (input.Contains("phishing"))
                    return "Phishing is when attackers trick you via emails or messages. Don’t click suspicious links.";

                else if (input.Contains("safe browsing"))
                    return "Use HTTPS, enable 2FA, and avoid shady websites.";

                // Default fallback if none of the conditions match
                else
                    return "I’m not sure I got that. Can you rephrase it?";
            }
        }
    }
