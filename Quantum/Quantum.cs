using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Double;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantum
{
    class Quantum
    {
        public int n, k, h, N, countAlpha, countX;
        public double a, lambda, minBeta, maxBeta, minAlpha, maxAlpha, minX, maxX, m = 1.0;
        public bool normalize = false;

        private Matrix<double> matrixS, matrixSalpha, matrixT, matrixTalpha, matrixH, matrixValpha, matrixI;
        public Matrix<double> potentialMatrix, outputMatrix;

        private Vector<double> alphas, betas, factorials, vector;

        // Initialializacja macierzy i wektorów
        public void InitializeMatrixAndVectors()
        {
            matrixS = Matrix<double>.Build.Dense(N, N);
            matrixSalpha = Matrix<double>.Build.Dense(N, N);
            matrixT = Matrix<double>.Build.Dense(N, N);
            matrixTalpha = Matrix<double>.Build.Dense(N, N);
            matrixValpha = Matrix<double>.Build.Dense(N, N);
            matrixH = Matrix<double>.Build.Dense(N, N);
            potentialMatrix = Matrix<double>.Build.Dense(countX, 2);
            outputMatrix = Matrix<double>.Build.Dense(countAlpha, N + 1);

            alphas = Vector<double>.Build.Dense(countAlpha);
            betas = Vector<double>.Build.Dense(N);
            factorials = Vector<double>.Build.Dense(5);
        }

        // Obliczenie potencjału
        public void GetPotential()
        {
            double q = (maxX - minX) / countX;

            for (int i = 0; i < countX; i++)
            {
                potentialMatrix[i,0] = minX + i * q;
                potentialMatrix[i,1] = a * Math.Pow(Math.Abs(potentialMatrix[i, 0]), n) * Math.Exp((-1) * lambda * Math.Abs(potentialMatrix[i, 0]));
            }
        }

        // Obliczenie i wypełnienie wektora betas
        private void FillBetasVector()
        {
            var q = Math.Pow((maxBeta / minBeta), 1.0 / Convert.ToDouble(N - 1));

            for (int i = 0; i < N; i++)
            {
                betas[i] = minBeta * Math.Pow(q, i);
            }
        }

        // Obliczenie i wypełnienie wektora alphas
        private void FillAlphasVector()
        {
            alphas = Vector<double>.Build.DenseOfArray(Generate.LinearRange(minAlpha, (maxAlpha - minAlpha) / countAlpha, maxAlpha));
        }

        // Obliczamy używane przez nas w kodzie silnie
        private void FillFactorialVector()
        {
            // (ki + kj)!
            factorials[0] = SpecialFunctions.Factorial(k + k);
            // (ki + kj + 1)!
            factorials[1] = SpecialFunctions.Factorial(k + k + 1);
            // (ki + kj - 1)!
            factorials[2] = SpecialFunctions.Factorial(k + k - 1);
            // (ki + kj - 2)!
            factorials[3] = SpecialFunctions.Factorial(k + k - 2);
            // (ki + kj + n)!
            factorials[4] = SpecialFunctions.Factorial(k + k + n);
        }

        // Budujemy macierz S
        private void BuildMatrixS()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // 2 * (ki + kj)! / (Bi + Bj)^(ki + kj + 1)
                    matrixS[i, j] = 2.0 * factorials[0] / Math.Pow(betas[i] + betas[j], k + k + 1);
                }
            }
        }

        // Budujemy macierz S
        private void BuildMatrixT()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // ki * kj * (ki + kj - 2)! / (Bi + Bj) ^ (ki + kj - 1)
                    double partOne = k * k * factorials[3] / Math.Pow(betas[i] + betas[j], k + k - 1);
                    // (ki * Bj + kj * Bi) * (ki + kj - 1)! / (Bi + Bj) ^ (ki + kj)
                    double partTwo = (k * betas[j] + k * betas[i]) * factorials[2] / Math.Pow(betas[i] + betas[j], k + k);
                    // Bi * Bj * (ki + kj)! / (Bi + Bj) ^ (ki + kj + 1)
                    double partThree = betas[i] * betas[j] * factorials[0] / Math.Pow(betas[i] + betas[j], k + k + 1);

                    matrixT[i, j] = (Math.Pow(h,2) / m) * (partOne - partTwo + partThree);
                }
            }            
        }

        // Budujemy macierz V(alpha)
        private void BuildMatrixValpha(double alpha)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    // 2.0 * a * alpha ^ (ki + kj) * (ki + kj + n)! / (alpha * (Bi + Bj) + lambda) ^ (ki + kj + n + 1)
                    matrixValpha[i, j] = 2.0 * a * Math.Pow(alpha, k + k) * factorials[4] / Math.Pow(alpha * (betas[i] + betas[j]) + lambda, k + k + n + 1);
                }
            }
        }

        // Metoda normowania
        private double Norm(int i)
        {
            return 1.0 / Math.Sqrt(matrixS[i, i]);
        }

        // Wypełniamy wektor normowania
        private void FillNormVector()
        {
            vector = Vector<double>.Build.Dense(N);

            for (int i = 0; i < N; i++)
            {
                vector[i] = Norm(i);
            }
        }

        // Normalizacja macierz A po macierzy B
        private void NormMatrix(Matrix<double> matrix)
        {      
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = matrix[i, j] * vector[i] * vector[j];
                }
            }
        }

        // Obliczamy energię
        public void GetEnergy()
        {
            FillAlphasVector();
            FillBetasVector();
            FillFactorialVector();

            // Macierz S
            BuildMatrixS();
            FillNormVector();
            NormMatrix(matrixS);
            SaveMatrix(matrixS, N, N, "matrixS.csv");

            // Macierz T
            BuildMatrixT();
            NormMatrix(matrixT);
            SaveMatrix(matrixT, N, N, "matrixT.csv");

            for (int i = 0; i < countAlpha; i++)
            {
                // Macierze S(alpha) i T(alpha)
                matrixSalpha = (1.0 / alphas[i]) * matrixS;
                matrixTalpha = alphas[i] * matrixT;

                // Macierz V(alpha)
                BuildMatrixValpha(alphas[i]);
                NormMatrix(matrixValpha);
                SaveMatrix(matrixValpha, N, N, "matrixValpha.csv");

                // Macierz H
                matrixH = matrixTalpha + matrixValpha;
                SaveMatrix(matrixH, N, N, "matrixH.csv");

                // Macierz energii
                var energy = matrixSalpha.Inverse() * matrixH;
                SaveMatrix(energy, N, N, "matrixEnergy.csv");

                // Wyciąganie wartości własnych
                Evd<double> evd = energy.Evd();
                var vector = evd.EigenValues;
                
                for (int j = 0; j < N + 1; j++)
                {
                    outputMatrix[i, j] = j == 0 ? alphas[i] : vector[j - 1].Real;
                }
            }

            SaveMatrix(outputMatrix, countAlpha, N + 1, "matrixOutput.csv");
        }

        // Zapisywanie macierzy do pliku
        private void SaveMatrix(Matrix<double> matrix, int row, int column, string filename)
        {
            using (var sw = new StreamWriter(filename, true))
            {
                for (int i = 0; i < row; i++)
                {
                    string tmp = "";
                    for (int j = 0; j < column; j++)
                    {
                        tmp += matrix[i, j] + ";";
                    }
                    sw.WriteLine(tmp);
                }
                sw.WriteLine();
                sw.WriteLine();
            }
        }

        
        public double FindMaximumPotential()
        {
            var max = potentialMatrix[0, 1];
            for (int i = 1; i < countX; i++)
            {
                if (potentialMatrix[i, 1] > max) max = potentialMatrix[i, 1];
            }

            return max;
        }
    }
}
