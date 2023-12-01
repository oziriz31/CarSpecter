using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CarSpecter.ViewModels
{
    public class SearchPageViewModel
    {
        [Required(ErrorMessage = "The search term(s) or keyword(s) sis required.")]
        [Display(Name = "Type your keywords here")]
        public string Term { get; set; }
         
        [Display(Name = "Manufacturer:")]
        public string? Manufacturer { get; set; }

        [DisplayName("Model year:")]
        public int? ModelYear { get; set; }

        [Display(Name = "Search for:")]
        public SearchForEnum SearchFor { get; set; } = SearchForEnum.DecodeVin;

        [Display(Name = "Result type:")]
        public ResultTypeEnum ResultType { get; set; } = ResultTypeEnum.JSON;

    }

    public enum SearchForEnum
    {
        None = 0,
        DecodeVin = 1,
        DecodeVinValue = 2
    }

    public enum ResultTypeEnum
    {
        JSON = 1,
        CSV = 2, 
        XML = 3
    }
}
