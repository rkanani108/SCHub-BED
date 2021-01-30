using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Web.SquidexAPI.UnitTest
{
    [TestClass]
    public class Squidex
    {
        [TestMethod]
        public void GetToken()
        {

            string url= "http://localhost:90/identity-server/connect/token";
            var header = new Dictionary<string,string>();
            header.Add("Content-Type", "application/x-www-form-urlencoded");

        }
    }
}
