// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Information about a VM from which a formula is to be created.
    /// </summary>
    public partial class FormulaPropertiesFromVmFragment
    {
        /// <summary>
        /// Initializes a new instance of the FormulaPropertiesFromVmFragment
        /// class.
        /// </summary>
        public FormulaPropertiesFromVmFragment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FormulaPropertiesFromVmFragment
        /// class.
        /// </summary>
        /// <param name="labVmId">The identifier of the VM from which a formula
        /// is to be created.</param>
        public FormulaPropertiesFromVmFragment(string labVmId = default(string))
        {
            LabVmId = labVmId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the identifier of the VM from which a formula is to be
        /// created.
        /// </summary>
        [JsonProperty(PropertyName = "labVmId")]
        public string LabVmId { get; set; }

    }
}
