using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace RingCentral
{
    public class RateLimits
    {
        public RateLimit heavy;
        public RateLimit medium;
        public RateLimit light;
        public RateLimit auth;
        private Dictionary<string, RateLimit> rateLimits;

        public RateLimits()
        {
            heavy = new RateLimit("heavy");
            medium = new RateLimit("medium");
            light = new RateLimit("light");
            auth = new RateLimit("auth");
            rateLimits = new Dictionary<string, RateLimit>
            {
                {"heavy", heavy}, {"medium", medium}, {"light", light}, {"auth", auth}
            };
        }

        public void Update(HttpResponseHeaders headers)
        {
            if (!headers.Contains("X-Rate-Limit-Group"))
            {
                return;
            }

            var group = headers.GetValues("X-Rate-Limit-Group").First().ToLower();

            if (!rateLimits.ContainsKey(group))
            {
                return; // unknown group
            }

            var rateLimit = rateLimits[group];
            if (headers.Contains("X-Rate-Limit-Limit"))
            {
                rateLimit.limit = int.Parse(headers.GetValues("X-Rate-Limit-Limit").First());
            }

            if (headers.Contains("X-Rate-Limit-Remaining"))
            {
                rateLimit.remaining = int.Parse(headers.GetValues("X-Rate-Limit-Remaining").First());
            }

            if (headers.Contains("X-Rate-Limit-Window"))
            {
                rateLimit.window = int.Parse(headers.GetValues("X-Rate-Limit-Window").First());
            }

            rateLimit.updatedAt = DateTime.Now;
        }
    }

    public class RateLimit
    {
        public RateLimit(string group)
        {
            this.group = group;
        }

        public string group;
        public int? limit;
        public int? remaining;
        public int? window;
        public DateTime? updatedAt;
    }
}