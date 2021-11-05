using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketApp
{
    public class OwodaApp
    {
        public double AccountBalance = 0;
        public int TotalNumberOfTicket = 0;
        public double DailyTicketCost = 100;
        public double BossPercentage = 0.65;
        public string TicketSelected { get; set; }
        public double AvailableBalance { get; set; }

        //what the user wants to do
        public void Owoda()
        {
            Console.WriteLine("Owoda App");
            Console.WriteLine("Daily Ticket cost 100 naira. 50% discount for Monthly Ticket");
            Console.WriteLine("Press 1 to sell ticket \nPress 2 to check account summary ");
            string userChoice = Console.ReadLine();

            while (userChoice == "1")
            {
                TotalAmountInAccount();
                TotalNumberOfTicket++;
                Random ticketNumber = new Random();
                Console.WriteLine($"Ticket Sold! The Ticket number is {ticketNumber.Next()}");
                Console.WriteLine("Press 1 to sell ticket \nPress 2 to check account summary ");

                userChoice = Console.ReadLine();
            }
            AccountSummary();
        }
        public void TotalAmountInAccount()
        {
            Console.WriteLine("press 1 to select daily ticket \npress 2 for monthly ticket");
            TicketSelected = Console.ReadLine();
            AccountBalance = AccountBalance + TicketTypeCost(TicketSelected);
        }

        public double TicketTypeCost(string userChoice)
        {
            if (userChoice == "1")
            {
                return DailyTicketCost;
            }
            else
            {
                return DailyTicketCost / 2 * 30;
            }
        }

        public void AccountSummary()
        {
            Console.WriteLine($"You have sold {TotalNumberOfTicket} tickets");
            Console.WriteLine($"Your total balance is {AccountBalance} naira");
            double bossCharges = AccountBalance * BossPercentage;
            Console.WriteLine($" {bossCharges} naira will be charged for Boss payment");
            AvailableBalance = AccountBalance - bossCharges;
            Console.WriteLine($"your available balance is {AvailableBalance}");
            Receipt();           
        }

        public void Receipt()
        {
            DateTime now = DateTime.Now;
            Random receiptNumber = new Random();

            Console.WriteLine("\n \npress 1 to print receipt");
            string receipt = Console.ReadLine();


            if(receipt == "1" && TotalNumberOfTicket > 0)
            {

                Console.WriteLine($"Time: {now}");
                Console.WriteLine($"Total Ticket sold:{TotalNumberOfTicket} ");
                Console.WriteLine($"Receipt Number: {receiptNumber.Next()}");
                Console.WriteLine($"Total Available Balance: {AvailableBalance}");
            } 
            else
            {
                Console.Write("oops You have not made any sales");
            }





           

        }

    }
}
