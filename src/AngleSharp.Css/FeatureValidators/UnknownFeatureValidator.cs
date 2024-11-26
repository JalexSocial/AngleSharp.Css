namespace AngleSharp.Css.FeatureValidators
{
    using AngleSharp.Css.Dom;
    using System;

    public sealed class UnknownFeatureValidator : IFeatureValidator
    {
        public Boolean Validate(IMediaFeature feature, IRenderDevice renderDevice)
        {
            return true;
        }
    }
}
