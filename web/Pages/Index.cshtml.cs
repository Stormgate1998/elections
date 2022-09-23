using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using shared;
using Microsoft.EntityFrameworkCore;

namespace web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //app.MapGet("/test", async (InstantRunoffContext context) => await context.Cities.ToListAsync());
        }


        /*
         * Function here, uses api, runs 'test'.
         * 
         * In .cshtml, add thing from todo
         * https://elanderson.net/2019/12/new-razor-pages-application-backed-with-an-api/
         * Add "ContactsApi": "https://localhost:(?) to appsetting.json
         * 
         * <a asp page="Error"> go to error page</a>
         */
    }
}