using System.Text.Json.Serialization;

namespace CarSpecter.Dtos.VehicleMakes
{

    public class AllVehicleMakeItemDto
    {
        /// <summary>
        /// Vehicle make identifier
        /// </summary>
        [JsonPropertyName("Make_ID")]
        public int MakeID { get; set; }

        /// <summary>
        /// Verhicle name
        /// </summary>
        [JsonPropertyName("Make_Name")]
        public string Make_Name { get; set; }
    }
}
