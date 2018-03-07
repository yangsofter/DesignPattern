// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/11 16:30:16
// Update Time         :    2017/9/11 16:30:16
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
    /// IPrice接口的第三种实现，使用现金乘数装饰IPrice实现的类
    /// </summary>
    public class CurrencyPriceDecorator : IPrice
    {

        private IPrice _basePrice;
        private decimal _exchangeRate;
        public CurrencyPriceDecorator(IPrice price, decimal exchangeRate)
        {
            _basePrice = price;
            _exchangeRate = exchangeRate;
        }

        public decimal Cost
        {
            get
            {
                return _basePrice.Cost * _exchangeRate;
            }

            set
            {
                _basePrice.Cost = value;
            }
        }
    }
}
