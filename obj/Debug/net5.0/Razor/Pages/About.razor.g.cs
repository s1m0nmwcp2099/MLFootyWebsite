#pragma checksum "/home/simon/GithubRepo/MLFootyWebsite/Pages/About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "648f861426e6fb6849e074b50f694949e55724f9"
// <auto-generated/>
#pragma warning disable 1591
namespace MLFootyWebsite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using MLFootyWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/simon/GithubRepo/MLFootyWebsite/_Imports.razor"
using MLFootyWebsite.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>About this website</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>\n    This website uses a basic machine learning model to predict the probability of results and over/under \n    2.5 goals for matches in major European leagues.\n</p>\n");
            __builder.AddMarkupContent(2, @"<p>
    Data for previous matches has been taken from <a href=""http://football-data.co.uk/"" target=""_blank"">football-data.co.uk</a> 
    The prediction model uses goals, shots and shots on target from each team's previous matches separated by home and away form.
    It also utilises time regression. This means that statistics from more recent matches carry more weight than earlier matches.
</p>
");
            __builder.AddMarkupContent(3, "<p>\n    In the future I hope to develop more accurate predictions based on more sophisticated statistics and machine learning \n    techniques.\n</p>\n\n");
            __builder.AddMarkupContent(4, "<h1>About me</h1>\n");
            __builder.AddMarkupContent(5, "<p>\n    I\'m a self-taught developer with knowledge of C#, dotnet, Python, MySQL, Blazor, Azure and more\n</p>\n");
            __builder.AddMarkupContent(6, "<p>Simon Horton</p>\n");
            __builder.AddMarkupContent(7, "<p><a href=\"https://www.linkedin.com/in/simon-horton-45383619b/\" target=\"_blank\">Linked In profile</a></p>\n");
            __builder.AddMarkupContent(8, "<p><a href=\"https://github.com/s1m0nmwcp2099/portfolio\" target=\"_blank\">Github portfolio</a></p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591