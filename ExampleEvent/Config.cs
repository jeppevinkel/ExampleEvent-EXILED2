﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace ExampleEvent
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;
	}
}
