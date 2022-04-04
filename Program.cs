using System;

namespace MultiplicationTable
{
    class MultiplicationTable
    {
        public static int[,] Table = new int[10, 10];

        public static void GenerateMultiplationTable()
        {
            for (int colNum = 0; colNum < 10; ++colNum)
            {
                for (int rowNum = 0; rowNum < 10; ++rowNum)
                {
                    Table[colNum, rowNum] = (colNum + 1) * (rowNum + 1);
                }
            }
        }

        public static void PrintTable()
        {
            if (Table == null)
            {
                MultiplicationTable.GenerateMultiplationTable();
            }

            string[] rows = new string[10];

            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 10; ++j)
                {
                    string comma = (i == 9 && j == 9) ? "" : ", ";
                    string extraSpace = (Table[j, i] < 10) ? " " : "";
                    rows[i] += extraSpace + Table[i, j] + comma;
                }
                Console.WriteLine(rows[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MultiplicationTable.GenerateMultiplationTable();
            MultiplicationTable.PrintTable();
        }
    }
}
