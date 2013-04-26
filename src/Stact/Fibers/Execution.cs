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
    using System.Threading.Tasks;


    /// <summary>
    /// An Execution is a unit of work that can be scheduled on a Fiber
    /// </summary>
    public interface Execution
    {
        /// <summary>
        /// Execute the behavior of the execution. Execute is called from the Fiber's execution
        /// context, so synchronous operations can be performed
        /// </summary>
        /// <param name="executionContext">The context of the Execution provided by the Fiber</param>
        /// <returns></returns>
        Task Execute(ExecutionContext executionContext);
    }
}