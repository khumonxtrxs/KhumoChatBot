using System;
using System.Collections.Generic;
using KhumoChatBot.Utils;

namespace KhumoChatBot

    {
        public static class ChatBot
        {
            // Dictionary mapping keywords to a list of appropriate responses
            private static Dictionary<string, List<string>> keywordResponses = new Dictionary<string, List<string>>
            {
                ["password"] = new List<string>
            {
                "Make sure to use strong, unique passwords for each account.",
                "Avoid using personal details in your passwords.",
                "Use a password manager to keep track of complex passwords."
            },
                ["scam"] = new List<string>
            {
                "Be wary of unsolicited emails asking for personal information.",
                "Verify links before clicking by hovering to see the URL.",
                "Never share sensitive information through unsecured platforms."
            },
                ["privacy"] = new List<string>
            {
                "Review the privacy settings on your social media accounts.",
                "Limit the personal information you share online.",
                "Use encrypted messaging apps to keep your communication private."
            }
            };

            // Memory to store user's details and interests
            private static Dictionary<string, string> memory = new Dictionary<string, string>();

            // Entry point to start the chatbot conversation
            public static void Start(string userName)
            {
                Console.Clear();

                // Display welcome message in a bordered box
                UIHelper.DrawBorderBox($"💬 Welcome {userName}!");
                memory["name"] = userName;

                // Main chatbot loop
                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{userName}: "); // Display user prompt
                    Console.ResetColor();
                    string input = Console.ReadLine()?.ToLower(); // Read user input in lowercase

                    if (string.IsNullOrWhiteSpace(input)) continue; // Skip if input is empty

                    if (input == "exit")
                    {
                        // Exit message with synced speech and text
                        UIHelper.SyncSpeakAndType("Goodbye! Stay safe online.");
                        break;
                    }

                    // Try to respond to keyword triggers
                    if (RespondToKeywords(input)) continue;

                    // Try to detect and respond to sentiment
                    if (HandleSentiment(input)) continue;

                    // Fallback: Use BotResponse for common questions
                    string fallbackResponse = BotResponse.GetResponse(input);
                    UIHelper.SyncSpeakAndType(fallbackResponse);
                }
            }

            // Check user input for known keywords and respond accordingly
            private static bool RespondToKeywords(string input)
            {
                foreach (var keyword in keywordResponses.Keys)
                {
                    if (input.Contains(keyword))
                    {
                        var responses = keywordResponses[keyword];
                        var random = new Random();

                        // Pick a random response from the list
                        string response = responses[random.Next(responses.Count)];

                        // Speak and print the response
                        UIHelper.SyncSpeakAndType($"{response}");

                        // Special case: If user talks about "privacy", remember it
                        if (keyword == "privacy")
                        {
                            memory["interest"] = "privacy";
                            UIHelper.SyncSpeakAndType("I'll remember that you're interested in privacy. It's a crucial part of staying safe online.");
                        }

                        // If the input also contains "remind", give personalized suggestion
                        if (input.Contains("remind") && memory.ContainsKey("interest"))
                        {
                            UIHelper.SyncSpeakAndType($"As someone interested in {memory["interest"]}, you might want to review the security settings on your accounts.");
                        }

                        return true; // Keyword handled
                    }
                }
                return false; // No keyword matched
            }

            // Detect emotional sentiment in user input and respond with empathy
            private static bool HandleSentiment(string input)
            {
                if (input.Contains("worried") || input.Contains("scared") || input.Contains("anxious"))
                {
                    UIHelper.SyncSpeakAndType("It's completely understandable to feel that way. Scammers can be very convincing. Let me share some tips to help you stay safe.");
                    return true;
                }

                if (input.Contains("curious") || input.Contains("interested"))
                {
                    UIHelper.SyncSpeakAndType("That's great! Learning about cybersecurity is the first step to staying protected.");
                    return true;
                }

                if (input.Contains("frustrated") || input.Contains("confused"))
                {
                    UIHelper.SyncSpeakAndType("I'm here to help! Let's go through it step by step.");
                    return true;
                }

                return false; // No matching sentiment
            }
        }
    }
