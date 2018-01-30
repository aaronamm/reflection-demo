using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.CSharp
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.FirstName = "Ariel";
            user.LastName = "Schmidt";
            var fulllName = user.GetFullName();


            var userType = user.GetType();

            var firstNameProperty = userType.GetProperty("FirstName");
            var lastNameProperty = userType.GetProperty("LastName");

            firstNameProperty.SetValue(user, "Emma");
            lastNameProperty.SetValue(user, "Jacobson");

            var getfullNameMethod = userType.GetMethod("GetFullName");
            var fullNameValue = getfullNameMethod.Invoke(user, null);



        }
    }
}
