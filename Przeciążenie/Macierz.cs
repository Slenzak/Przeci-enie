using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przeciążenie
{
    internal class Macierz
    {
        private double[,] elementy;

        public Macierz(int wiersze, int kolumny)
        {
            elementy = new double[wiersze, kolumny];
        }
        public void Inicjalizuj(double wartość)
        {
            for (int i = 0; i < elementy.GetLength(0); i++)
            {
                for (int j = 0; j < elementy.GetLength(1); j++)
                {
                    elementy[i, j] = wartość;
                }
            }
        }
        public static Macierz operator +(Macierz a, Macierz b)
        {
            if (a.elementy.GetLength(0) != b.elementy.GetLength(0) || a.elementy.GetLength(1) != b.elementy.GetLength(1))
            {
                throw new ArgumentException("Macierze muszą mieć taką samą wymiarowość do dodawania.");
            }

            Macierz wynik = new Macierz(a.elementy.GetLength(0), a.elementy.GetLength(1));
            for (int i = 0; i < a.elementy.GetLength(0); i++)
            {
                for (int j = 0; j < a.elementy.GetLength(1); j++)
                {
                    wynik.elementy[i, j] = a.elementy[i, j] + b.elementy[i, j];
                }
            }
            return wynik;
        }
        public static Macierz operator -(Macierz a, Macierz b)
        {
            if (a.elementy.GetLength(0) != b.elementy.GetLength(0) || a.elementy.GetLength(1) != b.elementy.GetLength(1))
            {
                throw new ArgumentException("Macierze muszą mieć taką samą wymiarowość do odejmowania.");
            }

            Macierz wynik = new Macierz(a.elementy.GetLength(0), a.elementy.GetLength(1));
            for (int i = 0; i < a.elementy.GetLength(0); i++)
            {
                for (int j = 0; j < a.elementy.GetLength(1); j++)
                {
                    wynik.elementy[i, j] = a.elementy[i, j] - b.elementy[i, j];
                }
            }
            return wynik;
        }

        public static Macierz operator *(Macierz a, Macierz b)
        {
            if (a.elementy.GetLength(1) != b.elementy.GetLength(0))
            {
                throw new ArgumentException("Liczba kolumn pierwszej macierzy musi być równa liczbie wierszy drugiej macierzy.");
            }

            Macierz wynik = new Macierz(a.elementy.GetLength(0), b.elementy.GetLength(1));
            for (int i = 0; i < wynik.elementy.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.elementy.GetLength(1); j++)
                {
                    for (int k = 0; k < a.elementy.GetLength(1); k++)
                    {
                        wynik.elementy[i, j] += a.elementy[i, k] * b.elementy[k, j];
                    }
                }
            }
            return wynik;
        }

        public static Macierz operator ++(Macierz macierz)
        {
            for (int i = 0; i < macierz.elementy.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.elementy.GetLength(1); j++)
                {
                    macierz.elementy[i, j] += 2;
                }
            }
            return macierz;
        }
        public static Macierz operator --(Macierz macierz)
        {
            for (int i = 0; i < macierz.elementy.GetLength(0); i++)
            {
                for (int j = 0; j < macierz.elementy.GetLength(1); j++)
                {
                    macierz.elementy[i, j] -= 2;
                }
            }
            return macierz;
        }
        public void Wyświetl()
        {
            for (int i = 0; i < elementy.GetLength(0); i++)
            {
                for (int j = 0; j < elementy.GetLength(1); j++)
                {
                    Console.Write(elementy[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
