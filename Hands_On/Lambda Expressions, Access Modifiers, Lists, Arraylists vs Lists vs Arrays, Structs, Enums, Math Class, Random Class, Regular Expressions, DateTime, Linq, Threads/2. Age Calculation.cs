using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx1              
{
    public class Program       
    {
        public static void Main(string[] args)    
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy",null);
            string dt=dob.ToString("dd-mm-yyyy");
            Console.WriteLine(calculateAge(dt));
        }

        public static int calculateAge(string dateOfBirth)
        {
            int birthyear=Int32.Parse(dateOfBirth.Substring(6,4));
            int birthmonth=Int32.Parse(dateOfBirth.Substring(3,2));
            int birthdate=Int32.Parse(dateOfBirth.Substring(0,2));
            var t=DateTime.Today;
            var a=(t.Year*100+t.Month)*100+t.Day;
            var b=(birthyear*100+birthmonth)*100+birthdate;
            return (a-b-400)/10000;
        }
    }
}
