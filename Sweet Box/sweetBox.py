def solve(N, sweets, K):
    count = 0
    for i in range(N):
        if sweets[i] == 0:
            # Check if both adjacent slots are empty or not
            if (i == 0 or sweets[i - 1] == 0) and (i == N - 1 or sweets[i + 1] == 0):
                sweets[i] = 1
                count += 1
        if count == K:
            return 1
    return 0

N = int(input())
sweets = list(map(int, input().split()))
K = int(input())

print(solve(N, sweets, K))
