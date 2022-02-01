﻿using System;

namespace EventLoggerConnector
{
    public class Message
    {
        public int Id { get; internal set; }
        public Guid EventClass { get; internal set; }
        public uint EventId { get; internal set; }
        public string Text { get; internal set; }
        public DateTime Time { get; internal set; }
        public uint SourceId { get; internal set; }
        public string SourceName { get; internal set; }
    }
}