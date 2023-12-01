namespace CarSpecter.Dtos.VehicleVin
{
    public class DecodeVinResponseDto
    {
        public int Count { get; set; }
        public string Message { get; set; }
        public string SearchCriteria { get; set; }
        public List<DecodeVinItemResponseDto> Results { get; set; }
    } 

}
