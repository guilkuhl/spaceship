using System;
using UnityEngine;
using strange.extensions.mediation.impl;
using strange.extensions.signal.impl;

namespace strange.examples.signals
{
	public class KeyBoardDetectorSignal : View
	{
		public KeyBoardSignal keyBoardSignal = new KeyBoardSignal ();

		public void Update ()
		{
						 
			if (Input.GetKeyDown (KeyCode.LeftArrow))
				keyBoardSignal.Dispatch (KeyCode.LeftArrow);
			else if (Input.GetKeyDown (KeyCode.RightArrow))
				keyBoardSignal.Dispatch (KeyCode.RightArrow);
			else if (Input.GetKeyDown (KeyCode.UpArrow))
				keyBoardSignal.Dispatch (KeyCode.UpArrow);
			else if (Input.GetKeyDown (KeyCode.DownArrow))
				keyBoardSignal.Dispatch (KeyCode.DownArrow);
		}
	}
}


