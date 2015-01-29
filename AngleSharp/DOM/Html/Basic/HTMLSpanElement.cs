﻿namespace AngleSharp.Dom.Html
{
    using AngleSharp.Html;

    /// <summary>
    /// Represents the HTML span element.
    /// </summary>
    sealed class HTMLSpanElement : HTMLElement, IHtmlSpanElement
    {
        #region ctor

        public HTMLSpanElement(Document owner)
            : base(owner, Tags.Span)
        {
            Owner = owner;
        }

        #endregion
    }
}
