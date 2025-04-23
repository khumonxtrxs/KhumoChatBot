# 🤖 Khumo Cyber Chatbot

**Khumo Cyber Chatbot** is a console-based AI assistant written in **C#** that educates users on cybersecurity concepts. It features an engaging intro screen with ASCII art, personalized greetings, and real-time **text-to-speech** that syncs with the on-screen text — all designed for a fun, educational experience.

---

## 📌 Project Overview

This chatbot is built to help users understand the basics of cybersecurity such as:

- Password safety
- Phishing awareness
- Safe browsing habits
- General cybersecurity best practices

It uses `System.Speech.Synthesis` for voice responses and `System.Threading` for synchronizing speech with animated text output in the console.

---

## 🎯 Objectives

- Introduce **beginner programmers** to chatbot logic using C#
- Demonstrate **modular programming** principles with a clean code structure
- Educate users on important **cybersecurity practices**
- Implement a **text-to-speech system** that speaks and prints in sync
- Simulate a fun, interactive **console-based UI**

---

## 💻 Features

| Feature                         | Description                                                                 |
|----------------------------------|-----------------------------------------------------------------------------|
| 🎨 ASCII Art Intro Page         | Animated welcome screen with art and voice greeting                         |
| 🧍 Personalized Greetings       | Prompts for your name and responds using it                                 |
| 🧠 Smart AI Responses           | Bot can answer common cybersecurity questions                               |
| 🗣️ Text-to-Speech (TTS)        | Bot reads responses aloud using `System.Speech.Synthesis`                   |
| ⏳ Speech and Text Sync         | Text is typed out in the console in real-time as it's spoken                |
| 🧩 Modular File Structure       | Code is separated by function: UI, logic, and chatbot                       |
| 📦 Easy to Extend               | Add more questions or improve UI easily                                     |

---

## 🧱 Project Structure
KhumoChatBot/
│
├── Program.cs          // Entry point that launches the chatbot
├── IntroPage.cs        // Displays ASCII intro and handles landing logic
├── UIHelper.cs         // Handles drawing borders and synchronized speech-text output
├── BotResponse.cs      // Contains chatbot logic and answers


How to Run
1. Clone the Project
- Use Git or download as ZIP and extract it to your machine.

2.Open the Solution in Visual Studio
- Open KhumoChatBot.sln

3.Build and Run
- Click "Start without Debugging" (Ctrl + F5)
- The console launches with the ASCII intro screen
- Press Enter to continue
- Enter your name when prompted
- Chat with Khumo Cyber Chatbot!

  💬 User Input | 🤖 Bot Response
how are you | I'm just code, but I'm functioning perfectly!
what is your purpose | I'm here to answer your cybersecurity questions.
what can I ask | You can ask me about password safety, phishing, and safe browsing!
password | Use strong passwords with a mix of uppercase, lowercase, numbers, and symbols.
phishing | Phishing is when attackers trick you via emails or messages. Don’t click suspicious links.
safe browsing | Use HTTPS, enable 2FA, and avoid shady websites.
Anything else | I’m not sure I got that. Can you rephrase it?

