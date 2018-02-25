using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
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
            string thisproxy = "";
            string PROXY = "";


            //Code copied from the above linkss
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxDriver driver0, driver2, driver1, driver3;
            OpenQA.Selenium.Proxy proxy = new OpenQA.Selenium.Proxy();


            while (true)
            {

                Thread.Sleep(60 * proxytime * 1000);
                {
                    PROXY = allproxy[rnd1.Next(allproxy.Length)];
                    proxy.HttpProxy = PROXY;
                    proxy.FtpProxy = PROXY;
                    proxy.SslProxy = PROXY;
                    profile.SetProxyPreferences(proxy);

                    driver0 = new FirefoxDriver(profile);
                    driver2 = new FirefoxDriver(profile);
                    driver1 = new FirefoxDriver(profile);
                    driver3 = new FirefoxDriver(profile);

                    thisPage = allweb[rnd1.Next(allweb.Length)];
                    driver0.Navigate().GoToUrl(thisPage);
                    driver0.Close();


                    Thread.Sleep(1000);
                    {
                        thisCate = allCate[rnd1.Next(allCate.Length)];
                        driver1.Navigate().GoToUrl(thisCate);
                        driver1.Close();
                    }
                    Thread.Sleep(2000);
                    {
                        thisCate = allCate[rnd1.Next(allCate.Length)];
                        driver2.Navigate().GoToUrl(thisCate);
                        driver2.Close();
                    }
                    Thread.Sleep(4000);
                    {
                        thisCate = allCate[rnd1.Next(allCate.Length)];
                        driver3.Navigate().GoToUrl(thisCate);
                        driver3.Close();
                    }



                };
            }

        }

    }
}
