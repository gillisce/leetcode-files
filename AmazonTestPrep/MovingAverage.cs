namespace  leetcode.AmazonTestPrep
{
    public class MovingAverage{
        private int [] window;
        private int count, insert;
        private long sum;

        /** Initialize your data structure here. */
        public MovingAverage(int size) {
            window = new int[size];
            insert = 0;
            sum = 0;
        }

        public double Next(int val) {
            if (count < window.Length)  count++;
            sum -= window[insert];
            sum += val;
            window[insert] = val;
            insert = (insert + 1) % window.Length;
            // Console.WriteLine($@"Whats the deal {insert}");

            return (double)sum / count;
        }
    }
}
