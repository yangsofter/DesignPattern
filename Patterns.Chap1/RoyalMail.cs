﻿// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/8 10:03:53
// Update Time         :    2017/9/8 10:03:53
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
    public class RoyalMail : IShippingCourier
    {
        public string GenerateConsignmentLabelFor(Address address)
        {
            return "RMXXXX-XXXX-XXXX";
        }

    }
}
