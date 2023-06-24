


using SpiralMatrixNumber;

var matrix = SpritalMatrix.GetMatrix(2);


for (int fila = 0; fila < matrix.GetLength(0); fila++)
{
    for (int columna = 0; columna < matrix.GetLength(1); columna++)
    {
        Console.Write($"{matrix[fila, columna]} ");
    }
    Console.WriteLine();
}