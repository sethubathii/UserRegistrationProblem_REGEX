using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationProblem_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRegistrationProblem user = new UserRegistrationProblem();
            user.Validation();
            Console.ReadLine();
        }
    }
}
