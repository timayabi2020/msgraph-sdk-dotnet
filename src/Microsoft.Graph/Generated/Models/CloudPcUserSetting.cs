// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class CloudPcUserSetting : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the set of Microsoft 365 groups and security groups in Microsoft Entra ID that have cloudPCUserSetting assigned. Returned only on $expand. For an example, see Get cloudPcUserSetting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CloudPcUserSettingAssignment>? Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcUserSettingAssignment>?>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CloudPcUserSettingAssignment> Assignments
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CloudPcUserSettingAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
#endif
        /// <summary>The date and time when the setting was created. The timestamp type represents the date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The setting name displayed in the user interface.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The date and time when the setting was last modified. The timestamp type represents the date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>Indicates whether the local admin option is enabled. The default value is false. To enable the local admin option, change the setting to true. If the local admin option is enabled, the end user can be an admin of the Cloud PC device.</summary>
        public bool? LocalAdminEnabled
        {
            get { return BackingStore?.Get<bool?>("localAdminEnabled"); }
            set { BackingStore?.Set("localAdminEnabled", value); }
        }
        /// <summary>Indicates whether an end user is allowed to reset their Cloud PC. When true, the user is allowed to reset their Cloud PC. When false, end-user initiated reset is not allowed. The default value is false.</summary>
        public bool? ResetEnabled
        {
            get { return BackingStore?.Get<bool?>("resetEnabled"); }
            set { BackingStore?.Set("resetEnabled", value); }
        }
        /// <summary>Defines how frequently a restore point is created that is, a snapshot is taken) for users&apos; provisioned Cloud PCs (default is 12 hours), and whether the user is allowed to restore their own Cloud PCs to a backup made at a specific point in time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.CloudPcRestorePointSetting? RestorePointSetting
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CloudPcRestorePointSetting?>("restorePointSetting"); }
            set { BackingStore?.Set("restorePointSetting", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.CloudPcRestorePointSetting RestorePointSetting
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.CloudPcRestorePointSetting>("restorePointSetting"); }
            set { BackingStore?.Set("restorePointSetting", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.CloudPcUserSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.CloudPcUserSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.CloudPcUserSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignments", n => { Assignments = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcUserSettingAssignment>(Microsoft.Graph.Models.CloudPcUserSettingAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "localAdminEnabled", n => { LocalAdminEnabled = n.GetBoolValue(); } },
                { "resetEnabled", n => { ResetEnabled = n.GetBoolValue(); } },
                { "restorePointSetting", n => { RestorePointSetting = n.GetObjectValue<Microsoft.Graph.Models.CloudPcRestorePointSetting>(Microsoft.Graph.Models.CloudPcRestorePointSetting.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CloudPcUserSettingAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteBoolValue("localAdminEnabled", LocalAdminEnabled);
            writer.WriteBoolValue("resetEnabled", ResetEnabled);
            writer.WriteObjectValue<Microsoft.Graph.Models.CloudPcRestorePointSetting>("restorePointSetting", RestorePointSetting);
        }
    }
}
