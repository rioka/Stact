﻿// Copyright 2010-2013 Chris Patterson
//  
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use 
// this file except in compliance with the License. You may obtain a copy of the 
// License at 
// 
//     http://www.apache.org/licenses/LICENSE-2.0 
// 
// Unless required by applicable law or agreed to in writing, software distributed 
// under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
// CONDITIONS OF ANY KIND, either express or implied. See the License for the 
// specific language governing permissions and limitations under the License.
namespace Stact
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Internals.Tasks;


    public static class ExecutionContextExtensions
    {
        public static Task Completed(this ExecutionContext executionContext)
        {
            return TaskUtil.Completed();
        }

        public static Task Canceled(this ExecutionContext executionContext)
        {
            return TaskUtil.Canceled();
        }

        public static Task Faulted(this ExecutionContext executionContext, Exception exception)
        {
            return TaskUtil.Faulted(exception);
        }

        public static Task Faulted(this ExecutionContext executionContext, IEnumerable<Exception> exceptions)
        {
            return TaskUtil.Faulted(exceptions);
        }
    }
}