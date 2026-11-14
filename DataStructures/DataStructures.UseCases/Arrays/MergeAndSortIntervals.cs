using System;

namespace DataStructures.UseCases.Arrays
{
    /// <summary>
    /// Sorts time intervals by start and combines all overlapping or touching ranges.
    /// </summary>
    /// <remarks>
    /// <para>
    /// An interval is an integer array whose first two elements represent its start and end.
    /// For example, [1, 3] represents a time range starting at 1 and ending at 3.
    /// Combining overlapping ranges can help summarize periods of activity, such as scheduled meetings.
    /// </para>
    /// <para>
    /// Input intervals may be supplied in any order. After sorting by start, each interval is
    /// merged into the current range if its start is less than or equal to the current end.
    /// The merged range keeps the larger end, so nested intervals cannot shorten it.
    /// This also merges chains of overlapping intervals and intervals that share an endpoint.
    /// </para>
    /// <para>
    /// Each interval must contain at least two integers with start less than or equal to end.
    /// Additional elements are ignored. The result contains independent two-element arrays
    /// sorted by start, with no overlapping or touching ranges.
    /// </para>
    /// <para>
    /// For example, [8, 10], [2, 6], [1, 3], [6, 8] produces [1, 10].
    /// The input list and its arrays are not modified.
    /// </para>
    /// </remarks>
    public class MergeAndSortIntervals : IUseCase<List<int[]>>
    {
        private readonly int _startTimeIndex = 0;
        private readonly int _endTimeIndex = 1;
        private readonly List<int[]> _timeIntervals;

        /// <summary>
        /// Creates a use case for sorting and merging the supplied interval list.
        /// </summary>
        /// <param name="timeIntervals">
        /// The intervals in any order. Each entry must be non-null and contain at least
        /// two integers: the start at index 0 and the end at index 1, with start less than or equal to end.
        /// The list is retained by reference, not copied, and its entries are validated when executed.
        /// </param>
        /// <exception cref="ArgumentException">
        /// <paramref name="timeIntervals"/> is <see langword="null"/>.
        /// </exception>
        public MergeAndSortIntervals(List<int[]> timeIntervals)
        {
            _timeIntervals = timeIntervals ?? throw new ArgumentException("You must supply a time interval list.");
        }

        /// <summary>
        /// Sorts intervals by start and merges overlapping or touching ranges, including nested ranges and chains.
        /// </summary>
        /// <returns>
        /// A new list sorted by start, containing independent two-element arrays for the merged ranges.
        /// An empty input produces an empty list.
        /// </returns>
        /// <remarks>
        /// The input list and arrays are not modified or shared with the result.
        /// Processing takes O(n log n) time and O(n) additional space for n input intervals.
        /// </remarks>
        /// <exception cref="ArgumentException">
        /// An interval is null, contains fewer than two integers, or has a start greater than its end.
        /// </exception>
        public List<int[]> Execute()
        {
            for (int i = 0; i < _timeIntervals.Count; i++)
            {
                var interval = _timeIntervals[i];
                if (interval is null || interval.Length < 2 || interval[_startTimeIndex] > interval[_endTimeIndex])
                {
                    throw new ArgumentException($"Interval at index {i} must contain a start and end with start less than or equal to end.");
                }
            }

            var sortedIntervals = _timeIntervals.OrderBy(interval => interval[_startTimeIndex]);
            var result = new List<int[]>();

            foreach (var interval in sortedIntervals)
            {
                if (result.Count == 0 || interval[_startTimeIndex] > result[result.Count - 1][_endTimeIndex])
                {
                    result.Add(new int[] { interval[_startTimeIndex], interval[_endTimeIndex] });
                }
                else
                {
                    result[result.Count - 1][_endTimeIndex] = Math.Max(result[result.Count - 1][_endTimeIndex], interval[_endTimeIndex]);
                }
            }

            return result;
        }
    }
}