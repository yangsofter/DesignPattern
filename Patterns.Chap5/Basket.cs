// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:38:46
// Update Time         :    2017/9/18 16:38:46
// =============================================================================== 
// CLR Version         :    4.0.30319.42000
// Class Version       :    v1.0.0.0
// Class Description   :    
// ===============================================================================
// Copyright ©山东银方信息技术有限公司 2017 . All rights reserved.
// ===============================================================================
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.Chap5
{
    /// <summary>
    /// 购物车
    /// </summary>
    public class Basket
    {
        private IBasketDiscountStrategy _basketDiscount;

        public Basket(DiscountType discountType)
        {
            _basketDiscount = BasketDiscountFactory.GetDiscount(discountType);
        }
        public decimal TotolCost { get; set; }

        public decimal GetTotalCostAfterDiscount()
        {
            return _basketDiscount.GetTotalCostAfterApplyingDiscountTo(this);
        }
    }
}
