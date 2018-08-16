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
            var passphrases = Extensions.ReadPassphrases(Path.Combine(Environment.CurrentDirectory, "passphrases.txt"));
            
            Console.WriteLine(passphrases.Count(new NoDuplicatesPolicy().IsSatisfied));
            Console.WriteLine(passphrases.Count(new NoAnagramsPolicy().IsSatisfied));
        }
    }
}
