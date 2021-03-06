﻿using PipServices3.Commons.Errors;
using System;
using System.Collections.Generic;
using System.Text;

namespace PipServices3.Components.Trace
{
    /// <summary>
    /// Data object to store captured operation traces.
    /// This object is used by <see cref="CachedTracer"/>.
    /// </summary>
    public class OperationTrace
    {
		/// <summary>
		/// The time when operation was executed 
		/// </summary>
		public DateTime Time;

		/// <summary>
		/// The source (context name)
		/// </summary>
		public string Source;

		/// <summary>
		/// The name of component
		/// </summary>
		public string Component;

		/// <summary>
		/// The name of the executed operation
		/// </summary>
		public string Operation;

		/// <summary>
		/// The transaction id to trace execution through call chain.
		/// </summary>
		public string CorrelationId;

		/// <summary>
		/// The duration of the operation in milliseconds
		/// </summary>
		public long Duration;

		/// <summary>
		/// The description of the captured error
		/// See <a href="https://pip-services3-dotnet.github.io/pip-services3-commons-dotnet/class_pip_services3_1_1_commons_1_1_errors_1_1_error_description.html">ErrorDescription</a>, 
		/// <a href="https://pip-services3-dotnet.github.io/pip-services3-commons-dotnet/class_pip_services3_1_1_commons_1_1_errors_1_1_application_exception.html">ApplicationException </a>
		/// </summary>
		public ErrorDescription Error;
    }
}
