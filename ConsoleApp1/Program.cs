using System;
using System.Text.RegularExpressions;
using Ucb.Encryption.Interfaces;
using Ucb.Encryption.Repositories;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             IEncryptionHelper helper = new EncryptionHelper();
            Console.WriteLine(helper.DecryptParameterId("KFHHPZw8mfB%252bBhaOFtjNiw==")); //20007911, 20000043
            Console.ReadKey();
        }

        // Enum   
        public enum Weekday
        {
            Monday = 0, Tuesday = 1, Wednesday = 2, Thursday = 4, Friday = 5, Saturday = 6, Sunday = 7
        }
    }
}
