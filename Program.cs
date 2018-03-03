using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Security.Policy;
using System.Threading;

namespace AutoBrowseWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            int proxytime = Properties.Settings.Default.proxytime;
            int times = Properties.Settings.Default.times;

            string web = Properties.Settings.Default.page;
            string cate = Properties.Settings.Default.cate;
            string proxies = Properties.Settings.Default.proxies;
            string[] allweb = File.ReadAllLines(web);
            string[] allCate = File.ReadAllLines(cate);
            string[] allproxy = File.ReadAllLines(proxies);

            Random rnd1 = new Random();

            string thisPage = "";
            string thisCate = "";
            string PROXY = "";


            //Code copied from the above linkss
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxDriver driver, driver0, driver2, driver1, driver3;

            OpenQA.Selenium.Proxy proxy = new OpenQA.Selenium.Proxy();

            FirefoxBinary binary = new FirefoxBinary("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe");
             
            TimeSpan timespan = new TimeSpan();
            timespan = TimeSpan.FromMinutes(3);

            while (true)
            {

                Thread.Sleep(60 * proxytime * 1000);
                {
                    PROXY = allproxy[rnd1.Next(allproxy.Length)];
                    proxy.HttpProxy = PROXY;
                    proxy.FtpProxy = PROXY;
                    proxy.SslProxy = PROXY;
                    profile.SetProxyPreferences(proxy);

                    //each proxy browe 3 categories and 2 webpages
                      // look at a category 
                    {
                        thisCate = allCate[rnd1.Next(allCate.Length)];
                        driver1 = new FirefoxDriver( profile);   
                        driver1.Manage().Window.Size = new Size(300, 200);
                        driver1.Navigate().GoToUrl(thisPage);  //   如果要扫目录就改成 thisCate
                        driver1.Close();
                    }

                    Thread.Sleep(1000*Properties.Settings.Default.Iterval1); // then look at a page
                    {
                        thisPage = allweb[rnd1.Next(allweb.Length)];
                        driver = new FirefoxDriver( profile);
                        driver.Manage().Window.Size = new Size(300, 200);
                        driver.Navigate().GoToUrl(thisPage); //   如果要扫目录就改成 thisCate
                        driver.Close();
                    }
                    Thread.Sleep(1000 * Properties.Settings.Default.Iterval2); // and then back to a category
                    {
                        thisCate = allCate[rnd1.Next(allCate.Length)];
                        driver2 = new FirefoxDriver(profile);
                        driver2.Manage().Window.Size = new Size(300, 200);
                        driver2.Navigate().GoToUrl(thisPage);//   如果要扫目录就改成 thisCate
                        driver2.Close();
                    }
                    Thread.Sleep(1000 * Properties.Settings.Default.Iterval3);// and then back to a category again 
                    {
                        thisCate = allCate[rnd1.Next(allCate.Length)];
                        driver3 = new FirefoxDriver( profile);
                        driver3.Manage().Window.Size = new Size(300, 200);
                        driver3.Navigate().GoToUrl(thisPage);//   如果要扫目录就改成 thisCate
                        driver3.Close();
                    }

                    Thread.Sleep(1000 * Properties.Settings.Default.Iterval4); // finally look at one more page
                    {
                        thisPage = allweb[rnd1.Next(allweb.Length)];
                        driver0 = new FirefoxDriver(profile);
                        driver0.Manage().Window.Size = new Size(300, 200);
                        driver0.Navigate().GoToUrl(thisPage);//   如果要扫目录就改成 thisCate
                        driver0.Close();
                    }


                };
            }

        }

    }
}
