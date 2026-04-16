using System;
using System.Threading;

namespace ism7mqtt.ISM7
{
    /*
    Helper class to generate thread-safe ids.
    */
    public static class IdGenerator
    {
        private static int _nextBundleId = 0;
        private static int _nextSequenceId = 1;

        public static int GetNextBundleId(string source) {
            var newId = Interlocked.Increment(ref _nextBundleId);
            Console.WriteLine($"Generated new bundle id: {newId} for source: {source}");

            return newId;
        }

        public static int GetNextSequenceId() => Interlocked.Increment(ref _nextSequenceId);
    }
}