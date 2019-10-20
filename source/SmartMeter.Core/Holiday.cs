using System;

namespace SmartMeter.Core
{
    public class Holiday : Day
    {
        private readonly string _name;

        public Holiday(DateTime date, string name, double measurement) : base(date, measurement)
        {
            _name = name;
        }

        public override string ToString()
        {
            return base.ToString() + $", {nameof(_name)}: {_name}";
        }

        public override string GetMarkdownRow() => $"{base.GetMarkdownRow()} {_name} |";

    }
}
