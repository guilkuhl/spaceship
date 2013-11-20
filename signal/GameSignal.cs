
using System;
using strange.extensions.signal.impl;
using UnityEngine;

namespace strange.examples.signals
{
	public class StartSignal : Signal{}
	public class KeyBoardSignal : Signal<KeyCode>{}
	public class DammageSignal : Signal<IShip>{}
}

