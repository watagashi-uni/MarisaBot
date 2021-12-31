﻿using System.Threading.Tasks.Dataflow;
using QQBot.MiraiHttp.Entity;

namespace QQBot.MiraiHttp.DI;

using MessageRecvQueue = BufferBlock<Message>;
using MessageSendQueue = BufferBlock<(MessageChain message, MiraiMessageType mType, long target, long? groupId, long? quote)>;

public class MessageQueueProvider
{
    public readonly MessageRecvQueue RecvQueue = new();
    public readonly MessageSendQueue SendQueue = new();
}
