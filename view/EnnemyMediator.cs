using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace strange.examples.signals
{
	public class EnnemyMediator : Mediator
	{
		[Inject]
		public EnnemyView view{ get; set;}
		[Inject]
		public IShip shipModel{ get; set;}
		[Inject]
		public DammageSignal dammageSignal{ get; set;}

		public override void OnRegister()
		{
			this.view.init ();
			this.view.clickSignal.AddListener (onClick);
		 
		}
		public override void OnRemove()
		{
			this.view.clickSignal.RemoveListener (onClick);
		}

		public void onClick()
		{
			this.dammageSignal.Dispatch(shipModel); 
		}
	}
}

