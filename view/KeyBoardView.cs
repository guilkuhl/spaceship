using System;
using System.Collections;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace strange.examples.signals
{
	public class KeyBoardView : View
	{
		public KeyBoardSignal keyBoardSignal = new KeyBoardSignal();
		public void init ()
		{
			gameObject.AddComponent<KeyBoardDetectorSignal>();
			KeyBoardDetectorSignal keyBoardDetectorSignal = gameObject.GetComponent<KeyBoardDetectorSignal>() as KeyBoardDetectorSignal;
			keyBoardDetectorSignal.keyBoardSignal.AddListener(this.onKeyBoard);
		}
		public void onKeyBoard(KeyCode key)
		{
			keyBoardSignal.Dispatch (key);
		}

	}
}

