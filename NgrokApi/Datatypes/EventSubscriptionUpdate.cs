using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class EventSubscriptionUpdate : HasId
    {
        // <summary>
        // Unique identifier for this Event Subscription.
        // </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
        // <summary>
        // Arbitrary customer supplied information intended to be machine readable.
        // Optional, max 4096 chars.
        // </summary>
        [JsonPropertyName("metadata")]
        public string Metadata { get; set; }
        // <summary>
        // Arbitrary customer supplied information intended to be human readable. Optional,
        // max 255 chars.
        // </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
        // <summary>
        // Sources containing the types for which this event subscription will trigger
        // </summary>
        [JsonPropertyName("sources")]
        public List<EventSourceReplace> Sources { get; set; }
        // <summary>
        // A list of Event Destination IDs which should be used for this Event Stream.
        // Event Streams are required to have at least one Event Destination.
        // </summary>
        [JsonPropertyName("destination_ids")]
        public List<string> DestinationIds { get; set; }

        public override string ToString()
        {
            return $"EventSubscriptionUpdate Id={ Id }  Metadata={ Metadata }  Description={ Description }  Sources={ Sources }  DestinationIds={ DestinationIds } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Id?.GetHashCode() ?? 0);

                hash = hash * 23 + (Metadata?.GetHashCode() ?? 0);

                hash = hash * 23 + (Description?.GetHashCode() ?? 0);

                hash = hash * 23 + (Sources?.GetHashCode() ?? 0);

                hash = hash * 23 + (DestinationIds?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (EventSubscriptionUpdate)obj;
            return (
                 this.Id == other.Id
                && this.Metadata == other.Metadata
                && this.Description == other.Description
                && this.Sources == other.Sources
                && this.DestinationIds == other.DestinationIds
            );
        }

    }
}
