namespace KhumoChatBot
{
    public static class BotResponse
    {
        public static string GetResponse(string input)
        {
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
            else
                return "I’m not sure I got that. Can you rephrase it?";
        }
    }
}
