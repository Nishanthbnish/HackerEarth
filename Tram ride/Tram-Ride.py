def solve(N, start, finish, ticketCost):
    totalCost = 0
    
    if start == finish:
        return totalCost
    
    if start > finish:
        start, finish = finish, start
    
    for i in range(start, finish):
        totalCost += ticketCost[i]
    
    reverseCost = 0
    for i in range(finish - 1, start - 1, -1):
        reverseCost += ticketCost[i]
    
    return min(totalCost, reverseCost)
    
N = 4
start = 1
finish = 4
ticketCost = [1, 2, 2, 4]

minCost = solve(N, start - 1, finish - 1, ticketCost)

print(minCost) # Output: 4
