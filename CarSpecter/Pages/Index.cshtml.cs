using CarSpecter.Dtos.VehicleVin;
using CarSpecter.Services;
using CarSpecter.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarSpecter.Pages
{
    public class IndexModel : PageModel
    {
        #region Properties

        private readonly ILogger<IndexModel> _logger;
        private readonly INHTSAService _iNHTSAService;

        [BindProperty]
        public SearchPageViewModel SearchForm { get; set; }

        public IEnumerable<DecodeVinItemResponseDto> VinResults { get; set; }
        public IEnumerable<DecodeVinValuesItemResponseDto> VinValuesResults { get; set; }

        #endregion

        #region Ctor

        public IndexModel(ILogger<IndexModel> logger,
            INHTSAService iNHTSAService)
        {
            _logger = logger;
            _iNHTSAService = iNHTSAService;
        }

        #endregion

        #region Methods

        public async Task OnGetAsync()
        {
            // var makes = await _iNHTSAService.GetAllMakesAsync();
            // var vins = await _iNHTSAService.DecodeVin("5UXWX7C5*BA", 2011);
            // var vinValues = await _iNHTSAService.DecodeVinValues("5UXWX7C5*BA", 2011);
        }

        public async Task<IActionResult> OnPostAsync() 
        {
            // Check if there are any validation errors
            if (ModelState.IsValid)
            { 
                switch(SearchForm.SearchFor)
                {
                    case SearchForEnum.DecodeVin:
                        this.VinResults = await _iNHTSAService.DecodeVin(
                            SearchForm.Term, 
                            SearchForm.ModelYear,
                            SearchForm.ResultType.ToString());

                        // Order list by alphabetic first letter
                        this.VinResults = this.VinResults
                            .OrderByDescending(x => x.Variable);

                        break;
                    case SearchForEnum.DecodeVinValue:
                        this.VinValuesResults = await _iNHTSAService.DecodeVinValues(
                            SearchForm.Term,
                            SearchForm.ModelYear,
                            SearchForm.ResultType.ToString())
                            ;
                        break;
                }

                ViewData["SearchCriteria"] = _iNHTSAService.SearchCriteria;
                ViewData["Message"] = _iNHTSAService.Message;
            }

            return Page();
        }   

        #endregion
    }
}