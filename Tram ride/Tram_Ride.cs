using System;

public class TramRide {
    public static int Solve(int N, int start, int finish, int[] ticketCost) {
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

        return Math.Min(totalCost, reverseCost);
    }

    public static void Main() {
        int N = 4;
        int start = 1;
        int finish = 4;
        int[] ticketCost = {1, 2, 2, 4};

        int minCost = Solve(N, start - 1, finish - 1, ticketCost);

        Console.WriteLine(minCost); // Output: 4
    }
}


//using System;
// public class TramRide {
//     public static int Solve(int N, int start, int finish, int[] ticketCost) {
//         int totalCost = 0;

//         if (start == finish) {
//             return totalCost;
//         }

//         if (start > finish) {
//             int temp = start;
//             start = finish;
//             finish = temp;
//         }

//         // Calculate the cost to travel in the clockwise direction
//         for (int i = start; i < finish; i++) {
//             totalCost += ticketCost[i];
//         }

//         // Calculate the cost to travel in the anti-clockwise direction
//         int reverseCost = 0;
//         int j = finish - 1;
//         for (int i = start; i < finish; i++) {
//             reverseCost += ticketCost[j];
//             j--;
//             if (j < 0) {
//                 j = N - 1;
//             }
//         }

//         return Math.Min(totalCost, reverseCost);
//     }

//     public static void Main() {
//         int N = 4;
//         int start = 1;
//         int finish = 4;
//         int[] ticketCost = {1, 2, 2, 4};

//         int minCost = Solve(N, start - 1, finish - 1, ticketCost);

//         Console.WriteLine(minCost); // Output: 4
//     }
// }
