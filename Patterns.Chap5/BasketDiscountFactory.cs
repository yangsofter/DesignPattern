// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:48:56
// Update Time         :    2017/9/18 16:48:56
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
    public class BasketDiscountFactory
    {
        public static IBasketDiscountStrategy GetDiscount(DiscountType discountType)
        {
            switch (discountType)
            {

                case DiscountType.MoneyOff:
                    return new BasketDiscountMoneyOff();
                case DiscountType.PercentageOff:
                    return new BasketDiscountPercentageOff();
                default:
                    return new NoBasketDiscount()
            }
        }
    }
}
