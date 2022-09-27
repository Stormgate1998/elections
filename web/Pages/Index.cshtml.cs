using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using shared;
using Microsoft.EntityFrameworkCore;

namespace web.Pages
{
    public class IndexModel : PageModel
    {
        public bool IsOpen;
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration config;
        private readonly HttpClient http;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration config, HttpClient http)
        {
            _logger = logger;
            this.config = config;
            this.http = http;
        }

        public IEnumerable<Ballot>? Ballots { get; private set; }
        public async Task OnGet()
        {
            string apiHost = config["amazon"];
            string url = $"{apiHost}/api/election/1/isopen";
            var isOpen = await http.GetStringAsync(url);
            IsOpen = isOpen == "true";
            
            //Ballots = await http.GetFromJsonAsync<IEnumerable<Ballot>>(url);
        }

       /* public async Task OnPostAddItem()
        { 
        
        }


        public async Task OnPostDeleteItem()
        {

        }*/
        /*
         * Function here, uses api, runs 'test'.
         * 
         * In .cshtml, add thing from todo
         * https://elanderson.net/2019/12/new-razor-pages-application-backed-with-an-api/
         * Add "ContactsApi": "https://localhost:(?) to appsetting.json
         * 
         * <a asp page="Error"> go to error page</a>
         * 
         * add electioncontroller
         * add ballotcontroller
         * Use book information
         * 
         * public async Task OnPostCloseBallots() 
         * {
         * _logger.LogInFormatin("Someone wants to close ballots");
         * await apiService.CloseBallotingAsync();
         * }
         * 
         * in APIService
         * internal async Task CloseBallotingAsync()
         * {
         * string url = "api line
         * await http.PostAsync(url, null);
         * }
         * 
         * Add electioncontroller
         * use 4 pages?
         * if closed, don't show the html for links?
         * makes it easier possibly?
         */


    }
}