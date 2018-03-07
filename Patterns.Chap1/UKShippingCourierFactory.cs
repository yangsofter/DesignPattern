// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/8 10:05:36
// Update Time         :    2017/9/8 10:05:36
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

namespace Patterns.Chap1
{
    public class UKShippingCourierFactory
    {
        /// <summary>
        /// 根据订单的总价和重量来确定返回哪一家货运公司
        /// </summary>
        public static IShippingCourier CreateShippingCourier(Order order)
        {
            if ((order.TotalCost > 100) || (order.WeightInKG) > 5)
                return new DHL();
            else
                return new RoyalMail();
        }
    }
}
