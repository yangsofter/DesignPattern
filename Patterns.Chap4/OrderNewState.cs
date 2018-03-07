// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 16:27:45
// Update Time         :    2017/9/18 16:27:45
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
    public class OrderNewState : IOrderState
    {
        public OrderStatus Status
        {
            get
            {
                return OrderStatus.New;
            }
        }

        public bool CanCancel(Order order)
        {
            return true;
        }

        public void Cancel(Order order)
        {
            order.Change(new OrderCanceledState());
        }

        public bool CanShip(Order order)
        {
            return true;
        }

        public void Ship(Order order)
        {
            order.Change(new OrderShippedState());
        }
    }
}
