using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.Pages.Shared
{
    public class ContactModel : PageModel
    {
        public bool hasData = false;
        public string lname { get; set; }
        public string fname { get; set; }
        public string message { get; set; }

        public void OnGet()
        {
        }
        public void OnPost()
        {

            hasData = true;
            fname = Request.Form["fname"];
            lname = Request.Form["lname"];
            message = Request.Form["message"];

        }
    }
}
