// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 15:05:57
// Update Time         :    2017/9/18 15:05:57
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
    public class FaultyReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefoundFor(ReturnOrder returnOrder)
        {
            //问题退库业务代码
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            //问题退款，除了商品价格，还包括运费
            returnOrder.AmountToRefund = returnOrder.PricePaid + returnOrder.PostageCost;
        }
    }
}
