// Copyright 2010 Chris Patterson
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
namespace Stact.ForNHibernate.Specs.Usage
{
	using Channels;
	using Magnum.TestFramework;


	[Scenario]
	public class When_sending_messages_to_an_actor_stored_using_nhibernate :
		Given_an_nhibernate_session_factory
	{
		[When]
		public void Sending_messages_to_an_instance_stored_using_nhibernate()
		{
			var input = new ChannelAdapter();
			using (input.Connect(x => { }))
				;
		}
	}
}