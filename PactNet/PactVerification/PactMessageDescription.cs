﻿using System.Collections.Generic;
using PactNet.PactMessage.Models;

namespace PactNet.PactVerification
{
	public class PactMessageDescription
	{
		public string Description { get; set; }
		public List<ProviderState> ProviderStates { get; set; }
	}
}