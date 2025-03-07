// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class WorkbookChartAxes : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the category axis in a chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookChartAxis? CategoryAxis
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookChartAxis?>("categoryAxis"); }
            set { BackingStore?.Set("categoryAxis", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookChartAxis CategoryAxis
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookChartAxis>("categoryAxis"); }
            set { BackingStore?.Set("categoryAxis", value); }
        }
#endif
        /// <summary>Represents the series axis of a 3-dimensional chart. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookChartAxis? SeriesAxis
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookChartAxis?>("seriesAxis"); }
            set { BackingStore?.Set("seriesAxis", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookChartAxis SeriesAxis
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookChartAxis>("seriesAxis"); }
            set { BackingStore?.Set("seriesAxis", value); }
        }
#endif
        /// <summary>Represents the value axis in an axis. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.WorkbookChartAxis? ValueAxis
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookChartAxis?>("valueAxis"); }
            set { BackingStore?.Set("valueAxis", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.WorkbookChartAxis ValueAxis
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WorkbookChartAxis>("valueAxis"); }
            set { BackingStore?.Set("valueAxis", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.WorkbookChartAxes"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.WorkbookChartAxes CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.WorkbookChartAxes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "categoryAxis", n => { CategoryAxis = n.GetObjectValue<Microsoft.Graph.Models.WorkbookChartAxis>(Microsoft.Graph.Models.WorkbookChartAxis.CreateFromDiscriminatorValue); } },
                { "seriesAxis", n => { SeriesAxis = n.GetObjectValue<Microsoft.Graph.Models.WorkbookChartAxis>(Microsoft.Graph.Models.WorkbookChartAxis.CreateFromDiscriminatorValue); } },
                { "valueAxis", n => { ValueAxis = n.GetObjectValue<Microsoft.Graph.Models.WorkbookChartAxis>(Microsoft.Graph.Models.WorkbookChartAxis.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookChartAxis>("categoryAxis", CategoryAxis);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookChartAxis>("seriesAxis", SeriesAxis);
            writer.WriteObjectValue<Microsoft.Graph.Models.WorkbookChartAxis>("valueAxis", ValueAxis);
        }
    }
}
