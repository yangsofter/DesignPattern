// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/11 16:33:13
// Update Time         :    2017/9/11 16:33:13
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
    /// 添加一组扩展方法，将装饰行为应用到Product类
    /// </summary>
    public static class ProductCollectionExtensionMethods
    {
        public static void ApplyCurrencyMultiplier(this IEnumerable<Product> products, decimal exchangeRate)
        {
            foreach (Product p in products)
            {
                p.Price = new CurrencyPriceDecorator(p.Price, exchangeRate);
            }
        }

        public static void ApplyTradeDiscount(this IEnumerable<Product> products)
        {
            foreach (var p in products)
            {
                p.Price = new TradeDiscountPriceDecorator(p.Price);
            }
        }
    }
}
