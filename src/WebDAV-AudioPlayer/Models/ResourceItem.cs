﻿using System;
using System.Collections.Generic;
using System.IO;
using WebDav.AudioPlayer.Audio;

namespace WebDav.AudioPlayer.Models
{
    public class ResourceItem
    {
        public Guid Id { get; set; }

        public int Level { get; set; }

        public MediaDetails MediaDetails { get; set; }

        public string DisplayName { get; set; }

        public Uri FullPath { get; set; }

        public string Extension { get; set; }

        public bool IsCollection { get; set; }

        public long? ContentLength { get; set; }

        public Stream Stream { get; set; }

        public ResourceItem Parent { get; set; }

        public List<ResourceItem> Items { get; set; }
    }
}