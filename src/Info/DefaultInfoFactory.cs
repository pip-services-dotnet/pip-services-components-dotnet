﻿using System;
using PipServices3.Components.Build;
using PipServices3.Commons.Refer;

namespace PipServices3.Components.Info
{
    /// <summary>
    /// Creates information components by their descriptors.
    /// </summary>
    /// See <a href="https://pip-services3-dotnet.github.io/pip-services3-commons-dotnet/class_pip_services3_1_1_commons_1_1_config_1_1_config_params.html">Factory</a>, 
    /// <see cref="ContextInfo"/>
    public class DefaultInfoFactory : Factory
    {
        public static readonly Descriptor Descriptor = new Descriptor("pip-services", "factory", "info", "default", "1.0");
        public static readonly Descriptor Descriptor3 = new Descriptor("pip-services3", "factory", "info", "default", "1.0");
        public static Descriptor ContextInfoDescriptor = new Descriptor("pip-services", "context-info", "default", "*", "1.0");
        public static Descriptor ContextInfo3Descriptor = new Descriptor("pip-services3", "context-info", "default", "*", "1.0");
        public static Descriptor ContainerInfoDescriptor = new Descriptor("pip-services", "container-info", "default", "*", "1.0");
        public static Descriptor ContainerInfo3Descriptor = new Descriptor("pip-services3", "container-info", "default", "*", "1.0");
        public static Descriptor ContainerInfoDescriptor2 = new Descriptor("pip-services-container", "container-info", "default", "*", "1.0");
        public static Descriptor ContainerInfo3Descriptor2 = new Descriptor("pip-services3-container", "container-info", "default", "*", "1.0");

        /// <summary>
        /// Create a new instance of the factory.
        /// </summary>
        public DefaultInfoFactory()
        {
            RegisterAsType(ContextInfoDescriptor, typeof(ContextInfo));
            RegisterAsType(ContextInfo3Descriptor, typeof(ContextInfo));
            RegisterAsType(ContainerInfoDescriptor, typeof(ContextInfo));
            RegisterAsType(ContainerInfo3Descriptor, typeof(ContextInfo));
            RegisterAsType(ContainerInfoDescriptor2, typeof(ContextInfo));
            RegisterAsType(ContainerInfo3Descriptor2, typeof(ContextInfo));
        }
    }
}
