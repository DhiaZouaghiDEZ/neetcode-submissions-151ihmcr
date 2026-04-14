public class Solution {
    public bool IsValidSudoku(char[][] board) {
        for(int i=0; i<9;i++){
            var rowList = new List<char>();
            var colList = new List<char>();
            for(int j=0; j<9;j++){
                rowList.Add(board[i][j]);
                colList.Add(board[j][i]);
            }
            var filteredRowList = rowList.Where(c => c != '.').ToList();
            var filteredColList = colList.Where(c => c != '.').ToList();
            if(filteredRowList.Distinct().Count() != filteredRowList.Count() || filteredColList.Distinct().Count() != filteredColList.Count()){
                    return false;
                }
        }
        for(int boxRow = 0; boxRow < 9; boxRow += 3){
            for(int boxCol = 0; boxCol < 9; boxCol += 3){
                var boxList = new List<char>();
        
                for(int i = 0; i < 3; i++){
                    for(int j = 0; j < 3; j++){
                        boxList.Add(board[boxRow + i][boxCol + j]);
                    }
                }
        
                var filtered = boxList.Where(c => c != '.').ToList();
                if(filtered.Distinct().Count() != filtered.Count()) return false;
            }   
        }
        return true;
    }
}
