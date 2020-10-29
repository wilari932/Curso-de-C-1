using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Booot
{
    public static class HtmlGenrator
    {

        public static string  ToHtml(this List<Product> products)
        {
            var template = File.ReadAllText("Template.html");
            StringBuilder s = new StringBuilder();
            products.OrderBy(x => x.Price).ToList().ForEach((p) => 
            {
                s.AppendLine(string.Format("<h1>{0}</h1>", p.Name));
                s.AppendLine(string.Format("<h2>{0}</h2>", p.Price));
                s.AppendLine("<hr/>");
            });

            return template.Replace("{0}", s.ToString());

        }
    }
}
