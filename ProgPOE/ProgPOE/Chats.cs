using System;
using System.Collections.Generic;

namespace ProgPOE
{
    public static class Chats
    {
        private static Dictionary<string, string> responses = new Dictionary<string, string>() //(GeeksForGeeks,2025)
        {
            { "how are you", "I am functioning well. More importantly, how are you today?" },
            { "date", "The current time is: " + DateTime.Now.ToString("f") },//(GeeksForGeeks,2021)
            { "purpose", "My purpose is to give you information on CyberSecurity." },
            { "information", "I can give you details on: PHISHING, PASSWORDS, MALWARE, and general SECURITY. Use these keywords please." },
            { "phishing", "Phishing is a malicious way used to steal private data: passwords, CC numbers via social engineering." },
            { "password", "A strong password is a password that Uses 12 characters, mix cases, symbols, and avoiding common words or personal info." },
            { "malware", "Malware is malicious software designed to damage, steal, or disable computers and networks." },
            { "security", "Always verify links via VirusTotal. Never click attachments. Enable 2FA on everything and use common sense." }

        };


        public static string GetResponse(string input)
        {
            foreach (var key in responses.Keys)
            {
                if (input.Contains(key)) return responses[key];
            }
            return "Query not found. Please try keywords like 'phishing' or 'security'.";
        }

        public static void ShowAvailableQuestions()
        {
            Console.WriteLine("\n \x1b[1mAVAILABLE MODULES:\x1b[0m"); //(GeeksForGeeks, 2019)
            Console.WriteLine(" ───────────────────────────────────────────────────");
            Console.WriteLine("  • Status/Date      • Phishing Info");
            Console.WriteLine("  • Malware Intel    • Password Security");
            Console.WriteLine(" ───────────────────────────────────────────────────");
        }
    }
}


/*
 Reference List


https://www.geeksforgeeks.org/c-sharp/dictionary-in-c-sharp/ (GeeksForGeeks,9,Sep,2025)
https://www.geeksforgeeks.org/c-sharp/c-sharp-program-to-display-date-in-string/ (GeeksForGeeks,27,Dec,2021)
https://www.geeksforgeeks.org/c-sharp/c-sharp-how-to-change-foreground-color-of-text-in-console/ (GeeksForGeeks,28 Jan, 2019)
 
 
 
 
 */