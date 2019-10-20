using System;

namespace SmartMeter.Core
{
    public class Day : IComparable<Day>
    {
        private readonly DateTime _date;
        private readonly double _sumOfMeasurements;

        public Day(DateTime date, double measurement)
        {
            _date = date;
            _sumOfMeasurements = measurement;
        }

        public override string ToString()
        {
            return $"{nameof(_date)}: {_date.ToShortDateString()}, {nameof(_sumOfMeasurements)}: {_sumOfMeasurements}";
        }

        public int CompareTo(Day other)
        {
            if(other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return _date.CompareTo(other._date);
        }

        public virtual string GetMarkdownRow() => $"| {_date.ToShortDateString()} | {_sumOfMeasurements:#.000} | ";
    }
}
