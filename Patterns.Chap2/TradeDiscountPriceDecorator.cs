// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/11 16:25:20
// Update Time         :    2017/9/11 16:25:20
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
    /// IPrice的第二种实现，使用商业折扣逻辑来装饰默认的价格行为
    /// TradeDiscountPriceDecorator类的作用是包装IPrice接口的实现（TradeDiscountPriceDecorator构造器提供），将价格降低了0.5%.
    /// 因为Product类是通过接口引用价格，所以它并不知道自己正在与TradeDiscountPriceDecorator类交互。
    /// </summary>
    public class TradeDiscountPriceDecorator : IPrice
    {
        private IPrice _basePrice;

        public TradeDiscountPriceDecorator(IPrice price)
        {
            _basePrice = price;
        }

        public decimal Cost
        {
            get
            {
                return _basePrice.Cost * 0.95m;
            }

            set
            {
                _basePrice.Cost = value;
            }
        }
    }
}
