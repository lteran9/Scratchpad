using System;

namespace DataStructures.UseCases.Arrays
{
    public class MergeAndSortIntervals : IUseCase<List<int[]>>
    {
        private readonly int _startTimeIndex = 0;
        private readonly int _endTimeIndex = 1;
        private readonly List<int[]> _timeIntervals;

        public MergeAndSortIntervals(List<int[]> timeIntervals)
        {
            _timeIntervals = timeIntervals ?? throw new ArgumentException("You must supply a time interval list.");
        }

        public List<int[]> Execute()
        {
            var result = new List<int[]>();

            if (_timeIntervals?.Count > 0)
            {
                for (int i = 0; i < _timeIntervals.Count; i++)
                {
                    var interval = _timeIntervals[i];
                    int startTime = interval[_startTimeIndex];
                    int endTime = interval[_endTimeIndex];

                    if (i < _timeIntervals.Count - 1)
                    {
                        var nextInterval = _timeIntervals[i + 1];
                        var nextStartTime = nextInterval[_startTimeIndex];
                        var nextEndTime = nextInterval[_endTimeIndex];

                        if (endTime > nextStartTime)
                        {
                            // intervals overlap
                            result.Add(new int[] { startTime, nextEndTime });
                            i++;
                        }
                        else
                        {
                            result.Add(interval);
                        }
                    }
                    else
                    {
                        result.Add(interval);
                    }
                }
            }

            return result;
        }
    }
}