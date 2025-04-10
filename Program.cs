using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace prototypeChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayGreetingSound();

            // Task 2: Display ASCII Art
            DisplayAsciiArt();

            // Task 3: Ask for User’s Name
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            GreetUser(userName);

            // Task 4: Chatbot Interaction
            StartChatbot(userName);
        }

        static void PlayGreetingSound()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer(@"C:\Users\HP\Documents\greetings.wav")) // Adjust the path if necessary
                {
                    player.PlaySync(); // Play the sound synchronously
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing sound: " + ex.Message);
            }
        }

        static void DisplayAsciiArt()
        {
            string asciiArt = @"
            .--.   .--.
           |o_o | |o_o |
           |:_/ | |:_/ |
          //   \ \ //   \
         (|     | |     |)
        /'\_   _/ \   _/`\
        \___)=(___/ 
            ";
            Console.WriteLine(asciiArt);
        }

        static void GreetUser(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Hello, {userName}! Welcome to the Chatbot.");
            Console.ResetColor();
        }

        static void StartChatbot(string userName)
        {
            string userInput;
            Console.WriteLine("You can ask me questions like 'How are you?', 'What's your purpose?', or type 'exit' to end the conversation.");

            while (true)
            {
                Console.Write($"{userName}: ");
                userInput = Console.ReadLine().ToLower();

                if (userInput == "exit")
                {
                    Console.WriteLine("Goodbye! Have a great day!");
                    break;
                }
                else if (userInput == "how are you?")
                {
                    Console.WriteLine("Chatbot: I'm just a program, but I'm functioning as expected! How about you?");
                }
                else if (userInput == "what's your purpose?")
                {
                    Console.WriteLine("Chatbot: My purpose is to assist you with your queries and provide information.");
                }
                else
                {
                    Console.WriteLine("Chatbot: I didn't understand that. Could you please rephrase or ask another question?");
                }
            }
        }
    }
}




