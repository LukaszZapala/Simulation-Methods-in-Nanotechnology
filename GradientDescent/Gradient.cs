using System;

namespace GradientDescent
{
    public class Gradient
    {
        private int atomCount = 0;
        private double alpha = 0.0, A = 0.0, L = 0.0, d = 0.0;

        private double[] points, derivatives;

        public Gradient(int atomCount, double alpha, double A, double L, double d)
        {
            this.atomCount = atomCount;
            this.alpha = alpha;
            this.A = A; this.L = L; this.d = d;
        }

        public void SetStartPoint()
        {
            points = new double[atomCount];
            for (int k = 0; k < atomCount; k++)
            {
                points[k] = (k * L) / (double)(atomCount - 1);
            }
        }

        private double GetDerivatives(ref int k)
        {
            if (k == 0)
            {
                return 8 * A * (Math.Pow(points[0] - points[1], 2) - Math.Pow(d, 2)) * (points[0] - points[1]);
            }
            else if (k == (atomCount - 1) && atomCount != 1)
            {
                return 8 * A * (Math.Pow(points[atomCount - 2] - points[atomCount - 1], 2) - Math.Pow(d, 2)) 
                    + 2 * A * (Math.Pow(points[atomCount - 1] - points[atomCount - 2], 2) - Math.Pow(d, 2));
            }
            else
            {
                return (8 * A * (Math.Pow(points[k] - points[k - 1], 2) - Math.Pow(d, 2)) * (points[k] - points[k - 1])) -
                        (8 * A * (Math.Pow(points[k + 1] - points[k], 2) - Math.Pow(d, 2)) * (points[k + 1] - points[k]));
            }
        }

        public double GetNext()
        {
            double length = 0.0;
            derivatives = new double[atomCount];

            for (int k = 0; k < atomCount; k++)
            {
                derivatives[k] = this.GetDerivatives(ref k);
                length += Math.Pow(derivatives[k],2);
                points[k] -= alpha * derivatives[k];
            }

            return Math.Sqrt(length);
        }

        public string GetPoint()
        {
            string tmp = "";
            for (int i = 0; i < atomCount; i++)
            {
                tmp += points[i] + " ";
                //tmp += String.Format("{0:N2}", Math.Abs(points[i] - points[i + 1])) + " ";
            }
            return tmp;
        }
    }
}