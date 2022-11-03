
using System;
using System.Collections.Generic;

namespace BallsBowled       
{
    public class Program   
    {
        static void Main(string[] args)
        {
            //Implement code here
            
            Console.WriteLine("Enter the number of overs");
            int overs = int.Parse(Console.ReadLine());
            
            PlayerBO pb = new PlayerBO();
            pb.AddOversDetails(overs);
            
        }
   }

    public class PlayerBO      
    {
        public List<int> PlayerList { get; set; } = new List<int>();
        int balls;
        
        public void AddOversDetails(int oversBowled)       
        {
            //Implement code here
            PlayerList.Add(oversBowled);
            Console.WriteLine(PlayerList);
            foreach(int i in PlayerList)
            {
              balls = i;
            }
            Console.WriteLine("Balls Bowled : " + GetNoOfBallsBowled());
        }

        public int GetNoOfBallsBowled()              
        {
            //Implement code here
            return balls*6;
        }
    }
}