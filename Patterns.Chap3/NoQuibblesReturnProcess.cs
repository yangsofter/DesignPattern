// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 15:02:18
// Update Time         :    2017/9/18 15:02:18
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
    public class NoQuibblesReturnProcess : ReturnProcessTemplate
    {
        protected override void CalculateRefoundFor(ReturnOrder returnOrder)
        {
           //处理退库的业务代码
        }

        protected override void GenerateReturnTransactionFor(ReturnOrder returnOrder)
        {
            //无条件退款，只是退还商品价格，不包含邮费运费
            returnOrder.AmountToRefund = returnOrder.PricePaid;
        }
    }
}
