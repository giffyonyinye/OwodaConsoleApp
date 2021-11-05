using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    public class OwodaApp
    {
        public double accountBalance = 0;
        public int totalNumberOfTicket = 0;
        public double dailyTicketCost = 100;
        public double bossPercentage = 0.65;
        public string TicketSelected { get; set; }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Owoda App");
            Console.WriteLine("Press 1 to sell ticket \nPress 2 to check account summary ");
            string userChoice = Console.ReadLine();

            while (userChoice == "1")
            {
                TotalAmountInAccount();
                totalNumberOfTicket++;
                Random ticketNumber = new Random();
                Console.WriteLine("Ticket Sold! The Ticket number is " + ticketNumber.Next());
                Console.WriteLine("Press 1 to sell ticket \nPress 2 to check account summary ");

                userChoice = Console.ReadLine();
            }
            AccountSummary();
        }
        public void TotalAmountInAccount()
        {
            Console.WriteLine("press 1 to select daily ticket \npress 2 for monthly ticket");
            TicketSelected = Console.ReadLine();
            accountBalance = accountBalance + TicketTypeCost(TicketSelected);
        }

        public double TicketTypeCost(string userChoice)
        {
            if (userChoice == "1")
            {
                return dailyTicketCost;
            }
            else
            {
                return dailyTicketCost / 2 * 30;
            }
        }

        public void AccountSummary()
        {
            Console.WriteLine($"You have sold {totalNumberOfTicket} tickets");
            Console.WriteLine($"Your total balance is {accountBalance} naira");
            double bossCharges = accountBalance * bossPercentage;
            Console.WriteLine($" {bossCharges} naira will be charged for Boss payment");
            var availableBalance = accountBalance - bossCharges;
            Console.WriteLine($"your available balance is {availableBalance}");

        }


    }
}
