using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Booot
{
    class Program
    {
        // base de datos 
        public static List<Product> Products = new List<Product>();

        static void Main(string[] args)
        {

          
            var path = Environment.CurrentDirectory;
            IWebDriver webdriver = new ChromeDriver(path);
            webdriver.Url = "https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1313&_nkw=celular&_sacat=0";


            webdriver.Navigate();


           
           
                webdriver.FindElements(By.CssSelector(".pagination__item"))
                .ToList().ForEach((j) => {

                    Actions actions = new Actions(webdriver);
                    actions.Click(j).Perform();
                    var elements = webdriver.FindElements(By.CssSelector(".s-item__info")).ToList();
                    elements.ForEach((x) => {
                        var title = x.FindElement(By.CssSelector(".s-item__title")).Text;
                        var price = x.FindElement(By.CssSelector(".s-item__price")).Text;
                        Products.Add(new Product { Price = price, Name = title });

                    });

                });
            var html = Products.ToHtml();
            File.WriteAllText("productos.html", html);
            Console.WriteLine("Ready");
            webdriver.Quit();
            webdriver.Dispose();
        }
    }
}
