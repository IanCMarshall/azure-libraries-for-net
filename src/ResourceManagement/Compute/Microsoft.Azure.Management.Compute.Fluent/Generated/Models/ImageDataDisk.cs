// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Azure;
    using Management;
    using Compute;
    using Fluent;
    using Rest;
    using Rest.Azure;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes a data disk.
    /// </summary>
    public partial class ImageDataDisk
    {
        /// <summary>
        /// Initializes a new instance of the ImageDataDisk class.
        /// </summary>
        public ImageDataDisk() { }

        /// <summary>
        /// Initializes a new instance of the ImageDataDisk class.
        /// </summary>
        /// <param name="lun">The logical unit number.</param>
        /// <param name="snapshot">The snapshot.</param>
        /// <param name="managedDisk">The managedDisk.</param>
        /// <param name="blobUri">The Virtual Hard Disk.</param>
        /// <param name="caching">The caching type. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="diskSizeGB">The initial disk size in GB for blank data
        /// disks, and the new desired size for existing OS and Data
        /// disks.</param>
        public ImageDataDisk(int lun, Microsoft.Azure.Management.ResourceManager.Fluent.SubResource snapshot = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), Microsoft.Azure.Management.ResourceManager.Fluent.SubResource managedDisk = default(Microsoft.Azure.Management.ResourceManager.Fluent.SubResource), string blobUri = default(string), CachingTypes? caching = default(CachingTypes?), int? diskSizeGB = default(int?))
        {
            Lun = lun;
            Snapshot = snapshot;
            ManagedDisk = managedDisk;
            BlobUri = blobUri;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
        }

        /// <summary>
        /// Gets or sets the logical unit number.
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int Lun { get; set; }

        /// <summary>
        /// Gets or sets the snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "snapshot")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource Snapshot { get; set; }

        /// <summary>
        /// Gets or sets the managedDisk.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public Microsoft.Azure.Management.ResourceManager.Fluent.SubResource ManagedDisk { get; set; }

        /// <summary>
        /// Gets or sets the Virtual Hard Disk.
        /// </summary>
        [JsonProperty(PropertyName = "blobUri")]
        public string BlobUri { get; set; }

        /// <summary>
        /// Gets or sets the caching type. Possible values include: 'None',
        /// 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets the initial disk size in GB for blank data disks, and
        /// the new desired size for existing OS and Data disks.
        /// </summary>
        [JsonProperty(PropertyName = "diskSizeGB")]
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}

