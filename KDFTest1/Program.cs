﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KDFTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ILoadData loadCSV = new LoadCSV();
            IWebDriver driver = new ChromeDriver(); // create a new instance of ChromeDriver
            Login loginWebPages = new  Login(loadCSV, driver);
            loginWebPages.LoginWithValidCredentials();
           // loginWebPages.LoginWithInvalidCredentials();
            
           
        }
    }
}
