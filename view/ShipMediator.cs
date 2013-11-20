using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace strange.examples.signals
{
	//Not extending EventMediator anymore
	public class ShipMediator : Mediator
	{
		[Inject]
		public ShipView view{ get; set;}
		
		
		public override void OnRegister()
		{
		 
		}
		
		public override void OnRemove()
		{
		 
		}
		
 
	}
}

