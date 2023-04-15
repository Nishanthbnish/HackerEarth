import java.util.*;

class Solution {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int N = sc.nextInt();
        int[] sweets = new int[N];
        for (int i = 0; i < N; i++) {
            sweets[i] = sc.nextInt();
        }
        int K = sc.nextInt();
        System.out.println(Solve(N, sweets, K));
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
