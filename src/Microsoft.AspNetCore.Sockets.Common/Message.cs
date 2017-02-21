// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Sockets
{
    public struct Message
    {
        public bool EndOfMessage { get; }
        public MessageType Type { get; }
        public byte[] Payload { get; }

        public Message(byte[] payload, MessageType type)
            : this(payload, type, endOfMessage: true)
        {

        }

        public Message(byte[] payload, MessageType type, bool endOfMessage)
        {
            Type = type;
            EndOfMessage = endOfMessage;
            Payload = payload;
        }
    }
}
