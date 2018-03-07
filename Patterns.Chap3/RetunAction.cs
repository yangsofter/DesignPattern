// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 14:47:21
// Update Time         :    2017/9/18 14:47:21
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
    /// 退货类型
    /// </summary>
    public enum RetunAction
    {
        /// <summary>
        /// 有问题退货
        /// </summary>
        FaultyReturn = 0,
        /// <summary>
        /// 无条件退货
        /// </summary>
        NoQuibblesReturn = 1
    }
}
