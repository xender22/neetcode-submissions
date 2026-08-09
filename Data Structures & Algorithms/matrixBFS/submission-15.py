class Solution:
    def shortestPath(self, grid: List[List[int]]) -> int:
        ROWS, COLS = len(grid), len(grid[0])

        if grid[0][0] == 1 or grid[ROWS - 1][COLS - 1] == 1:
            return -1
        

        queue = deque()
        visited = set()
        queue.append((0, 0))
        visited.add((0, 0))
        length = 0
        neighbours = [(0, 1), (0, -1), (1, 0), (-1, 0)]

        while queue:
            for i in range(len(queue)):
                curr = queue.popleft()
                if curr[0] == ROWS -1 and curr[1] == COLS - 1:
                    return length

                for r, c in neighbours:
                    nr = curr[0] + r
                    nc = curr[1] + c

                    if min(nr, nc) < 0 or nr == ROWS or nc == COLS or grid[nr][nc] == 1 or (nr, nc) in visited:
                        continue
                    
                    queue.append((nr, nc))
                    visited.add((nr, nc))
            
            length += 1
        
        return -1