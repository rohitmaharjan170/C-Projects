using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SHA1_Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("enter Something");
			string password = Console.ReadLine();

			Console.WriteLine("\n \n THe plain password is: ' " + password + " '");


			SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();

			byte[] password_bytes = Encoding.ASCII.GetBytes(password);
			byte[] encrypted_bytes = sha1.ComputeHash(password_bytes);

			Console.WriteLine("\n \n THe hashed password is:' "+ Convert.ToBase64String(encrypted_bytes) + " '" );
			//Console.Write(Convert.ToBase64String(encrypted_bytes));

			Console.ReadLine();

		}
	}
}
