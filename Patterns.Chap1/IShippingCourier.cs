// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/8 10:00:06
// Update Time         :    2017/9/8 10:00:06
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
    /// <summary>
    /// 为货运公司创建接口
    /// </summary>
   public interface IShippingCourier
    {
        /// <summary>
        /// 将Address参数作为实参并返回一个托运ID字符串
        /// </summary>
        string GenerateConsignmentLabelFor(Address address);
    }
}
