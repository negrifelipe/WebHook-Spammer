using WebHook_Sender_Library;
using System;

namespace WebHookSpammer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this webhook spammer!");
            Console.WriteLine("Enter a webhook to start spamming");
            var webhook = Console.ReadLine();
            Console.WriteLine("Okey the webhook to spam is: " + webhook);
            Console.WriteLine("Enter the message that you want to spam!");
            var message = Console.ReadLine();
            Console.WriteLine("Okey the message is: " + message);
            Console.WriteLine("Now enter the number of webhooks that you want to spam!");
            var times = Console.ReadLine();
            WebHookSender.Send(webhook, message, Convert.ToInt32(times));
        }
    }
}
