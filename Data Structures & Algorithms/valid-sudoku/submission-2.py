class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        cols = {}
        rows = {}
        squares = {}

        for i in range(9):
            rows[i] = set()
            cols[i] = set()

        for i in range(3):
            for j in range(3):
                squares[(i,j)] = set()                

        for i in range(9):
            for j in range(9):
                cur = board[i][j]
                if cur == ".":
                    continue
                if cur in rows[i]:
                    return False
                if cur in cols[j]:
                    return False

                if cur in squares[(i//3,j//3)]:
                    return False
                
                rows[i].add(cur)
                cols[j].add(cur)
                squares[(i//3,j//3)].add(cur)

        return True