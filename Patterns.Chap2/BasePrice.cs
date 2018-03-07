// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/11 16:22:46
// Update Time         :    2017/9/11 16:22:46
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

namespace Patterns.Chap2
{
    /// <summary>
    /// IPrice的第一种实现，提供了商品价格的默认行为，
    /// 并且由资源库在从数据存储中提取商品列表时设置该价格
    /// </summary>
    public class BasePrice : IPrice
    {
        private decimal _cost;

        public decimal Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = value;
            }
        }
    }
}
