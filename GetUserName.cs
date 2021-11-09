using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class GetUserName
    {

        public string UserName()
        {

            var Name = Console.ReadLine();

            bool containsInt = Name.Any(char.IsDigit);



            //Check for Null or EmptySpace (SpaceBar)
            if (String.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("You dident write anything please try one more time");
                Name = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(Name))
                {
                    Console.WriteLine("Program will End");

                    Console.ReadLine();

                    Environment.Exit(0);

                }
            }



            //Check for Number in string 
            if (containsInt)
            {
                Console.WriteLine("You wrote a Number Please use letters");
                Name = Console.ReadLine();

                containsInt = Name.Any(char.IsDigit);

                if (containsInt)
                {
                    Console.WriteLine("Program will End");

                    Console.ReadLine();

                    Environment.Exit(0);

                }
            }


            return Name;


        }

        public string SetUserName(string UserFirstName, string UserLastName) 
        {

            //Getting First lett from FirstName
            var FirstLetter = UserFirstName.Substring(0, 1);

            var UserName = FirstLetter + "." + UserLastName;

            return UserName;

        }

 
    }
}
