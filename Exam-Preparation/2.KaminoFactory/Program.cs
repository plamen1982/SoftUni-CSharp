using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = string.Empty;
            int theBestIndex = int.MaxValue;
            int theBiggestSeq = 0;
            int theBiggestSum = int.MinValue;
            int numberOfSequence = int.Parse(Console.ReadLine());
            List<int> theBestDna = new List<int>();
            int bestSample = 0;
            while ((line = Console.ReadLine()) != "Clone them!")
            {
                List<int> dna = line.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();
                int dnaSampleCounter = 1;
                int countSeq = 1;

                for (int index = 0; index < dna.Count; index++)
                {

                    if (index < dna.Count - 1)
                    {
                        if (dna[index] == 1 && dna[index + 1] == 1)
                        {
                            countSeq++;
                            if (theBiggestSeq < countSeq)
                            {
                                theBestIndex = index;
                                theBiggestSeq = countSeq;
                                theBestDna = CloneThem(dna);
                                bestSample = dnaSampleCounter;
                            }

                            else if (theBiggestSeq == countSeq)
                            {
                                if (theBestIndex == index)
                                {
                                    if (theBestDna.Sum() < dna.Sum())
                                    {
                                        theBestIndex = index;
                                        theBiggestSeq = countSeq;
                                        theBestDna = CloneThem(dna);
                                        bestSample = dnaSampleCounter;
                                    }
                                }
                                else
                                {
                                    if (theBestIndex > index)
                                    {
                                        theBestIndex = index;
                                        theBiggestSeq = countSeq;
                                        theBestDna = CloneThem(dna);
                                        bestSample = dnaSampleCounter;
                                    }
                                }
                            }
                        }
                    }
                    dnaSampleCounter++;
                }
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {theBestDna.Sum()}.");
            Console.WriteLine(string.Join(" ", theBestDna));
        }

        static List<int> CloneThem(List<int> dna)
        {
            List<int> theBestDna = new List<int>();
            foreach (var item in dna)
            {
                theBestDna.Add(item);
            }
            return theBestDna;
        }
    }
}