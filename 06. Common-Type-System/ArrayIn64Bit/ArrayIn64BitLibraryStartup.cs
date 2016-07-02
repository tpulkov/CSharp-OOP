namespace Array64Bit
{
    using System;

    public class ArrayIn64BitLibraryStartup
    {
        public static void Run()
        {
            var bitsArray = new BitArray(128);
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Problem 5. 64 Bit array: \n");
            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Bits: {0}", bitsArray);
            Console.WriteLine("Value: {0}\n", bitsArray.Value);

            // change index in array
            bitsArray[30] = 1;
            Console.WriteLine("Bits: {0}", bitsArray);
            Console.WriteLine("Value: {0}\n", bitsArray.Value);

            Console.Write("Bits: ");
            var maxArray = new BitArray(ulong.MaxValue);
            foreach (var bit in maxArray)
            {
                Console.Write(bit);
            }

            Console.WriteLine();
            Console.WriteLine("Value: {0}\n", maxArray.Value);

            var newArray = new BitArray(32);
            Console.WriteLine(bitsArray.Equals(newArray));
            Console.WriteLine(newArray != bitsArray);
        }
    }
}
