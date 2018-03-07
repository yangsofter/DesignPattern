﻿// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:10:54
// Update Time         :    2017/9/18 16:10:54
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

namespace Patterns.Chap4
{
    /// <summary>
    /// 订单状态
    /// </summary>
    public enum OrderStatus
    {
        New = 0,
        Shipped = 1,
        Canceled = 2
    }
}
