using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace strange.examples.signals
{
	public class DammageCommand : Command
	{
		[Inject]
		public DammageSignal dammageSignal{ get; set; }
		
		[Inject]//inject the model affect not a new instance
		public IShip shipModel{ get; set; }

		public override void Execute ()
		{

			this.shipModel.life -= 1;
			Debug.Log (this.shipModel.life);
		}
	}
}

