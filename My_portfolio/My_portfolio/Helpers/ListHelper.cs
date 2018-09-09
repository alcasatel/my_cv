using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;
using System.Collections.Generic;

namespace Metanit.Helpers
{
    public static class ListHelper
    {
        public static MvcHtmlString CreateList(this HtmlHelper html, string[] items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach(string item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item);
                ul.InnerHtml += li.ToString();
            }

            return new MvcHtmlString(ul.ToString());
        }

       /* public static MvcHtmlString CreateList(this HtmlHelper html, IEnumerable<Metanit.Models.Book> items)
        {
            TagBuilder ul = new TagBuilder("ul");
            foreach (Metanit.Models.Book item in items)
            {
                TagBuilder li = new TagBuilder("li");
                li.SetInnerText(item.Name);
                ul.InnerHtml += li.ToString();
            }

            return new MvcHtmlString(ul.ToString());
        }*/
    }
}