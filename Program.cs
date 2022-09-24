using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Array1
{
    struct Task1
    {

        private int[] A;
        private float[,] B;

        public
        void FillA()
        {
            A = new int[5];
            B = new float[3, 4];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Введите цифру для {i + 1} елемента масива "); ;
                A[i] = Int32.Parse(Console.ReadLine());

            }
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    //float  r = Convert.ToSingle(random.NextDouble());
                    int r = random.Next(1, 10);
                    B[i, j] = r;

                }
            }
        }

        public int Max_A_B()
        {
            Array.Sort(A);
            int size = A.Length - 1;
            //Console.WriteLine("Size " + size);
            while (size >= 0)
            {
                foreach (int i in B)
                {
                    if (i == A[size])
                    {
                        return A[size];
                    }

                }
                size--;
            }

            return -1;
        }
        public int Min_A_B()
        {
            Array.Sort(A);
            int size = 0;
            //Console.WriteLine("Size " + size);
            while (size >= 0)
            {
                foreach (int i in B)
                {
                    if (i == A[size])
                    {
                        return A[size];
                    }

                }
                size++;
            }

            return -1;
        }


        public int Sum()
        {
            int sum = 0;
            foreach (int i in A)
            {
                sum += i;
            }
            foreach (int i in B)
            {
                sum += i;
            }

            return sum;
        }

        public int SumOfEvenA()
        {
            int sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                    sum += A[i];
            }


            return sum;
        }

        public int SumOfOddColumnsB()
        {
            int sum = 0;
            Console.WriteLine("В->: " + B.GetLength(0) + "-> " + B.GetLength(1));
            for (int i = 0; i < B.GetLength(0); i++)
            {

                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if ((j + 1) % 2 != 0)
                        sum += (int)B[i, j];
                }


            }
            return sum;
        }
        public long ProductsOfNumber()
        {
            long sum = 1;
            foreach (int i in A)
            {
                sum *= i;
            }
            foreach (int i in B)
            {
                sum *= i;
            }

            return sum;
        }

        public void Show()
        {
            Console.Write("Масив А: ");
            foreach (var i in A)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Масив B: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "      ");
                }
                Console.WriteLine();
            }
        }

    };

    struct Task2
    {
        private int[,] A;

        public void FillA()
        {
            Random rand = new Random();
            A = new int[5, 5];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    A[i, j] = rand.Next(-100, 100);

            }


        }

        public void Show()
        {
            Console.Write("Масив (5х5): \n");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                    Console.Write(A[i, j] + "      ");
                Console.WriteLine();
            }
        }
        public int Sum()
        {
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;
            int max = A[0, 0];
            int min = A[0, 0];
            int sum = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (max < A[i, j])
                    {
                        max = A[i, j];
                        i1 = i;
                        j1 = j;
                    }
                    if (min > A[i, j])
                    {
                        min = A[i, j];
                        i2 = i;
                        j2 = j;
                    }
                }

            }
            Console.WriteLine("Максимальное значение элементов = " + A[i1, j1]);
            Console.WriteLine("Минимальное значение элементов = " + A[i2, j2] + "\n");
            if (i1 > i2)
            {
                for (int i = i2; i <= i1; i++)
                {

                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        if (i == i2 && j == 0)
                            j = j2;
                        if (i == i1 && j == j1)
                        {
                            sum += A[i, j];
                            return sum;
                        }
                        sum += A[i, j];
                    }
                }
                return sum;
            }
            else
            {
                if (i1 < i2)
                {
                    for (int i = i1; i <= i2; i++)
                    {

                        for (int j = 0; j < A.GetLength(1); j++)
                        {
                            if (i == i1 && j == 0)
                                j = j1;
                            if (i == i2 && j == j2)
                            {
                                sum += A[i, j];
                                return sum;
                            }
                            sum += A[i, j];
                        }
                    }
                    return sum;
                }
                else
                {
                    if (j1 < j2)
                    {
                        for (int j = j1; j <= j2; j++)
                        {

                            sum += A[i1, j];

                        }
                        return sum;

                    }
                    else
                    {
                        for (int j = j2; j <= j1; j++)
                        {

                            sum += A[i1, j];

                        }
                        return sum;
                    }
                }
            }
        }

    }
    struct Task4
    {
        private int[,] matrix;
        public void MultByNumber(int number)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] *= number;
                }
            }

        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;

        }
        public void Fill_matrix()
        {
            Random rand = new Random();
            matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rand.Next(1, 9);

            }


        }
        public long Products()
        {
            long result = 1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    result *= matrix[i, j];
                }
            }


            return result;
        }

        public void Show()
        {
            Console.Write("Матрица: \n");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write(matrix[i, j] + "      ");
                Console.WriteLine();
            }
        }


    };
    struct Task5
    {
        private int result;
        public int Result()
        {
            Console.WriteLine("Введите выражение ");
            string a = Console.ReadLine();
            char[] oper = { '+', '-' };
            var array = a.Split(oper, StringSplitOptions.None);
            int x = Int32.Parse(array[0]);
            int b = Int32.Parse(array[1]);

            if (a.Contains('-'))
            {
                result = x - b;
            }
            if (a.Contains('+'))
            {
                result = x + b;
            }


            return result;
        }

    };


    struct Task6
    {
        private string a;
        public void Task()
        {
            Console.WriteLine("Введите несколько предложений: ");
            a = Console.ReadLine();
            string t;

            //a = "сегодня хорошая погода. я пойду гулять. гулять буду в парке";

            string[] b = a.Split(".".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < b.Length; i++)
            {
                int j = 0;

                if (b[i][j] == ' ')
                    j++;
                t = b[i][j].ToString().ToUpper() + b[i].Substring(j + 1);
                Console.Write(t + ". ");
            }
            Console.WriteLine();
        }

    };

    class Program
    {
       
        static void Main(string[] args)
        {
            Console.WriteLine("задание 1 \n");
            Task1 P = new Task1();
            P.FillA();
            P.Show();
            Console.WriteLine("\n\nобщий максимальный елемент = " + (P.Max_A_B()));
            Console.WriteLine("\nобщий минимальный элемент = " + (P.Min_A_B()));
            Console.WriteLine("\nСумма всех элементов масива А и В = " + (P.Sum()));
            Console.WriteLine("\nПроизведение всех элементов масива А и В = " + (P.ProductsOfNumber()));
            Console.WriteLine("\nСумма всех четных элементов масива А = " + (P.SumOfEvenA()));
            Console.WriteLine("\nСумма всех нечетных столбцов масива В = " + (P.SumOfOddColumnsB()));


            Console.WriteLine("\nзадание 2 \n");
            Task2 R = new Task2();
            R.FillA();
            R.Show();
            Console.WriteLine("сума элементов между мах и min = " + R.Sum());



            Console.WriteLine("\nзадание 4 \n");
            Task4 S = new Task4();
            S.Fill_matrix();
            S.Show();
            Console.WriteLine("\nВведите число для умножение матрицы: ");
            int a = Int32.Parse(Console.ReadLine());
            S.MultByNumber(a);
            S.Show();
            Console.WriteLine("Результат сложения матрицы = " + S.Sum());
            Console.WriteLine("Произведение матрицы = " + S.Products());



            Console.WriteLine("\nзадание 5 \n");
            Task5 N = new Task5();
            Console.WriteLine("Результат = " + N.Result());



            Console.WriteLine("\nзадание 6 \n");
            Task6 G = new Task6();
            G.Task();

        }
    }
}
