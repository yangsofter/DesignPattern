// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:09:39
// Update Time         :    2017/9/18 16:09:39
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
    public interface IOrderState
    {
        bool CanShip(Order order);
        void Ship(Order order);

        bool CanCancel(Order order);
        void Cancel(Order order);

        OrderStatus Status { get; }
    }
}
