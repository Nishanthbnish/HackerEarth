import java.util.*;

public class TramRide {
    public static int solve(int N, int start, int finish, int[] ticketCost) {
        int totalCost = 0;

        if (start == finish) {
            return totalCost;
        }

        if (start > finish) {
            int temp = start;
            start = finish;
            finish = temp;
        }

        for (int i = start; i < finish; i++) {
            totalCost += ticketCost[i];
        }

        int reverseCost = 0;
        for (int i = finish - 1; i >= start; i--) {
            reverseCost += ticketCost[i];
        }

        return Math.min(totalCost, reverseCost);
    }

    public static void main(String[] args) {
        int N = 4;
        int start = 1;
        int finish = 4;
        int[] ticketCost = {1, 2, 2, 4};

        int minCost = solve(N, start - 1, finish - 1, ticketCost);

        System.out.println(minCost); // Output: 4
    }
}
