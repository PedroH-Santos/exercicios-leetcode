public class Solution289 {
    public void GameOfLife(int[][] board) {
        int[,] next = new int[board.Length,board[0].Length];
        for (int i =0; i < board.Length; i++) {
            for(int j =0; j < board[i].Length; j++) {
                int countLived = 0;
                if (j - 1 >= 0 && board[i][j - 1] == 1) //Anterior
                {
                    countLived++;
                }

                if (j + 1 < board[i].Length && board[i][j + 1] == 1) //Posterior
                {
                    countLived++;
                }
                if (i + 1 < board.Length && board[i+1][j] == 1) //De cima
                {
                    countLived++;
                }
                if (i - 1 >= 0 && board[i-1][j] == 1) //De baixo
                {
                    countLived++;
                }
                if (i + 1 < board.Length && j - 1 >= 0 && board[i + 1][j - 1] == 1) // Diagonal esquerda inferior
                {
                    countLived++;
                }
                if (i + 1 < board.Length && j + 1 < board[i].Length && board[i + 1][j + 1] == 1) // Diagonal inferior superior
                {
                    countLived++;
                }
                if (i - 1 >= 0 && j + 1 < board[i].Length && board[i - 1][j + 1] == 1)
                {
                    countLived++;
                }
                if (i - 1 >= 0 && j - 1 >= 0 && board[i - 1][j - 1] == 1)
                {
                    countLived++;
                }
                Console.WriteLine(board[i][j] + "\t" + countLived + "\n");
                if(countLived < 2 || countLived > 3 ) {
                    next[i, j] = 0; //Morre
                }else {
                    if(board[i][j] == 1 && (countLived == 2 || countLived == 3)){
                        next[i, j] = 1; //Vive para a próxima
                    }else if(board[i][j] == 0 && countLived == 3) {
                        next[i, j] = 1; //Nasce
                    }
                }
            }
        }


        for (int i = 0; i < next.GetLength(0); i++)
        {
            for (int j = 0; j < next.GetLength(1); j++)
            {
                board[i][j] = next[i, j];
            }
        }

    }
    public int[] TwoSum(int[] nums, int target)
    {


        for (int i = 0; i < nums.Count(); i++)
        {
            int diff = target - nums[i];
            int findOther = Array.IndexOf(nums, diff);


            if(findOther!= null && i != findOther ) {
                return [i, findOther];
            }
        }
        return [0,0];
    }

    public static void Print2DArray<T>(T[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

}