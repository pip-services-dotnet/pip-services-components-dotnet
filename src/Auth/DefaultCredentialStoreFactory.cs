﻿using PipServices.Components.Build;
using PipServices.Commons.Refer;

namespace PipServices.Components.Auth
{
    /// <summary>
    /// Creates ICredentialStore components by their descriptors.
    /// </summary>
    /// See <see cref="IFactory"/>, <see cref="ICredentialStore"/>, <see cref="MemoryCredentialStore"/>
    public class DefaultCredentialStoreFactory: Factory
    {
        public static readonly Descriptor Descriptor = new Descriptor("pip-services", "factory", "credential-store", "default", "1.0");
        public static readonly Descriptor MemoryCredentialStoreDescriptor = new Descriptor("pip-services", "credential-store", "memory", "*", "1.0");
        public static readonly Descriptor MemoryCredentialStoreDescriptor2 = new Descriptor("pip-services-commons", "credential-store", "memory", "*", "1.0");

        /// <summary>
        /// Create a new instance of the factory.
        /// </summary>
        public DefaultCredentialStoreFactory()
        {
            RegisterAsType(MemoryCredentialStoreDescriptor, typeof(MemoryCredentialStore));
            RegisterAsType(MemoryCredentialStoreDescriptor2, typeof(MemoryCredentialStore));
	    }	
    }
}
