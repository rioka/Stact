// Copyright 2007-2008 The Apache Software Foundation.
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
namespace Magnum.Web.Actors
{
	using Channels;

	/// <summary>
	/// A model that also has an output channel binding so that it can be used to
	/// return information to the asynchronous actor that invoked it
	/// </summary>
	/// <typeparam name="TOutput">The type of the output model</typeparam>
	public interface HasOutputChannel<TOutput>
	{
		Channel<TOutput> OutputChannel { get; set; }
	}
}