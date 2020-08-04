using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventManager.Api;
using EventManager.Api.Interfaces;
using Exiled.API.Features;
using Exiled.API.Interfaces;

namespace ExampleEvent
{
    public sealed class ExampleEvent : Plugin<Config>, IEventPlugin
	{
	    private static readonly Lazy<ExampleEvent> LazyInstance = new Lazy<ExampleEvent>(() => new ExampleEvent());
	    public static ExampleEvent Instance => LazyInstance.Value;

	    public override void OnEnabled()
	    {
		    base.OnEnabled();

		    Api.RegisterEvent(this);
	    }

	    public void OnEventStarted()
		{
			Log.Info("I was started!");
		}

		public void OnEventStopped()
		{
			Log.Info("I was stopped!");
		}

		private ExampleEvent()
	    {
	    }
	}
}
