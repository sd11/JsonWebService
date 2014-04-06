﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIProject.Models
{
    public class Payload
    {
        public string country { get; set; }
        public string description { get; set; }
        public Boolean drm { get; set; }
        public int episodeCount { get; set; }
        public string genre { get; set; }
        public Image image { get; set; }
        public string language { get; set; }
        public NextEpisode nextEpisode { get; set; }
        public string primaryColour { get; set; }
        public Seasons[] seasons { get; set; }
        public string slug { get; set; }
        public string title { get; set; }
        public string tvChannel { get; set; }
    }
}