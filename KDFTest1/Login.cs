using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDFTest1
{
    public class Login
    {

        private ILoadData loadData;
        private IWebDriver driver;

        public Login(ILoadData loadData, IWebDriver driver)
        {
            this.loadData = loadData;
            this.driver = driver;
        }

        public void LoginWithValidCredentials()
        {
            
            //var lines = loadData.Read(Environment.GetEnvironmentVariable("PATH_DATA_SOURCE"));
            
            //New method added for file path
            var lines = loadData.Read(CommonMethods.DataFilePath());
            
            loadData.ExecuteTestCases(lines, driver);
        }


        public void LoginWithInvalidCredentials()
        {
            //var lines = loadData.Read(Environment.GetEnvironmentVariable("PATH_DATA_SOURCE"));
            //New method added for file path
            var lines = loadData.Read(CommonMethods.DataFilePath());
            loadData.ExecuteTestCases(lines, driver);
        }
    }
}
