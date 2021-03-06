﻿// Copyright (c) Source Tree Solutions, LLC. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.
// Author:					Joe Audette
// Created:					2015-07-22
// Last Modified:			2016-10-08
// 

using cloudscribe.Core.Models;
using System.Threading.Tasks;

namespace cloudscribe.Core.Web.Components.Messaging
{
    public interface ISiteMessageEmailSender
    {
        Task SendAccountConfirmationEmailAsync(
            ISiteContext siteSettings,
            string toAddress, 
            string subject, 
            string confirmationUrl);

        Task SendSecurityCodeEmailAsync(
            ISiteContext siteSettings,
            string toAddress,
            string subject,
            string securityCode);

        Task SendPasswordResetEmailAsync(
            ISiteContext siteSettings,
            string toAddress,
            string subject,
            string resetUrl);

        Task AccountPendingApprovalAdminNotification(
            ISiteContext siteSettings,
            ISiteUser user);

        Task SendAccountApprovalNotificationAsync(
            ISiteContext siteSettings,
            string toAddress,
            string subject,
            string loginUrl);
    }
}
