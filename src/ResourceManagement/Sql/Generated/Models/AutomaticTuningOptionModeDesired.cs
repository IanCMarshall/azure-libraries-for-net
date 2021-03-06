// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for AutomaticTuningOptionModeDesired.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutomaticTuningOptionModeDesired
    {
        [EnumMember(Value = "Off")]
        Off,
        [EnumMember(Value = "On")]
        On,
        [EnumMember(Value = "Default")]
        Default
    }
    internal static class AutomaticTuningOptionModeDesiredEnumExtension
    {
        internal static string ToSerializedValue(this AutomaticTuningOptionModeDesired? value)
        {
            return value == null ? null : ((AutomaticTuningOptionModeDesired)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this AutomaticTuningOptionModeDesired value)
        {
            switch( value )
            {
                case AutomaticTuningOptionModeDesired.Off:
                    return "Off";
                case AutomaticTuningOptionModeDesired.On:
                    return "On";
                case AutomaticTuningOptionModeDesired.Default:
                    return "Default";
            }
            return null;
        }

        internal static AutomaticTuningOptionModeDesired? ParseAutomaticTuningOptionModeDesired(this string value)
        {
            switch( value )
            {
                case "Off":
                    return AutomaticTuningOptionModeDesired.Off;
                case "On":
                    return AutomaticTuningOptionModeDesired.On;
                case "Default":
                    return AutomaticTuningOptionModeDesired.Default;
            }
            return null;
        }
    }
}
