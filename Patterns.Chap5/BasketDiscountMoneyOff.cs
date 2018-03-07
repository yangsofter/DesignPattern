// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:41:53
// Update Time         :    2017/9/18 16:41:53
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
    ///满足特定的折扣门槛就能享受折扣，如购物车总价超过100元则减10元，满50元减5元，低于50没有折扣。
    /// </summary>
    public class BasketDiscountMoneyOff : IBasketDiscountStrategy
    {
        public decimal GetTotalCostAfterApplyingDiscountTo(Basket basket)
        {
            if (basket.TotolCost > 100)
            {
                return basket.TotolCost - 10m;
            }

            if (basket.TotolCost > 50)
            {
                return basket.TotolCost - 5m;
            }
            else
                return basket.TotolCost;
        }
    }
}
