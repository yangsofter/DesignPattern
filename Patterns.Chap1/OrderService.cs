// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/8 10:12:06
// Update Time         :    2017/9/8 10:12:06
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
    public class OrderService
    {
        /// <summary>
        /// 该方法是协调有效货运公司的获取以及托运标识符的创建
        /// </summary>
        /// <param name="order"></param>
        public void Dispatch(Order order)
        {
            IShippingCourier shippingCourier = UKShippingCourierFactory.CreateShippingCourier(order);

            order.CourierTrackingId = shippingCourier.GenerateConsignmentLabelFor(order.DispatchAddress);
        }
    }
}
