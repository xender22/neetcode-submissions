public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        var firstSquare = new HashSet<char>();
        var secondSquare = new HashSet<char>();
        var thirdSquare = new HashSet<char>();

        var firstCount = 0;
        var secondCount = 0;
        var thirdCount = 0;

        for (var i = 0; i < 9; i++)
        {
            var row =  new HashSet<char>
            {
                board[i][0], board[i][1], board[i][2],
                board[i][3], board[i][4], board[i][5],
                board[i][6], board[i][7], board[i][8]
            };


            var rowCount =
                (board[i][0] == '.' ? 0 : 1) +
                (board[i][1] == '.' ? 0 : 1) +
                (board[i][2] == '.' ? 0 : 1) +
                (board[i][3] == '.' ? 0 : 1) +
                (board[i][4] == '.' ? 0 : 1) +
                (board[i][5] == '.' ? 0 : 1) +
                (board[i][6] == '.' ? 0 : 1) +
                (board[i][7] == '.' ? 0 : 1) +
                (board[i][8] == '.' ? 0 : 1);

            var column = new HashSet<char>
            {
                board[0][i], board[1][i], board[2][i],
                board[3][i], board[4][i], board[5][i],
                board[6][i], board[7][i], board[8][i]
            };

            var columnCount =
                (board[0][i] == '.' ? 0 : 1) +
                (board[1][i] == '.' ? 0 : 1) +
                (board[2][i] == '.' ? 0 : 1) +
                (board[3][i] == '.' ? 0 : 1) +
                (board[4][i] == '.' ? 0 : 1) +
                (board[5][i] == '.' ? 0 : 1) +
                (board[6][i] == '.' ? 0 : 1) +
                (board[7][i] == '.' ? 0 : 1) +
                (board[8][i] == '.' ? 0 : 1);

            if (row.Count - 1 != rowCount || column.Count - 1 != columnCount)
                return false;

            firstSquare.UnionWith(new[] {board[i][0], board[i][1], board[i][2]});

            firstCount += 
                (board[i][0] == '.' ? 0 : 1) +
                (board[i][1] == '.' ? 0 : 1) +
                (board[i][2] == '.' ? 0 : 1);

            secondSquare.UnionWith(new[] {board[i][3], board[i][4], board[i][5]});

             secondCount += 
                (board[i][3] == '.' ? 0 : 1) +
                (board[i][4] == '.' ? 0 : 1) +
                (board[i][5] == '.' ? 0 : 1);

            thirdSquare.UnionWith(new[] {board[i][6], board[i][7], board[i][8]});

             thirdCount += 
                (board[i][6] == '.' ? 0 : 1) +
                (board[i][7] == '.' ? 0 : 1) +
                (board[i][8] == '.' ? 0 : 1);

            if ((i + 1) % 3 == 0)
            {
                if (firstSquare.Count - 1 != firstCount || secondSquare.Count - 1 != secondCount || thirdSquare.Count - 1 != thirdCount)
                    return false;
                
                firstSquare.Clear();
                secondSquare.Clear();
                thirdSquare.Clear();

                firstCount = 0;
                secondCount = 0;
                thirdCount = 0;
            }
        }

        return true;
    }
}
