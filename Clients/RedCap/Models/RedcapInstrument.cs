using Newtonsoft.Json;

namespace CDS.Clients.RedCap.Models
{
    /// <summary>
    /// Instrument in a redcap project
    /// </summary>
    public class RedcapInstrument
    {
        /// <summary>
        /// Name of the instrument
        /// </summary>
        [JsonProperty("instrument_name")]
        public string InstrumentName { get; set; }

        /// <summary>
        /// Label (display)
        /// </summary>
        [JsonProperty("instrument_label")]
        public string InstrumentLabel { get; set; }

    }
}
