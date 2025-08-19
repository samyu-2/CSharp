import java.util.*;

public class Main {
    public static void main(String[] args) {
        HashMap<Integer, Integer> lader = new HashMap<>();
        lader.put(2,30);
        HashMap<Integer, Integer> snake = new HashMap<>();

        int curr_step = 1;
        int steps = 0;

        while (curr_step < 30) {
            int max = curr_step;
            int max2 = curr_step;

            for (int i = 1; i <= 6; i++) {
                int next = curr_step + i;
                if (next > 30) continue;

                if (lader.containsKey(next)) {
                    max = Math.max(max, lader.get(next));
                } else if (!snake.containsKey(next)) {
                    max2 = next;
                }
            }

            curr_step = Math.max(max, max2);
            steps++;
        }

        System.out.println("Reached 30 in " + steps + " moves.");
    }
}
