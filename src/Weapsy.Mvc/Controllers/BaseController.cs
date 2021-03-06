﻿using Microsoft.AspNetCore.Mvc;
using System;
using Weapsy.Mvc.Context;
using Weapsy.Reporting.Pages;
using Weapsy.Reporting.Sites;

namespace Weapsy.Mvc.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly IContextService _contextService;

        public BaseController(IContextService contextService)
        {
            _contextService = contextService;
        }

        public ContextInfo ContextInfo => _contextService.GetCurrentContextInfo();
        public SiteInfo SiteInfo => ContextInfo.Site;
        public Guid SiteId => SiteInfo.Id;
        public PageInfo PageInfo => ContextInfo.Page;
    }
}
