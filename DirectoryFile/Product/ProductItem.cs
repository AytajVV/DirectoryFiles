using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectoryFile.Product
{
    class ProductItem
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
        public Product Product { get; set; }
    }
}
