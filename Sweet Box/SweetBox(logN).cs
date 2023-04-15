using System;

class Solution {
    static void Main(string[] args) {
        int N = int.Parse(Console.ReadLine());
        int[] sweets = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine(Solve(N, sweets, K));
    }

    static int Solve(int N, int[] sweets, int K) {
        int left = 0;
        int right = N - K;
        while (left <= right) {
            int mid = (left + right) / 2;
            if (CanPlace(mid, sweets, K)) {
                return 1;
            }
            else if (sweets[mid] == 1) {
                right = mid - 1;
            }
            else {
                left = mid + 1;
            }
        }
        return 0;
    }

    static bool CanPlace(int index, int[] sweets, int K) {
        int count = 0;
        for (int i = index; i < index + K && i < sweets.Length; i++) {
            if (sweets[i] == 1) {
                return false;
            }
            count++;
        }
        if (index > 0 && sweets[index - 1] == 1) {
            return false;
        }
        if (index + K < sweets.Length && sweets[index + K] == 1) {
            return false;
        }
        return count == K;
    }
}
