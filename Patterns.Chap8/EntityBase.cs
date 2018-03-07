// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/10/20 15:08:59
// Update Time         :    2017/10/20 15:08:59
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
    public abstract class EntityBase<T>
    {
        private T _id;
        private IList<string> _brokenRules = new List<string>();
        private bool _idHasBeenSet = false;

        public T Id {
            get { return _id; }
            set {
                if (_idHasBeenSet)
                {
                    ThrowExceptionIfOverwritingAnId();
                }
                _id = value;
                _idHasBeenSet = true;
            }
        }

        private void ThrowExceptionIfOverwritingAnId()
        {
            throw new ApplicationException("You cannot change the id of an entity");
        }

        public EntityBase()
        {

        }

        public EntityBase(T id)
        {
            this.Id = id;
        }

        public bool IsValid() {
            ClearCollectionOfBrokenRules();
            CheckForBrokenRules();
            return _brokenRules.Count() == 0;
        }

        protected abstract void CheckForBrokenRules();

        private void ClearCollectionOfBrokenRules()
        {
            _brokenRules.Clear();
        }

        protected void AddBrokenRule(string brokenRule) {
            _brokenRules.Add(brokenRule);
        }
    }
}
