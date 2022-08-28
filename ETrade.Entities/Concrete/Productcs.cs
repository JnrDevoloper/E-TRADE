using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;

namespace ETrade.Entities.Concrete
{
    public class Productcs :IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int  ColorId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }
}
