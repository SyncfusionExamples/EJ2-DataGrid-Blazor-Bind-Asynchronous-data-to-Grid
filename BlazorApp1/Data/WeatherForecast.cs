using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorApp1.Data
{
    public class WeatherForecast
    {

        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public double? Freight { get; set; }
        public DateTime? OrderDate { get; set; }
        public static List<WeatherForecast> order = new List<WeatherForecast>();
        public WeatherForecast()
        {

        }
        public WeatherForecast(int OrderID, string CustomerId, int EmployeeId, double Freight, DateTime OrderDate)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerId;
            this.EmployeeID = EmployeeId;
            this.Freight = Freight;
            this.OrderDate = OrderDate;
        }
        public static List<WeatherForecast> GetAllRecords()
        {
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 10; i++)
                {
                    order.Add(new WeatherForecast(code + 1, "ALFKI", i + 0, 2.3 * i,  new DateTime(1991, 05, 15, 12, 57, 10)));
                    order.Add(new WeatherForecast(code + 2, "ANATR", i + 2, 3.3 * i, new DateTime(1990, 04, 04, 12, 57, 10)));
                    order.Add(new WeatherForecast(code + 3, "ANTON", i + 1, 4.3 * i, new DateTime(1957, 11, 30, 12, 57, 10)));
                    order.Add(new WeatherForecast(code + 4, "BLONP", i + 3, 5.3 * i,  new DateTime(1930, 10, 22, 12, 57, 10)));
                    order.Add(new WeatherForecast(code + 5, "BOLID", i + 4, 6.3 * i, new DateTime(1953, 02, 18, 12, 57, 10)));
                    code += 5;
                }
            }
            return order;
        }
    }

}
