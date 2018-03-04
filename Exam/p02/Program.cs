using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bestSequence = 0;
            int bestDNAIndex = 0;
            int bestStart = -1;
            int bestSum = 0;
            int[] bestDNA = new int[n];

            int counter = 0;
            int[] sequence = new int[n];


            while (true)
            {
                string input = Console.ReadLine();
               

                if (input.Contains("0") || input.Contains("1"))
                {
                    sequence = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                    int currentSequence = 0;
                    int currentStart = 0;
                    int currentSum = sequence.Sum();
                    bool zerosOnly = false;
                    // determine firs start
                    for (int i = 0; i < n; i++)
                    {
                        if (sequence[i] == 1)
                        {
                            currentStart = i;
                            break;
                        }
                        if (sequence[i] == 0 && i == n-1)
                        {
                            zerosOnly = true;
                        }
                    }
                    if (zerosOnly)
                    {
                        continue;
                    }


                    for (int i = 0; i < n; i++)
                    {
                        if (sequence[i] == 1)
                        {
                            currentSequence++;
                            if (i>0 && sequence[i-1] == 0)
                            {
                                currentStart = i - 1;
                            }
                        }
                        else
                        {
                            if (currentSequence > bestSequence)
                            {
                                bestSequence = currentSequence;
                                bestStart = currentStart;
                                bestDNAIndex = counter;
                                bestDNA = sequence;
                                bestSum = sequence.Sum();

                            }
                            else if(currentSequence == bestSequence)
                            {
                                if (currentStart < bestStart)
                                {
                                    bestStart = currentStart;
                                    bestDNAIndex = counter;
                                    bestDNA = sequence;
                                    bestSum = sequence.Sum();
                                }
                                else if (sequence.Sum() > bestSum)
                                {
                                    bestSum = sequence.Sum();
                                    bestDNAIndex = counter;
                                    bestDNA = sequence;
                                }
                            }

                            currentSequence = 0;
                            
                        }
                    }
                }

                else
                {
                    break;
                }
                counter++;
            }

            Console.WriteLine($"Best DNA sample {bestDNAIndex + 1} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
