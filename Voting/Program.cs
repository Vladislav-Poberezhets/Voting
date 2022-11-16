using System;

namespace Voting
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select who you want to vote for.\nPress 0 to display the voting results");
            Ballot b = new Ballot(); b.PrintNameList();
            int i = -1;
            while (i != 0)
            {
                i = int.Parse(Console.ReadLine());
                if (b.VoteAdd(i)) 
                    Console.WriteLine("Your choice is recorded");
            }
            b.PrintResult();
            
            
        }
    }

    
}