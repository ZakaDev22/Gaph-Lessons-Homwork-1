using System;
using System.Collections.Generic;

namespace Homework_1__Graph_Representation_and_Conversion
{
    public class MatrixAndListSolutions
    {
        public class GraphAdjacencylist
        {
            public List<int> Connections = new List<int>();

            public GraphAdjacencylist(int[] connections)
            {
                Connections.Add(connections[0]);
                Connections.Add(connections[1]);
                Connections.Add(connections[2]);
                Connections.Add(connections[3]);
                Connections.Add(connections[4]);
            }


        }

        public static void MatrixSolution()
        {
            string[] Names = { "A", "B", "C", "D", "E" };

            int[,] Matrix =
            {
                {0,1,1,0,0 },
                {0,0,0,1, 0},
                {0,0,0,1 ,0},
                {0,0,0,0,1 },
                {0,0,0,0,0}
            };

            Console.WriteLine();

            Console.WriteLine("\t" + string.Join("\t", Names));

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Console.Write($"{Names[i]}\t");

                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

        }

        public static void ListSolution()
        {
            List<GraphAdjacencylist> List = new List<GraphAdjacencylist>();

            GraphAdjacencylist A = new GraphAdjacencylist(new int[] { 0, 1, 1, 0, 0 });

            GraphAdjacencylist B = new GraphAdjacencylist(new int[] { 0, 0, 0, 1, 0 });

            GraphAdjacencylist C = new GraphAdjacencylist(new int[] { 0, 0, 0, 1, 0 });

            GraphAdjacencylist D = new GraphAdjacencylist(new int[] { 0, 0, 0, 0, 1 });

            GraphAdjacencylist E = new GraphAdjacencylist(new int[] { 0, 0, 0, 0, 0 });

            List.Add(A);
            List.Add(B);
            List.Add(C);
            List.Add(D);
            List.Add(E);

            string[] Names = { "A", "B", "C", "D", "E" };

            Console.WriteLine();

            Console.WriteLine("\t\t\t\t " + string.Join("     ", Names));

            int index = 0;
            foreach (var item in List)
            {
                Console.Write($"\n List Of Connections Of {Names[index]} : ");
                foreach (var conn in item.Connections)
                {
                    Console.Write($" --> {conn}");
                }

                index++;
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\n \t Matrix Solution :");
            MatrixSolution();

            Console.WriteLine("\n\n \t List Solution :");
            ListSolution();


            Console.ReadKey();
        }
    }
}