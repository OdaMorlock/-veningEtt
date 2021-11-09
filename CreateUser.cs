using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CreateUser
    {
        public static void CreateAUser()
        {

            GetUserName getUserName = new GetUserName();
            UserInfo userInfo = new UserInfo();

            //Getting FirstName
            Console.WriteLine("What´s your FirstName?");
            userInfo.FirstName = getUserName.UserName();

            //Getting LastName
            Console.WriteLine("What´s your LastName?");
            userInfo.LastName = getUserName.UserName();

            //Final Error Check incase something happen and return null or Empty
            if (!String.IsNullOrWhiteSpace(userInfo.FirstName) || !String.IsNullOrWhiteSpace(userInfo.LastName))
            {

                userInfo.UserName = getUserName.SetUserName(userInfo.FirstName, userInfo.LastName);

                Console.WriteLine($"{userInfo.UserName}");

            }

            else
            {
                Console.WriteLine("Somehow First name and/or Last Name is empty");
            }

            //Save userInfo.UserName too DB

        }
    }
}
