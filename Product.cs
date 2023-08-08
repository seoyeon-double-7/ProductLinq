using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq
{
   class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public override string ToString()
        {
            // 감자 : 500원
            return Name + ":" + Price + "원";
        }
    }
}
