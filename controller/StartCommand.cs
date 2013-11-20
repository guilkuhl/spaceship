/// The only change in StartCommand is that we extend Command, not EventCommand

using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.impl;

namespace strange.examples.signals
{
	public class StartCommand : Command
	{
		
		[Inject(ContextKeys.CONTEXT_VIEW)]
		public GameObject contextView{get;set;}
		
		public override void Execute()
		{
			//keyboard input
			GameObject go = new GameObject ();
			go.name = "keyboard input";
			go.AddComponent<KeyBoardView>();

			go.transform.parent = contextView.transform;
		}
	}
}

