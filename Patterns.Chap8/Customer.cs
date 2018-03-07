// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/10/20 15:22:03
// Update Time         :    2017/10/20 15:22:03
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

namespace Patterns.Chap8
{
    public class Customer : EntityBase<long>
    {
        public Customer()
        {

        }

        public Customer(long id) : base(id)
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected override void CheckForBrokenRules()
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                base.AddBrokenRule("You must supply a first name.");
            }

            if (string.IsNullOrEmpty(LastName))
            {
                base.AddBrokenRule("You must supply a last name.");
            }
        }
    }
}
