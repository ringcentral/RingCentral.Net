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
            var group = headers.GetValues("X-Rate-Limit-Group").FirstOrDefault();
            if (group == default(string))
            {
                return; // there is no X-Rate-Limit-Group header
            }

            group = group.ToLower();

            if (!rateLimits.ContainsKey(group))
            {
                return; // unknown group
            }

            RateLimit rateLimit = rateLimits[group];
            var limit = headers.GetValues("X-Rate-Limit-Limit").FirstOrDefault();
            if (limit != default(string))
            {
                rateLimit.limit = int.Parse(limit);
            }

            var remaining = headers.GetValues("X-Rate-Limit-Remaining").FirstOrDefault();
            if (remaining != default(string))
            {
                rateLimit.remaining = int.Parse(remaining);
            }

            var window = headers.GetValues("X-Rate-Limit-Window").FirstOrDefault();
            if (window != default(string))
            {
                rateLimit.window = int.Parse(window);
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