using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Pages;

[IgnoreAntiforgeryToken(Order = 2000)]
public class MyModel : PageModel
{
	public IActionResult OnPost()
	{
		HttpContext.Items["SkipLayout"] = true;
		return Content("<div>Success! Your form was submitted.</div>", "text/html");
	}
}