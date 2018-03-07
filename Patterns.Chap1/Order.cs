// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/8 9:58:31
// Update Time         :    2017/9/8 9:58:31
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
   public class Order
    {
        public decimal TotalCost { get; set; }
        public decimal WeightInKG { get; set; }
        public string CourierTrackingId { get; set; }
        public Address DispatchAddress { get; set; }
    }
}
