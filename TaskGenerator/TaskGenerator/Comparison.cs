using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskGenerator
{
    class Comparison
    {
        private int[] Numbers = new int[2];
        private int[] Range = new int[2];
        private char Result;

        public void SetRange(int Min, int Max)
        {
            if (Min < Max)
            {
                Range[0] = Min;
                Range[1] = Max;
            }
        }

        public void GenerateTask()
        {
            Random Rand = new Random();
            
            Numbers[1] = Rand.Next(Range[0], Range[1]);
            Numbers[0] = Rand.Next(Range[0], Range[1]);

            Compare();
        }

        private void Compare()
        {
            if (Numbers[0] > Numbers[1])
                Result = '>';
            else if (Numbers[0] < Numbers[1])
                Result = '<';
            else
                Result = '=';
        }

        public char GetResult()
        {
            return this.Result;
        }

        public int GetNumbers(int Index)
        {
            if (Index == 0)
                return Numbers[0];
            else
                return Numbers[1];
        }
    }
}
