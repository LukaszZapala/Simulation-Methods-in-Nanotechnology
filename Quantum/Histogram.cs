using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum
{
    // http://www.statystyka-zadania.pl/histogram/

    class Histogram
    {
        private double length, min, max;
        public int numbOfSection;
        public double[] vector, frequency, sectionSum;
        public double[,] section;

        public Histogram(Quantum quantum, double min, double max)
        {
            this.min = min;
            this.max = max;

            vector = new double[quantum.countAlpha * quantum.N];

            RewriteAndSortTable(quantum);

            numbOfSection = Convert.ToInt32(Math.Sqrt(vector.Length));

            length = (vector.Max() - vector.Min()) / numbOfSection;

            section = new double[numbOfSection, 3];
            CreataSection();

            frequency = new double[numbOfSection];
            sectionSum = new double[numbOfSection];
            for (int i = 0; i < numbOfSection; i++)
            {
                frequency[i] = 0;
                sectionSum[i] = 0;
            }


            CountingData();
        }

        private void CountingData()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int k = 0; k < numbOfSection; k++)
                {
                    if (vector[i] >= section[k, 0] && vector[i] < section[k, 1])
                    {
                        frequency[k]++;
                        sectionSum[k] += vector[i];
                    }
                }
            }
        }

        private void RewriteAndSortTable(Quantum _quantum)
        {
            int j = 0;
            for (int i = 0; i < _quantum.countAlpha; i++)
            {
                for (int k = 1; k < _quantum.N + 1; k++)
                {
                    vector[j] = _quantum.outputMatrix[i, k];
                    j++;
                }
            }
            Array.Sort(vector);
            
            var tmp = Array.FindAll(vector, x => ( x >= min && x <= max ));

            vector = null;
            vector = tmp;
        }

        private void CreataSection()
        {
            for (int i = 0; i < numbOfSection; i++)
            {
                section[i, 0] = i == 0 ? vector.Min() : section[i - 1, 1];
                section[i, 1] = section[i, 0] + length;
                section[i, 2] = (section[i, 0] + section[i, 1]) / 2.0;
            }
        }
    }
}
