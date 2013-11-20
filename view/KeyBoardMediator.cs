using System;
using UnityEngine;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;

namespace strange.examples.signals
{
	public class KeyBoardMediator : Mediator
	{
		[Inject]
		public KeyBoardView view{ get; set;}
		[Inject]
		public KeyBoardSignal keyBoardSignal{ get; set;}
		
		public override void OnRegister()
		{
			this.view.init ();
			this.view.keyBoardSignal.AddListener (this.onKeyBoard);
		}
		public override void OnRemove()
		{
			this.view.keyBoardSignal.RemoveListener (this.onKeyBoard);
		}
		public void onKeyBoard(KeyCode key)
		{
			this.keyBoardSignal.Dispatch (key);
		}
	}
}

