using ExtensionsLib;
using System;
using System.IO;
using System.Linq;

namespace HighEntropyPassphrases
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[][] passphrases = Extensions.ReadStringMatrixFromFile(Path.Combine(Environment.CurrentDirectory, "passphrases.txt"));
            
            Console.WriteLine(passphrases.Count(passphrase => passphrase.HasDuplicates()));
            Console.WriteLine(passphrases.Count(passphrase => passphrase.HasAnagrams()));
        }
    }
}
