// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 14:49:04
// Update Time         :    2017/9/18 14:49:04
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

namespace Patterns.Chap3
{
    /// <summary>
    /// 退货单
    /// </summary>
    public class ReturnOrder
    {
        public RetunAction Action { get; set; }
        public string PaymentTransactionId { get; set; }
        public decimal PricePaid { get; set; }
        public decimal PostageCost { get; set; }
        public long ProductId { get; set; }
        public decimal AmountToRefund { get; set; }
    }
}
