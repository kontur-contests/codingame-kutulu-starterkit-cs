using System.Diagnostics;

namespace CodeOfKutulu
{
    public class Countdown
    {
        private readonly Stopwatch stopwatch;
        private readonly long timeAvailableMs;

        public Countdown(long ms)
        {
            stopwatch = Stopwatch.StartNew();
            timeAvailableMs = ms;
        }

        public bool IsFinished => TimeLeftMs <= 0;

        public long TimeLeftMs => timeAvailableMs - stopwatch.ElapsedMilliseconds;
        public long ElapsedMs => stopwatch.ElapsedMilliseconds;

        public override string ToString() => $"Elapsed {ElapsedMs} ms. Available {timeAvailableMs} ms";

        public static implicit operator Countdown(int milliseconds) => new Countdown(milliseconds);

        public static implicit operator Countdown(long milliseconds) => new Countdown(milliseconds);
    }
}