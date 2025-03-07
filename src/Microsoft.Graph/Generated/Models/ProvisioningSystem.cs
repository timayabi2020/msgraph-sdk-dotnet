// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class ProvisioningSystem : Microsoft.Graph.Models.Identity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Details of the system.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DetailsInfo? Details
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DetailsInfo?>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DetailsInfo Details
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DetailsInfo>("details"); }
            set { BackingStore?.Set("details", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.ProvisioningSystem"/> and sets the default values.
        /// </summary>
        public ProvisioningSystem() : base()
        {
            OdataType = "#microsoft.graph.provisioningSystem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.ProvisioningSystem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.ProvisioningSystem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.ProvisioningSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "details", n => { Details = n.GetObjectValue<Microsoft.Graph.Models.DetailsInfo>(Microsoft.Graph.Models.DetailsInfo.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.DetailsInfo>("details", Details);
        }
    }
}
