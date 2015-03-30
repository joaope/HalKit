﻿using System;

namespace HalKit
{
    public class HalKitConfiguration : IHalKitConfiguration
    {
        public HalKitConfiguration(string apiRootEndpoint)
            : this(new Uri(apiRootEndpoint, UriKind.Absolute))
        {
        }

        public HalKitConfiguration(Uri rootEndpoint)
        {
            Requires.ArgumentNotNull(rootEndpoint, "rootEndpoint");

            RootEndpoint = rootEndpoint;
        }

        public Uri RootEndpoint { get; set; }

        public bool CaptureSynchronizationContext { get; set; }
    }
}