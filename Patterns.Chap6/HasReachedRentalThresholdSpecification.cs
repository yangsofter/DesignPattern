// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 17:10:33
// Update Time         :    2017/9/18 17:10:33
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

namespace Patterns.Chap6
{
    public class HasReachedRentalThresholdSpecification : ISpecification<CustomerAccount>
    {
        public bool IsSatisfiedBy(CustomerAccount candidate)
        {
            return candidate.NumberOfRentalsThisMonth >= 5;
        }
    }
}
