using System;
using System.IO;
using System.Collections.Generic;


namespace Task_5
{
    class Program
    {


        public static void TransformArray(List<int> x)
        {
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i] % 2 != 0)
                {
                    x[i] /= 3;
                }
            }

            Print(x, "new x");
        }


        public static void FormArray(List<int> x, List<int> y, ref List<int> z)
        {

            TransformArray(x);


            for (int i = 0; i < x.Count; i++)
            {
                z.Add(x[i] + y[y.Count - 1 - i]);

            }

            Print(z, "z");

        }


        public static void Print(List<int> a, string s)
        {
            Console.WriteLine(s+":");
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
        }


        public static void Read(ref List<int> a, string s)
        {
            using (StreamReader sr = new StreamReader($@"..\..\..\{s}.txt", System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (line.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length > 1)
                    {
                        foreach (string i in line.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                        {
                            a.Add(Convert.ToInt32(i));
                        }
                    }
                    else
                    {
                        a.Add(Convert.ToInt32(line));
                    }
                }
            }
        }



        static void Main(string[] args)
        {

            // 5 Варіант

            List<int> x = new List<int>();
            List<int> y = new List<int>();
            List<int> z = new List<int>();

            try
            {

                Read(ref x, "x");
                Print(x, "x");

                Read(ref y, "y");
                Print(y, "y");

                FormArray(x, y, ref z);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
