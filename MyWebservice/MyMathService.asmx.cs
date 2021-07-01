using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyWebservice
{
    /// <summary>
    /// Summary description for MyMathService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MyMathService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]

        public double Add(double x, double y)
        {
            return x + y;
        }
        [WebMethod]

        public double Sub(double x, double y)
        {
            return x - y;
        }
        [WebMethod]

        public double Mul(double x, double y)
        {
            return x * y;
        }
        [WebMethod]

        public double Div(double x, double y)
        {
            if (y == 0)
            {
                return 0;
            }
            else
            {
                return x / y;

            }
        }
    }
}
