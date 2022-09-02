using System;

namespace AssemblyInformationEndpoint
{
    public class AssemblyInformationEndpointOptions
    {
        [RelativeUrl]
        public Uri Uri { get; set; }
    }
}