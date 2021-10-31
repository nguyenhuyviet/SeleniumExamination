using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TShapedFoundation.DTO
{
    public class ProductDetails
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string Availability { get; set; }
        public IEnumerable<string> Colors { get; set; }
    }
}
