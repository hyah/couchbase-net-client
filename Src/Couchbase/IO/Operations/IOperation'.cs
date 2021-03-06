﻿using System;
using Couchbase.Configuration.Server.Serialization;
using Couchbase.Core.Transcoders;

namespace Couchbase.IO.Operations
{
    internal interface IOperation<out T> : IOperation
    {
        Couchbase.IOperationResult<T> GetResultWithValue();

        ITypeTranscoder Transcoder { get; }

        T GetValue();
    }
}