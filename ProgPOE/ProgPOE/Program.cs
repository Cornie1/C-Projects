using System;
using System.Threading;
using System.Media;

namespace ProgPOE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "CyberSafe Bot";
            ShowHeader();
            try
            {
                string filePath = "C:/Users/ajkil/source/repos/ProgPOE/ProgPOE/greeting.wav";

                SoundPlayer player = new SoundPlayer(filePath);
                player.Load();
                player.PlaySync();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
            
            //Get User Name
            Console.Write("\n\x1b[1mIDENTIFY YOURSELF:\x1b[0m ");
            string userName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userName)) userName = "Agent";

            Console.WriteLine($"\n \x1b[96m[SYSTEM]\x1b[0m Welcome, {userName}. Connection established.");

            Chats.ShowAvailableQuestions();

            bool running = true;
            while (running) //(GeeksForGeeks, 2025)
            {
                //Input
                Console.Write($"\n \x1b[92m{userName}@CyberBot\x1b[0m:~$ ");
                string input = Console.ReadLine()?.ToLower();

                if (string.IsNullOrEmpty(input)) continue;

                if (input == "exit" || input == "quit")
                {
                    Console.WriteLine($"\n \x1b[91m[SYSTEM]\x1b[0m Shutting Down Stay safe, {userName}....");
                    Thread.Sleep(1000);
                    running = false;
                    break;
                }

                //generating response even tho it knows a response already fake loading bar basically
                ShowLoading();

                string response = Chats.GetResponse(input);

                //Bot response
                Console.Write($"\n \x1b[96mBOT:\x1b[0m ");
                TypeWriter(response);
                Console.WriteLine();
            }
        }
        //header
        static void ShowHeader()
        {
            Console.Clear();
            string header = @"
________________________________________________________________________________________________
 ______     __  __     ______     ______     ______     ______     ______     ______   ______    
/\  ___\   /\ \_\ \   /\  == \   /\  ___\   /\  == \   /\  ___\   /\  __ \   /\  ___\ /\  ___\   
\ \ \____  \ \____ \  \ \  __<   \ \  __\   \ \  __<   \ \___  \  \ \  __ \  \ \  __\ \ \  __\   
 \ \_____\  \/\_____\  \ \_____\  \ \_____\  \ \_\ \_\  \/\_____\  \ \_\ \_\  \ \_\    \ \_____\ 
  \/_____/   \/_____/   \/_____/   \/_____/   \/_/ /_/   \/_____/   \/_/\/_/   \/_/     \/_____/ 
________________________________________________________________________________________________  ";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(header);
            Console.ResetColor();
        }
        //loading bar again it isnt loading anything this is just to simulate one
        static void ShowLoading()
        {
            Console.Write(" \x1b[90mThinking");
            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(200);
                Console.Write(".");
            }
        }

        
        //makes it type gradually so the message isnt instant
        static void TypeWriter(string message)
        {
            foreach (char c in message) //(GeeksForGeeks, 2026) 
            {
                Console.Write(c);
                Thread.Sleep(15);
            }
        }
    }
}


/*
 Reference List


https://www.geeksforgeeks.org/c-sharp/dictionary-in-c-sharp/ (GeeksForGeeks,9,Sep,2025)
https://www.geeksforgeeks.org/c-sharp/c-sharp-program-to-display-date-in-string/ (GeeksForGeeks,27,Dec,2021)
https://www.geeksforgeeks.org/c-sharp/c-sharp-how-to-change-foreground-color-of-text-in-console/ (GeeksForGeeks,28 Jan, 2019)
https://www.geeksforgeeks.org/c/c-while-loop/ (GeeksForGeeks, 8 Oct, 2025)
https://www.geeksforgeeks.org/c-sharp/c-sharp-foreach-loop/ (GeeksForGeeks, 19 Mar, 2026) 
 
 */