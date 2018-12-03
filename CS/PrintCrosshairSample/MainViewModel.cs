using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintCrosshairSample {
    public class MainViewModel {
        private SaleItemRepository repository;

        public IReadOnlyList<SaleItemAggregate> TotalIncome {
            get => repository
                .GetTotalIncome()
                .GroupBy(i => new { i.Category, i.Company })
                .Select(g => new SaleItemAggregate {
                    Category = g.Key.Category,
                    Company = g.Key.Company,
                    Value = g.Sum(i => i.Income)
                })
                .ToList();
        }

        public MainViewModel() {
            this.repository = new SaleItemRepository();
        }
    }

    public class SaleItemAggregate {
        public string Company { get; set; }
        public string Category { get; set; }
        public double Value { get; set; }
    }
}
