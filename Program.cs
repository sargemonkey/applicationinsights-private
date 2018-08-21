using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace ApplicationInsightsPrivate
{

    class CustomTelemetryChannel : ITelemetryChannel
    {
        public string EndpointAddress { get; set; }
        public bool? DeveloperMode { get; set; }

        public void Send(ITelemetry telemetry)
        {

        }

        public void Flush()
        {

        }

        public void Dispose()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string instrumentationKey = "";
            // ITelemetryChannel channel = new InMemoryChannel();
            ITelemetryChannel channel = new CustomTelemetryChannel();
            TelemetryConfiguration tc = new TelemetryConfiguration(instrumentationKey, channel);
            TelemetryClient tclient = new TelemetryClient();
            tclient.TrackEvent(new EventTelemetry("event1"));
        }
    }
}
