namespace Day02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //matrix

            var matrix = Matrix.FillRandomMatrix(5, 5);
            Matrix.DisplayMatrix(matrix);

            var matrixDiag = Matrix.MatrixDiagonal(7, 7);
            Matrix.DisplayMatrix(matrixDiag);


            
            /*var numbers = Arrays.InitArrayInt(7);
            Arrays.DisplayArrayInt(numbers);

            var sum = Arrays.SumTotalArray(numbers);
            Console.WriteLine(sum);

            Console.WriteLine();

            var max = Arrays.FindMaxElement(numbers);
            Console.WriteLine(max);
            Console.WriteLine(numbers.Max());

            var indexOfMax = Arrays.FindMaxIndex(numbers);
            Console.WriteLine(indexOfMax);

            Console.WriteLine();

            var targetArr = Arrays.CopyArray(numbers);
            Arrays.DisplayArrayInt(targetArr);

            Console.WriteLine();

            var targetArr2 = Arrays.CopyArray(numbers);
            Arrays.DisplayArrayInt(targetArr2);*/


            //Arrays.IntroArray();
        }
    }
}
