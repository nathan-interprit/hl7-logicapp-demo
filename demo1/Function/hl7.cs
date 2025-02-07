//------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
//------------------------------------------------------------

namespace interprit
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Azure.Functions.Extensions.Workflows;
    using Microsoft.Azure.Functions.Worker;
    using Microsoft.Extensions.Logging;
    using Interprit.Demo.HL7;

    /// <summary>
    /// Represents the hl7 flow invoked function.
    /// </summary>
    public class hl7
    {
        private readonly ILogger<hl7> logger;

        public hl7(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<hl7>();
        }

        /// <summary>
        /// Executes the logic app workflow.
        /// </summary>
        /// <param name="zipCode">The zip code.</param>
        /// <param name="temperatureScale">The temperature scale (e.g., Celsius or Fahrenheit).</param>
        [Function("hl7")]
        public Task<ADT_A01> Run([WorkflowActionTrigger] string HL7Message)
        {
            this.logger.LogInformation("Starting hl7");


            ADT_A01 adt01 = new ADT_A01(HL7Message);



            return Task.FromResult(adt01);
        }

    }
}