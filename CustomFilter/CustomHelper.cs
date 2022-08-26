using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomFilter
{
    public static class CustomHelper
    {
        public static IHtmlString Image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt = '{1}'></img>", src, alt));

        }
        public static IHtmlString Img(this HtmlHelper h, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></img>", src, alt));
        }

        public static IHtmlString ImgTag(this HtmlHelper help, string src, string alt)
        {
            TagBuilder t = new TagBuilder("img");
            t.Attributes.Add("src", src);
            t.Attributes.Add("alt", alt);
            return MvcHtmlString.Create(t.ToString());
        }
    }
}











