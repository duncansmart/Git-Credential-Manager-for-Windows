﻿using System;
using System.Threading.Tasks;

namespace Microsoft.Alm.Authentication
{
    public interface IVsoAadAuthentication
    {
        bool InteractiveLogon(Uri targetUri, bool requestCompactToken);
        Task<bool> NoninteractiveLogonWithCredentials(Uri targetUri, Credential credentials, bool requestCompactToken);
        Task<bool> NoninteractiveLogon(Uri targetUri, bool requestCompactToken);
    }
}
