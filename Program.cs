using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace bubbleSortAttemp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] score = new int[] { 10, 50, 20, 30, 6 };

            int temp;

            for (int count = 1; count < score.Length; count++)
            {
                for (int index = 0; index < score.Length-1; index++)
                {
                    if (score[index] > score[index + 1])
                    {
                        temp = score[index];
                        score[index] = score[index + 1];
                        score[index + 1] = temp;
                    }
                }
            }


            for(int index=0;index <score.Length;index++)
            {
                Console.Write(score[index]+ " ");
            }
        }
    }
}
