﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PipServices3.Components.Trace
{
    /// <summary>
    /// Interface for tracer components that capture operation traces.
    /// </summary>
    public interface ITracer
    {
        /// <summary>
        /// Records an operation trace with its name and duration
        /// </summary>
        /// <param name="correlationId">(optional) transaction id to trace execution through call chain.</param>
        /// <param name="component">a name of called component</param>
        /// <param name="operation">a name of the executed operation. </param>
        /// <param name="duration">execution duration in milliseconds.</param>
        void Trace(string correlationId, string component, string operation, long duration);

        /// <summary>
        /// Records an operation failure with its name, duration and error
        /// </summary>
        /// <param name="correlationId">(optional) transaction id to trace execution through call chain.</param>
        /// <param name="component">a name of called component</param>
        /// <param name="operation">a name of the executed operation. </param>
        /// <param name="error">an error object associated with this trace.</param>
        /// <param name="duration">execution duration in milliseconds. </param>
        void Failure(string correlationId, string component, string operation, Exception error, long duration);

        /// <summary>
        /// Begings recording an operation trace
        /// </summary>
        /// <param name="correlationId">(optional) transaction id to trace execution through call chain.</param>
        /// <param name="component">a name of called component</param>
        /// <param name="operation">a name of the executed operation. </param>
        /// <returns>a trace timing object.</returns>
        TraceTiming BeginTrace(string correlationId, string component, string operation);
    }
}
