using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_CSharp
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
            user.FirstName = "Aaron";
            user.LastName = "Pongtongmuang";
          Console.WriteLine(string.Format("full name: {0}", user.GetFullName()));
        }
    }
}
