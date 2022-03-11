using System.Text.Json.Serialization;

namespace NgrokApi
{
    public class AbuseReportHostname
    {
        // <summary>
        // the hostname ngrok has parsed out of one of the reported URLs in this abuse
        // report
        // </summary>
        [JsonPropertyName("hostname")]
        public string Hostname { get; set; }
        // <summary>
        // indicates what action ngrok has taken against the hostname. one of
        // <c>PENDING</c>, <c>BANNED</c>, <c>UNBANNED</c>, or <c>IGNORE</c>
        // </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        public override string ToString()
        {
            return $"AbuseReportHostname Hostname={ Hostname }  Status={ Status } ";
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Hostname?.GetHashCode() ?? 0);

                hash = hash * 23 + (Status?.GetHashCode() ?? 0);

                return hash;
            }
        }


        public override bool Equals(object obj)
        {
            var other = (AbuseReportHostname)obj;
            return (
                 this.Hostname == other.Hostname
                && this.Status == other.Status
            );
        }

    }
}
