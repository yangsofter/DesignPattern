// =============================================================================== 
// Author              :    yangsofter
// Email               :    yangjianping@yfinfo.com
// Create Time         :    2017/9/18 15:09:29
// Update Time         :    2017/9/18 15:09:29
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

namespace Patterns.Chap3
{
    public class ReturnProcessFactory
    {
        public static ReturnProcessTemplate CreateFrom(RetunAction returnAction)
        {
            switch (returnAction)
            {
                case RetunAction.FaultyReturn:
                    return new FaultyReturnProcess();
                case RetunAction.NoQuibblesReturn:
                    return new NoQuibblesReturnProcess();
                default:
                    throw new ApplicationException("No Process Template defind for Return Action of" + returnAction.ToString());
            }
        }
    }
}
