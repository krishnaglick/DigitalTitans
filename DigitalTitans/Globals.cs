using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Globals
    {
        private static string _ConnectionString;
        public static string ConnectionString
        {
            get
            {
                if (_ConnectionString == null)
                {
                    _ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DigitalTitansConnectionString"].ConnectionString;
                }
                return _ConnectionString;
            }
            //set
            //{
            //    _ConnectionString = value;
            //}
        }
    }
}