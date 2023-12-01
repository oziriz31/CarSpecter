using System.Text.Json.Serialization;

namespace CarSpecter.Dtos.VehicleMakes
{

    /// <summary>
    /// Get All Makes: /vehicles/GetAllMakes
    /// All verhicle list api endpoint response 
    /// </summary>
    public class AllVehicleMakesResponseDto
    {
        /// <summary>
        /// Number of vehicle in the Results list
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Server message
        /// </summary>
        public string Message { get; set; }

        public string SearchCriteria { get; set; }

        /// <summary>
        /// Vehicle make list send from NHTSA Vehicle API
        /// </summary>
        public List<AllVehicleMakeItemDto> Results { get; set; }
    } 

}
