﻿namespace AngleSharp.Css.Dom
{
    using AngleSharp.Css;
    using AngleSharp.Css.Converters;
    using static ValueConverters;

    /// <summary>
    /// More information available at:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/column-span
    /// Gets if the element should span across all columns.
    /// </summary>
    sealed class CssColumnSpanProperty : CssProperty
    {
        #region Fields

        private static readonly IValueConverter StyleConverter = Or(ColumnSpanConverter, AssignInitial(false));

        #endregion

        #region ctor

        internal CssColumnSpanProperty()
            : base(PropertyNames.ColumnSpan)
        {
        }

        #endregion

        #region Properties

        internal override IValueConverter Converter
        {
            get { return StyleConverter; }
        }

        #endregion
    }
}
