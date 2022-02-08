using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFNumberKeep
{
    class NumberList
    {
        public List<int> Numbers = new List<int>();

        private int count;
        public int Count
        {
            get{ return count;}
            set{count = value;}
        }
        private int min;
        public int Min
        {
            get { return min; }
            set { Min = value; }
        }

        private int max;
        public int Max
        {
            get { return max; }
            set { Max = value; }
        }

        private double average;
        public double Average
        {
            get { return average; }
            set { average = value; }
        }


        public void AddNumber(int number)
        {
            Numbers.Add(number);
        }

        public int RefNumber(int refNumber)
        {
            int countRefNumber = 0;
            foreach (int number in Numbers)
            {
                if (refNumber == number)
                {
                    countRefNumber++;

                }
                Count = countRefNumber;
            }
            return Count;
        }
        public int MaxNumber()
        {
            int currentHighestNumber = 0;
            foreach (int number in Numbers)
            {
                if (currentHighestNumber < number)
                {
                    currentHighestNumber = number;
                }
            }
            //Max = currentHighestNumber;
            return currentHighestNumber;
        }

        public int MinNumber()
        {
            int currentLowestNumber = 10;
            foreach( int number in Numbers)
            {
                if (currentLowestNumber > number)
                {
                    currentLowestNumber = number;
                }
            }
            ////Min = currentLowestNumber;
            return currentLowestNumber;
        }
        public double AverageNumber()
        {
            int totalNumbers = Numbers.Count;
            double total = 0;
            foreach (int number in Numbers)
            {
                total += number;
            }
            double averageDivided = total / totalNumbers;
            //Average = averageDivided;
            return averageDivided;
        }



    }
}
