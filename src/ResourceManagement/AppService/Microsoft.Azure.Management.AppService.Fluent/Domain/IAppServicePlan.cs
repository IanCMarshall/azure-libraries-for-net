// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.AppService.Fluent
{
    using AppServicePlan.Update;
    using Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;

    /// <summary>
    /// An immutable client-side representation of an Azure App Service Plan.
    /// </summary>
    public interface IAppServicePlan  :
        IGroupableResource<IAppServiceManager, AppServicePlanInner>,
        IHasName,
        IRefreshable<Microsoft.Azure.Management.AppService.Fluent.IAppServicePlan>,
        IUpdatable<AppServicePlan.Update.IUpdate>
    {
        /// <summary>
        /// Gets if apps assigned to this App Service Plan can be scaled independently.
        /// </summary>
        bool PerSiteScaling { get; }

        /// <summary>
        /// Gets number of web apps assigned to this App Service Plan.
        /// </summary>
        int NumberOfWebApps { get; }

        /// <summary>
        /// Gets maximum number of instances that can be assigned.
        /// </summary>
        int MaxInstances { get; }

        /// <summary>
        /// Gets maximum number of instances that can be assigned.
        /// </summary>
        int Capacity { get; }

        /// <summary>
        /// Gets the pricing tier information of the App Service Plan.
        /// </summary>
        Microsoft.Azure.Management.AppService.Fluent.AppServicePricingTier PricingTier { get; }
    }
}