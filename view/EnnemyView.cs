using System;
using System.Collections;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace strange.examples.signals
{
	public class EnnemyView : View
	{
		public Signal clickSignal = new Signal();
		public void init ()
		{
			gameObject.AddComponent<ClickDetector>();
			ClickDetector clicker = gameObject.GetComponent<ClickDetector>() as ClickDetector;
			clicker.clickSignal.AddListener(onClick);
		}
		public void onClick()
		{
			clickSignal.Dispatch ();
		}
	}
}

