using System;
using strange.extensions.context.impl;
using UnityEngine;

namespace strange.examples.signals
{
	public class SpaceShipRoot : ContextView
	{
	
		void Awake()
		{
			 
			context = new SpaceShipContext(this, true);
			context.Start ();
		}
	}
}

