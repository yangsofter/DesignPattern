// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 14:57:49
// Update Time         :    2017/9/18 14:57:49
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
    /// 退货处理
    /// </summary>
    public abstract class ReturnProcessTemplate
    {
        /// <summary>
        /// 
        /// </summary>
        protected abstract void GenerateReturnTransactionFor(ReturnOrder returnOrder);
        protected abstract void CalculateRefoundFor(ReturnOrder returnOrder);
        public void Process(ReturnOrder returnOrder) {
            GenerateReturnTransactionFor(returnOrder);
            CalculateRefoundFor(returnOrder);
        }
    }
}
