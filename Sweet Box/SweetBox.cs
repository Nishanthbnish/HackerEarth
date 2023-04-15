using System;

class Solution {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int[] sweets = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine(Solve(N, sweets, K));
    }

    static int Solve(int N, int[] sweets, int K) {
        int count = 0;
        for (int i = 0; i < N; i++) {
            if (sweets[i] == 0) {
                // Check if both adjacent slots are empty or not
                if ((i == 0 || sweets[i - 1] == 0) && (i == N - 1 || sweets[i + 1] == 0)) {
                    sweets[i] = 1;
                    count++;
                }
            }
            if (count == K) {
                return 1;
            }
        }
        return 0;
    }
}
