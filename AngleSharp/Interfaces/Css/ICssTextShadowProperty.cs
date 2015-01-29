﻿namespace AngleSharp.Dom.Css
{
    using AngleSharp.Css.Values;
    using System.Collections.Generic;

    /// <summary>
    /// Represents the CSS text-shadow property.
    /// </summary>
    public interface ICssTextShadowProperty : ICssProperty
    {
        /// <summary>
        /// Gets an enumeration over all the set shadows.
        /// </summary>
        IEnumerable<Shadow> Shadows { get; }
    }
}
