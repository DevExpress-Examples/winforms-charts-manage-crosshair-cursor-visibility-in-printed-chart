using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintCrosshairSample {
    public class SaleItemRepository {
        readonly static List<String> companies = new List<String> { "DevAV North", "DevAV South", "DevAV West", "DevAV East", "DevAV Central" };
        readonly static Dictionary<string, List<string>> categorizedProducts = new Dictionary<string, List<string>> {
            { "Cameras",                new List<string>() { "Camera", "Camcorder", "Binoculars", "Flash", "Tripod" } },
            { "Cell Phones",            new List<string>() { "Smartphone", "Mobile Phone", "Smart Watch", "Sim Card" } },
            { "Computers",              new List<string>() { "Desktop", "Laptop", "Tablet", "Printer" } },
            { "TV, Audio",              new List<string>() { "Television", "Home Audio", "Headphone", "DVD Player" } },
            { "Vehicle Electronics",    new List<string>() { "GPS Unit", "Radar", "Car Alarm", "Car Accessories" } },
        };

        public List<SaleItem> GetProductsByMonths() {
            Random rnd = new Random();
            List<SaleItem> items = new List<SaleItem>();
            foreach (string company in companies)
                foreach (string product in categorizedProducts["Cameras"]) {
                    DateTime dateTime = new DateTime(2017, 12, 01);
                    for (int i = 0; i < 12; i++) {
                        int income = rnd.Next(20, 100);
                        int revenue = income + rnd.Next(20, 50);
                        items.Add(new SaleItem() {
                            Company = company,
                            Product = product,
                            Month = dateTime.AddMonths(1).ToString("MMMM", CultureInfo.InvariantCulture),
                            Income = income,
                            Revenue = revenue
                        });
                        dateTime = dateTime.AddMonths(1);
                    }
                }
            return items;
        }
        public List<SaleItem> GetProductsByCompany(int companyIndex) {
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<SaleItem> items = new List<SaleItem>();
            foreach (string category in categorizedProducts.Keys) {
                foreach (string product in categorizedProducts[category]) {
                    int income = rnd.Next(20, 100);
                    int revenue = income + rnd.Next(20, 50);
                    items.Add(new SaleItem() {
                        Company = companies[companyIndex],
                        Product = product,
                        Income = income,
                        Revenue = revenue,
                        Category = category
                    });
                }
            }
            return items;
        }
        public List<SaleItem> GetProductsIncome() {
            Random rnd = new Random(DateTime.Now.Millisecond);
            List<SaleItem> items = new List<SaleItem>();
            for (int i = 0; i < 50; i++)
                foreach (string product in categorizedProducts["Cameras"]) {
                    items.Add(new SaleItem() {
                        Product = product,
                        Income = rnd.Next(20, 100)
                    });
                }
            return items;
        }
        public List<SaleItem> GetTotalIncome() {
            Random rnd = new Random(DateTime.Now.Millisecond);
            DateTime now = DateTime.Now;
            DateTime endDate = new DateTime(now.Year, now.Month, 1);
            List<SaleItem> items = new List<SaleItem>();
            foreach (string company in companies) {
                double companyFactor = rnd.NextDouble() * 0.6 + 1;
                foreach (string category in categorizedProducts.Keys) {
                    double categoryFactor = rnd.NextDouble() * 0.6 + 1;
                    foreach (string product in categorizedProducts[category]) {
                        int maxIncome = rnd.Next(60, 140);
                        for (int i = 0; i < 1000; i++) {
                            if (i % 100 == 0)
                                maxIncome = Math.Max(40, rnd.Next(maxIncome - 20, maxIncome + 20));
                            DateTime date = endDate.AddDays(-i - 1);
                            double income = rnd.Next(20, maxIncome) * companyFactor * categoryFactor;
                            items.Add(new SaleItem() { Category = category, Company = company, Product = product, OrderDate = date, Income = income });
                        }
                    }
                }
            }
            return items;
        }
    }

    public class SaleItem {
        public string Product { get; set; }
        public string Company { get; set; }
        public DateTime OrderDate { get; set; }
        public string Month { get; set; }
        public double Income { get; set; }
        public double Revenue { get; set; }
        public string Category { get; set; }
    }
}
