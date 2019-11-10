using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort data =             0b0000000111111000;
            Int32 maskResult = data & 0b1111111111111111;
            Int32 resultXOR = CalculataionXOR(maskResult);
            Int32 resultNOT = CalculationNOT(resultXOR);

            BitArray bitArray = new BitArray(new Int32[] { resultNOT });

            BitArray bitAreaData = DefineBitArea(bitArray);
            int countMatchNum = CountMatchNum(bitAreaData);
            Console.WriteLine(countMatchNum.ToString());
        }

        static Int32 CalculataionXOR(Int32 data)
        {
            Int32 resultXOR = data ^ (data >> 1);
            return resultXOR;
        }


        static Int32 CalculationNOT(Int32 data)
        {
            Int32 resultNOT = ~data;
            return resultNOT;
        } 

        static BitArray DefineBitArea(BitArray data)
        {
            BitArray BitAreaData = new BitArray(6);
            for (int i = 2; i<= 7; i++)
            {               
                for (int j = 0; j < BitAreaData.Length; j++)
                {
                    BitAreaData[j] = data.Get(i);
                }
            }
            return BitAreaData;
        }

        static int CountMatchNum(BitArray data)
        {
            int countMatch = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if (data.Get(i) == true)
                {
                    countMatch++;
                }
            }
            return countMatch;
        }
    }

    
}
