using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
namespace TestProject5
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
                IWebDriver driver;

                //new tab in chrome
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                // enter the url
                driver.Url = "https://login.microsoftonline.com/6274e003-d180-4b9c-89e7-37f13d70e0cb/oauth2/authorize?client_id=00000007-0000-0000-c000-000000000000&response_mode=form_post&response_type=code+id_token&scope=openid+profile&state=OpenIdConnect.AuthenticationProperties%3dMAAAAE_DLGfxXBHsgSL1YupdJi6d7_U2bpao3ZRkhiVPK-_yWQOj8JKfZgq41ay2LCUj2AEAAAABAAAACS5yZWRpcmVjdCZodHRwczovL29yZzk0OGEwYmIwLmNybTguZHluYW1pY3MuY29tLw%26RedirectTo%3dMAAAAE%252fDLGfxXBHsgSL1YupdJi6mJFtFn1fFSaVKO0x7WjVQ2l05xTxkDVRHvAV%252bd9rMDmh0dHBzOi8vb3JnOTQ4YTBiYjAuY3JtOC5keW5hbWljcy5jb20v%26RedirectToForMcas%3dhttps%253a%252f%252forg948a0bb0.crm8.dynamics.com%252f&nonce=637939936183573148.YTFmZmMxYTktMjQwOC00MDhmLTk4ZmQtZmQxMWVkYjFjYmIwNzU3Y2RjMGUtNjNiYS00NTc2LWFhYWUtNDhlNjg3ZTc1M2Qx&redirect_uri=https%3a%2f%2fpnq--indcrmlivesg609.crm8.dynamics.com%2f&max_age=86400&sso_reload=true";
                // Enter the user name and click on next button
                IWebElement emailTextField = driver.FindElement(By.XPath("//*[@id='i0116']"));
                IWebElement NextButton = driver.FindElement(By.XPath(".//*[@id='idSIButton9']"));

                emailTextField.SendKeys("markcsr00@gmail.com");
                NextButton.Click();
                // Enter the password and click on submit button and said yes
                Thread.Sleep(2000);
                IWebElement passwordTextField = driver.FindElement(By.XPath("//*[@id='i0118']"));
                passwordTextField.SendKeys("rathod10@");
                IWebElement SubmitButton = driver.FindElement(By.XPath("//*[@id='idSIButton9']"));
                SubmitButton.Click();
                IWebElement YesButton = driver.FindElement(By.XPath("//*[@id='idSIButton9']"));
                YesButton.Click();
                // Navigate On Accounts page
                Thread.Sleep(2000);
                driver.Navigate().GoToUrl("https://org948a0bb0.crm8.dynamics.com/main.aspx?appid=e0a831b4-e205-ed11-82e6-000d3af06f91&pagetype=entitylist&etn=account&viewid=00000000-0000-0000-00aa-000010001001&viewType=1039");
                Thread.Sleep(20000);
                //////////////////////







                string[] a = { "'Show Chart'", "'New'", "'Delete'", "'Export to Excel'", "'Open Dashboards'", "'Import from Excel'", "'Create view'" };
                for (int i = 0; i < 7; i++)
                {

                    var path = "//*[@data-id='CommandBar']//*[@role='presentation']//*[@aria-label=" + a[i] + "]";

                    if (driver.FindElement(By.XPath(path)) != null)
                    {
                        Console.WriteLine("Exist");
                    }


                    //string[] a = { "'New'", "'Delete'", "'Export to Excel'", "'Open Dashboards'", "'Import from Excel'", "'Create view'", "'Hide Chart'" };

                    //for (int i = 0; i < a.Length; i++)
                    //{
                    //    Assert.AreNotEqual("'Hide Chart'", a[i], "This button should me 'Show Chart' button");
                    //    var path = "//*[@data-id='CommandBar']//*[@role='presentation']//*[@aria-label=" + a[i] + "]";

                    //    //#ShowChartPane-button

                    //    if (driver.FindElement(By.XPath(path)) != null)
                    //    {
                    //        Console.WriteLine(a[i] + " Exist");
                    //    }


                    //}    
                }
                driver.Quit();

            }
        }
    }
