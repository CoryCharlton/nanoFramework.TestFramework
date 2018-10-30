﻿//
// Copyright (c) 2018 The nanoFramework project contributors
// Portions Copyright (c) Microsoft Corporation.  All rights reserved.
// See LICENSE file in the project root for full license information.
//

namespace nanoFramework.TestPlatform.MSTest.TestAdapter.Utilities
{
    using System;
    using System.Security.Policy;

    /// <summary>
    /// This interface is an abstraction over the AppDomain APIs
    /// </summary>
    internal interface IAppDomain
    {
        /// <summary>
        /// Unloads the specified application domain.
        /// </summary>
        /// <param name="appDomain">An application domain to unload.</param>
        void Unload(AppDomain appDomain);

        /// <summary>
        /// Creates a new application domain using the specified name, evidence, and application domain setup information.
        /// </summary>
        /// <param name="friendlyName">The friendly name of the domain.</param>
        /// <param name="securityInfo">Evidence that establishes the identity of the code that runs in the application domain. Pass null to use the evidence of the current application domain.</param>
        /// <param name="info">An object that contains application domain initialization information.</param>
        /// <returns>The newly created application domain.</returns>
        AppDomain CreateDomain(
            string friendlyName,
            Evidence securityInfo,
            AppDomainSetup info);
    }
}
