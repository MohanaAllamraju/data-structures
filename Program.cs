using System;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();
            Console.WriteLine(validator.DetectBadWord("vramanaasshole@gmail.com"));
        }
    }
}
