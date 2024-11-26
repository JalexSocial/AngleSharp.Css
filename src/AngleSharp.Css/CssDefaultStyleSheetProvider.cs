namespace AngleSharp.Css
{
    using AngleSharp.Css.Dom;
    using AngleSharp.Css.Parser;
    using System;

    public sealed class CssDefaultStyleSheetProvider : ICssDefaultStyleSheetProvider
    {
        #region Fields

        private ICssStyleSheet _default;

        #endregion

        #region Properties

        public ICssStyleSheet Default => _default ?? (_default = Parse(DefaultSource));

        #endregion

        #region Methods

        public void SetDefault(ICssStyleSheet sheet) => _default = sheet;

        public void SetDefault(String source) => SetDefault(Parse(source));

        public void AppendDefault(String source) => SetDefault(Parse($"{DefaultSource}\r\n{source}"));

        #endregion

        #region Default Stylesheet

        private static ICssStyleSheet Parse(String source)
        {
            var parser = new CssParser();
            return parser.ParseStyleSheet(source);
        }

        /// <summary>
        /// Gets the source code for the by default used base stylesheet.
        /// Taken from https://www.w3.org/TR/CSS22/sample.html.
        /// </summary>
        public static readonly String DefaultSource = @"
html, address,
blockquote,
body, dd, div,
dl, dt, fieldset, form,
frame, frameset,
h1, h2, h3, h4,
h5, h6, noframes,
ol, p, ul, center,
dir, hr, menu, pre   { display: block; unicode-bidi: embed }
li              { display: list-item }
head            { display: none }
table           { display: table }
tr              { display: table-row }
thead           { display: table-header-group }
tbody           { display: table-row-group }
tfoot           { display: table-footer-group }
col             { display: table-column }
colgroup        { display: table-column-group }
td, th          { display: table-cell }
caption         { display: table-caption }
th              { font-weight: bolder; text-align: center }
caption         { text-align: center }
body            { margin: 8px }
h1              { font-size: 2em; margin: .67em 0 }
h2              { font-size: 1.5em; margin: .75em 0 }
h3              { font-size: 1.17em; margin: .83em 0 }
h4, p,
blockquote, ul,
fieldset, form,
ol, dl, dir,
menu            { margin: 1.12em 0 }
h5              { font-size: .83em; margin: 1.5em 0 }
h6              { font-size: .75em; margin: 1.67em 0 }
h1, h2, h3, h4,
h5, h6, b,
strong          { font-weight: bolder }
blockquote      { margin-left: 40px; margin-right: 40px }
i, cite, em,
var, address    { font-style: italic }
pre, tt, code,
kbd, samp       { font-family: monospace }
pre             { white-space: pre }
button, textarea,
input, select   { display: inline-block }
big             { font-size: 1.17em }
small, sub, sup { font-size: .83em }
sub             { vertical-align: sub }
sup             { vertical-align: super }
table           { border-spacing: 2px; }
thead, tbody,
tfoot           { vertical-align: middle }
td, th, tr      { vertical-align: inherit }
s, strike, del  { text-decoration: line-through }
hr              { border: 1px inset }
ol, ul, dir,
menu, dd        { margin-left: 40px }
ol              { list-style-type: decimal }
ol ul, ul ol,
ul ul, ol ol    { margin-top: 0; margin-bottom: 0 }
u, ins          { text-decoration: underline }
br:before       { content: '\A'; white-space: pre-line }
center          { text-align: center }
:link, :visited { text-decoration: underline }
:focus          { outline: thin dotted invert }

/* Begin bidirectionality settings (do not change) */
BDO[DIR='ltr']  { direction: ltr; unicode-bidi: bidi-override }
BDO[DIR='rtl']  { direction: rtl; unicode-bidi: bidi-override }

*[DIR='ltr']    { direction: ltr; unicode-bidi: embed }
*[DIR='rtl']    { direction: rtl; unicode-bidi: embed }

@media print {
  h1            { page-break-before: always }
  h1, h2, h3,
  h4, h5, h6    { page-break-after: avoid }
  ul, ol, dl    { page-break-before: avoid }
}";

        #endregion
    }
}
