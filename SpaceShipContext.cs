
using System;
using UnityEngine;
using strange.extensions.context.api;
using strange.extensions.context.impl;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.dispatcher.eventdispatcher.impl;
using strange.extensions.command.api;
using strange.extensions.command.impl;

namespace strange.examples.signals
{
	public class SpaceShipContext : MVCSContext 
	{
		
		
		public SpaceShipContext () : base()
		{
		}
		
		public SpaceShipContext (MonoBehaviour view, bool autoStartup) : base(view, autoStartup)
		{
		}
		
		// Unbind the default EventCommandBinder and rebind the SignalCommandBinder
		protected override void addCoreComponents()
		{
			base.addCoreComponents();
			injectionBinder.Unbind<ICommandBinder>();
			injectionBinder.Bind<ICommandBinder>().To<SignalCommandBinder>().ToSingleton();
		}
		
		// Override Start so that we can fire the StartSignal 
		override public IContext Start()
		{
			base.Start();
			StartSignal startSignal= (StartSignal)injectionBinder.GetInstance<StartSignal>();
			startSignal.Dispatch();
			return this;
		}
		
		protected override void mapBindings()
		{
			injectionBinder.Bind<IShip>().To<EnnemyShip>();

			injectionBinder.Bind<KeyBoardSignal>().ToSingleton();

			mediationBinder.Bind<ShipView>().To<ShipMediator>();
			mediationBinder.Bind<EnnemyView>().To<EnnemyMediator>();
			mediationBinder.Bind<KeyBoardView>().To<KeyBoardMediator>();

			commandBinder.Bind<StartSignal>().To<StartCommand>().Once ();
			commandBinder.Bind<KeyBoardSignal>().To<InputCommand>();
			commandBinder.Bind<DammageSignal>().To<DammageCommand>();
		
		}
	}
}

