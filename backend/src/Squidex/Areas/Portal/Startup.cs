﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschraenkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using Squidex.Areas.Portal.Middlewares;
using Squidex.Web;

namespace Squidex.Areas.Portal
{
    public static class Startup
    {
        public static void ConfigurePortal(this IApplicationBuilder app)
        {
            app.Map(Constants.PrefixPortal, builder =>
            {
                builder.UseAuthentication();
                builder.UseAuthorization();

                builder.UseMiddleware<PortalDashboardAuthenticationMiddleware>();
                builder.UseMiddleware<PortalRedirectMiddleware>();
            });
        }
    }
}
