using PromotionEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ConcreteSKU
    {

    }
    public class A : AbstactSKU
    {
        public override string Id => SKUId.SKU.A.ToString();
        public override int Price => 50;
        public override int Count { get; set; }
        public override decimal Result { get; set; }
        public override int PromotionPrice => 130;
        public override int PromotionCount => 3;
    }
    public class B : AbstactSKU
    {
        public override string Id => SKUId.SKU.B.ToString();

        public override int Price => 30;

        public override int Count { get; set; }

        public override decimal Result { get; set; }

        public override int PromotionPrice => 45;

        public override int PromotionCount => 2;
    }
    public class C : AbstactSKU
    {
        public override string Id => SKUId.SKU.C.ToString();

        public override int Price => 20;

        public override int Count { get; set; }

        public override decimal Result { get; set; }

        public override int PromotionPrice => 1;

        public override int PromotionCount => 1;
    }
}
