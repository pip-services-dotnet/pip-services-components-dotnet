﻿using PipServices.Commons.Config;
using PipServices.Commons.Refer;
using PipServices.Commons.Run;

using System.Threading.Tasks;

namespace PipServices.Components.Cache
{
    /// <summary>
    /// Abstract cache class to provide common cache functionality
    /// </summary>
    /// <seealso cref="PipServices.Components.Cache.ICache" />
    /// <seealso cref="PipServices.Commons.Config.IConfigurable" />
    /// <seealso cref="PipServices.Commons.Refer.IReferenceable" />
    /// <seealso cref="PipServices.Commons.Run.IOpenable" />
    public abstract class AbstractCache : ICache, IConfigurable, IReferenceable, IOpenable
    {
        private readonly long DefaultTimeout = 60000; // 1 min

        /// <summary>
        /// Gets or sets the timeout.
        /// </summary>
        public long Timeout { get; set; }

        /// <summary>
        /// Sets the components configuration.
        /// </summary>
        /// <param name="config">Configuration parameters.</param>
        public virtual void Configure(ConfigParams config)
        {
            Timeout = config.GetAsLongWithDefault("timeout", DefaultTimeout);
        }

        /// <summary>
        /// Sets the references.
        /// </summary>
        /// <param name="references">The references.</param>
        public virtual void SetReferences(IReferences references)
        {
        }

        /// <summary>
        /// Closes component, disconnects it from services, disposes resources
        /// </summary>
        /// <param name="correlationId">a unique transaction id to trace calls across components</param>
        public virtual Task CloseAsync(string correlationId)
        {
            return Task.Delay(0);
        }

        /// <summary>
        /// Checks if component is opened
        /// </summary>
        public virtual bool IsOpen()
        {
            return true;
        }

        /// <summary>
        /// Opens component, establishes connections to services
        /// </summary>
        /// <param name="correlationId">a unique transaction id to trace calls across components</param>
        public virtual Task OpenAsync(string correlationId)
        {
            return Task.Delay(0);
        }

        /// <summary>
        /// Removes an object from cache.
        /// </summary>
        /// <param name="correlationId"></param>
        /// <param name="key">Unique key identifying the object.</param>
        public abstract Task RemoveAsync(string correlationId, string key);

        /// <summary>
        /// Retrieves a value from cache by unique key.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="correlationId"></param>
        /// <param name="key">Unique key identifying a data object.</param>
        /// <returns>
        /// Cached value or null if the value is not found.
        /// </returns>
        public abstract Task<T> RetrieveAsync<T>(string correlationId, string key);

        /// <summary>
        /// Stores an object identified by a unique key in cache.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="correlationId"></param>
        /// <param name="key">Unique key identifying a data object.</param>
        /// <param name="value">The data object to store.</param>
        /// <param name="timeout">Time to live for the object in milliseconds.</param>
        /// <returns>
        /// Cached value or null if the value is not stored.
        /// </returns>
        public abstract Task<T> StoreAsync<T>(string correlationId, string key, T value, long timeout);
    }
}