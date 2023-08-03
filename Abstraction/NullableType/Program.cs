using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //main function
    class Program
    {
        static void Main(string[] args)
        {

            //bool? AreYouMajor = null;

            //if(AreYouMajor == true)
            //{
            //    Console.WriteLine("User is a Major");
            //}
            //else if(AreYouMajor == false)
            //{
            //    Console.WriteLine("User is not a Major");
            //}
            //else
            //{
            //    Console.WriteLine("User did'nt Ans the question");
            //}


            //ANOTHER EXAMPLE (Null coalescing Operator ??)

            //int AvailableTickets;
            //int? TicketsOnSale = 100;

            //if(TicketsOnSale == null)
            //{
            //    AvailableTickets = 0;
            //}
            //else {

            //    AvailableTickets = TicketsOnSale.Value;

            //}

            //Console.WriteLine("Tickets Available = {0}", AvailableTickets);


            //Using null coalescing 

            int? TicketsOnSale = 100;

            int AvailableTickets = TicketsOnSale ?? 0;

            Console.WriteLine("Tickets Available : {0} ", AvailableTickets);

        }
    }
}
