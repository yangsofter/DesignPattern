// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:47:43
// Update Time         :    2017/9/18 16:47:43
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
    public class NoBasketDiscount : IBasketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscountTo(Basket basket)
        {
            return basket.TotolCost;
        }
    }
}
