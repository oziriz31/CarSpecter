using System.Text.Json.Serialization;

namespace CarSpecter.Dtos.VehicleVin
{

    /// <summary>
    /// Decode VIN : /vehicles/DecodeVin/5UXWX7C5*BA?format=xml&modelyear=2011
    /// Decode VIN list api endpoint response 
    /// </summary>
    public class DecodeVinValuessResponseDto
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public List<DecodeVinValuesItemResponseDto> Results { get; set; }
    } 

}
