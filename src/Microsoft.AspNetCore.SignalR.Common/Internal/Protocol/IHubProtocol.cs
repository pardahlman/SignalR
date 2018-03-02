// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Buffers;
using Microsoft.AspNetCore.Sockets;

namespace Microsoft.AspNetCore.SignalR.Internal.Protocol
{
    public interface IHubProtocol
    {
        string Name { get; }
        TransferMode TransferMode { get; }

        bool TryParseMessage(ref ReadOnlyBuffer<byte> input, IInvocationBinder binder, out HubMessage message);
        void WriteMessage(IOutput output, HubMessage message);
    }
}
