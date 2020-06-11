using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public abstract class AbstactSKU
    {
        public abstract string Id { get; }
        public abstract int Price { get; }
        public abstract int Count { get; set; }
        public abstract decimal Result { get; set; }
        public abstract int PromotionPrice { get; }
        public abstract int PromotionCount { get; }
    }

}
