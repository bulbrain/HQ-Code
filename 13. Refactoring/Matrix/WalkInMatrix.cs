namespace Matrix 
{
    using System;
    class WalkInMatrica 
    {
        static void changeDirection(ref int xDirection,ref int yDirection) 
        {
            int[] xDirections = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] yDirections = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int changeCount = 0;

            for (int count = 0; count < 8; count++)
            {
                if (xDirections[count] == xDirection && yDirections[count] == yDirection) 
                {
                    changeCount = count; 
                    break; 
                }

                if (changeCount == 7) 
                { 
                    xDirection = xDirections[0]; 
                    yDirection = yDirections[0]; 
                    return; 
                }

                xDirection = xDirections[changeCount + 1];
                yDirection = yDirections[changeCount + 1];
            }
        }
        static bool checkNextCell( int[,] matrix, int x, int y )
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };

            for(int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= matrix.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                } 

				
				if(y + dirY[i] >= matrix.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for(int i = 0; i < 8; i++)
            {
                if (matrix[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void findNextCell (int[,] matrix, out int x, out int y)
        {
            x = 0;
            y = 0;
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[i, j] == 0) 
                    {
                        x = i; y = j; 
                        return; 
                    }
                }
            }
        }

        static void Main( string[] args )
        {
            Console.WriteLine( "Enter a positive number");
            string input = Console.ReadLine();
            int n = 0;

            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            int matrixSquare = 1;
            int horizontalDirection = 1;
            int diagonalDirection = 1;

            SetupMatrix(matrix, row, col, matrixSquare, horizontalDirection, diagonalDirection, n);

            findNextCell(matrix, out row, out col);

            if (row != 0 && col != 0)
            {
                horizontalDirection = 1;
                diagonalDirection = 1;

                SetupMatrix(matrix, row, col, matrixSquare, horizontalDirection, diagonalDirection, n);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,3}", matrix[i, j]);
                }

                Console.WriteLine();
            }
        }
        private static void SetupMatrix(int[,] matrix, int row, int col, int matrixSquare, int horizontalDirection,
            int diagonalDirection, int n)
        {
            while (true)
            {
                matrix[row, col] = matrixSquare;

                if (!checkNextCell(matrix, row, col))
                {
                    break;
                }
                if (row + horizontalDirection >= n || row + horizontalDirection < 0 || col + diagonalDirection >= n ||
                    col + diagonalDirection < 0 || matrix[row + horizontalDirection, col + diagonalDirection] != 0)
                {
                    while ((row + horizontalDirection >= n || row + horizontalDirection < 0 || col + diagonalDirection >= n ||
                        col + diagonalDirection < 0 || matrix[row + horizontalDirection, col + diagonalDirection] != 0))
                    {
                        changeDirection(ref horizontalDirection, ref diagonalDirection);
                    }
                }

                row += horizontalDirection;
                col += diagonalDirection;
                matrixSquare++;
            }
        }
    }
}
