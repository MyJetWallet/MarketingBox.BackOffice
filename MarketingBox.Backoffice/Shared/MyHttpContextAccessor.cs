﻿using Microsoft.AspNetCore.Http;

namespace MarketingBox.Backoffice.Shared
{
    public class MyHttpContextAccessor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MyHttpContextAccessor(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public HttpContext Context => _httpContextAccessor.HttpContext;
    }
}