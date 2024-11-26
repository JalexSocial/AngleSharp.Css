namespace AngleSharp.Css.Parser
{
    using System;

    public sealed class Unit
    {
        public Unit(String value, String dimension)
        {
            Value = value;
            Dimension = dimension;
        }

        public String Value
        {
            get;
        }

        public String Dimension
        {
            get;
        }
    }
}
