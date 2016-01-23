using MathNet.Numerics.LinearAlgebra;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Graphene
{
    public class Graphene
    {
        private const double Precision = 0.157;
        private int numberOfAtom, numberOfConnection;
        private Matrix<double> infoMatrix;

        public string pathInputFile;
        public int row, columns;
        public Matrix<double> resultingMatrix;

        public Graphene(string path)
        {
            pathInputFile = path;

            using (var file = new StreamReader(path))
            {
                string line;

                for (int i = -1; (line = file.ReadLine()) != null; i++)
                {
                    var numbers = line.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);

                    if (i == -1)
                    {
                        numberOfAtom = Convert.ToInt32(numbers[0]);
                        numberOfConnection = Convert.ToInt32(numbers[1]);

                        infoMatrix = Matrix<double>.Build.Dense(numberOfConnection, 3);
                    }
                    else
                    {
                        infoMatrix[i, 0] = Convert.ToInt32(numbers[0]);
                        infoMatrix[i, 1] = Convert.ToInt32(numbers[1]);
                        infoMatrix[i, 2] = Convert.ToInt32(numbers[2]);
                    }
                }

                file.Close();
            }
        }

        public void Logic()
        {
            int p = Convert.ToInt32(Math.PI / Precision) + 1, j = 0;
            var hermitianMatrix = Matrix<Complex>.Build.Dense(numberOfAtom, numberOfAtom);

            row = numberOfAtom + 1;
            columns = p;

            resultingMatrix = Matrix<double>.Build.Dense(row, columns);

            for (double k = 0; k <= Math.PI; k += Precision)
            {
                BuildHermitianMatrix(hermitianMatrix, infoMatrix, k, numberOfConnection);

                var evd = hermitianMatrix.Evd();
                Vector<Complex> wektor = evd.EigenValues;

                for (int i = 0; i < row; i++)
                {
                    resultingMatrix[i, j] = i == 0 ? k : wektor[i - 1].Real;
                }
                j++;
            }
        }

        private void BuildHermitianMatrix(Matrix<Complex> hermitianMatrix, Matrix<double> pairMatrix, double k, int m)
        {
            hermitianMatrix.Clear();

            Complex top = new Complex();
            Complex down = new Complex();

            for (int l = 0; l < m; l++)
            {
                switch ((int)pairMatrix[l, 2])
                {
                    case 1:         // 1
                        top = Complex.One;        // Top
                        down = Complex.One;       // Down
                        break;
                    case 2:         // e^(ik)
                        top = new Complex(Math.Cos(k), Math.Sin(k));              // Top
                        down = new Complex(Math.Cos(k), -Math.Sin(k));            // Down
                        break;
                    case 3:         // e^(-ik)
                        top = new Complex(Math.Cos(k), -Math.Sin(k));            // Top
                        down = new Complex(Math.Cos(k), Math.Sin(k));             // Down
                        break;
                    case 4:         // [1 + e^(ik)]
                        top = new Complex(1 + Math.Cos(k), Math.Sin(k));          // Top
                        down = new Complex(1 + Math.Cos(k), -Math.Sin(k));        // Down
                        break;
                    case 5:         // [1 + e^(-ik)]
                        top = new Complex(1 + Math.Cos(k), -Math.Sin(k));         // Top
                        down = new Complex(1 + Math.Cos(k), Math.Sin(k));         // Down
                        break;
                    default:
                        Console.WriteLine("Nie znana informacja o połączeniu!");
                        break;
                }

                int i = Convert.ToInt32(pairMatrix[l, 0]) - 1;
                int j = Convert.ToInt32(pairMatrix[l, 1]) - 1;

                hermitianMatrix[i, j] = top;
                hermitianMatrix[j, i] = down;
            }
        }
    }
}
