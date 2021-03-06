﻿using System;

namespace Adnc.Infr.EasyCaching.Interceptor.Castle
{
    /// <summary>
    /// Easycaching able attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = true)]
    public class EasyCachingAbleAttribute : EasyCachingInterceptorAttribute
    {
        /// <summary>
        /// Gets or sets the expiration. The default value is 30 second.
        /// </summary>
        /// <value>The expiration.</value>
        public int Expiration { get; set; } = 30;

        /// <summary>
        /// The cache key
        /// </summary>
        public string CacheKey { get; set; }
    }     
}
