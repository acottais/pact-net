﻿using System.Collections.Generic;
using PactNet.Infrastructure.Outputters;
using PactNet.PactMessage;

namespace PactNet.Tests.IntegrationTests
{
	public class IntegrationTestsMyConsumer
	{
		public IPactMessageBuilder PactBuilder { get; }
		public IPactMessage PactMessage { get; }

		public IntegrationTestsMyConsumer()
		{
			var pactConfig = new PactConfig
			{
				SpecificationVersion = "3.0.0",
				Outputters = new List<IOutput>
				{
					new ConsoleOutput()
				}
			};
			PactBuilder = new PactMessageBuilder(pactConfig)
				.HasPactWith("Integration Tests")
				.ServiceConsumer("My Consumer");

			PactMessage = PactBuilder.PactMessage();
		}
	}
}
