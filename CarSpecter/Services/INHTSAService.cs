using CarSpecter.Dtos.VehicleMakes;
using CarSpecter.Dtos.VehicleVin;

namespace CarSpecter.Services
{
    public interface INHTSAService
    {

        string SearchCriteria { get; set; }
        string Message { get; set; }

        /// <summary>
        /// Get All Makes
        /// This provides a list of all the Makes available in vPIC Dataset.
        /// </summary> 
        /// <param name="format">Api result format (default: json)</param>
        /// <returns>List of vehicle makes</returns>
        Task<IEnumerable<AllVehicleMakeItemDto>?> GetAllMakesAsync(string? format = null);

        /// <summary>
        /// Decode VIN
        /// The Decode VIN API will decode the VIN and the decoded output will be made available in the format of Key-value pairs.
        /// The IDs (VariableID and ValueID) represent the unique ID associated with the Variable/Value.
        /// In case of text variables, the ValueID is not applicable.
        /// Model Year in the request allows for the decoding to specifically be done in the current, or older (pre-1980), model year ranges.
        /// It is recommended to always send in the model year.
        /// This API also supports partial VIN decoding(VINs that are less than 17 characters). 
        /// In this case, the VIN will be decoded partially with the available characters. 
        /// In case of partial VINs, a "*" could be used to indicate the unavailable characters. 
        /// The 9th digit is not necessary.
        /// </summary>
        /// <param name="vin">VIN term</param>
        /// <param name="modelYear">VIN year model</param>
        /// <param name="format">Api result format (default: json)</param>
        /// <returns></returns>
        Task<IEnumerable<DecodeVinItemResponseDto>> DecodeVin(string vin, int? modelYear = null, string? format = null);

        /// <summary> 
        /// Decode VIN (flat format)
        /// The Decode VIN Flat Format API will decode the VIN and the decoded output will be made available in a flat file format. 
        /// Model Year in the request allows for the decoding to specifically be done in the current, or older (pre-1980), model year ranges. 
        /// It is recommended to always send in the model year. 
        /// This API also supports partial VIN decoding (VINs that are less than 17 characters). 
        /// In this case, the VIN will be decoded partially with the available characters. 
        /// In case of partial VINs, a "*" could be used to indicate the unavailable characters.
        /// </summary>
        /// <param name="vin">VIN term</param>
        /// <param name="modelYear">VIN year model</param>
        /// <param name="format">Api result format (default: json)</param>
        /// <returns></returns>
        Task<IEnumerable<DecodeVinValuesItemResponseDto>> DecodeVinValues(string vin, int? modelYear = null, string? format = null);
    }
}
