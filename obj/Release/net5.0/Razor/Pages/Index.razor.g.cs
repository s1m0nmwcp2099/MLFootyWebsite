#pragma checksum "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0234f7c0c542d124989dce326296ffcf0b0f368"
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
#nullable restore
#line 2 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
using MLFootyWebsite.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Result probabilities</h1>");
#nullable restore
#line 7 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
 if (matchFixtures == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p>Loading...</p>");
#nullable restore
#line 10 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-striped");
            __builder.AddMarkupContent(4, @"<thead><tr><th>League</th>
                <th>Date</th>
                <th>Home team</th>
                <th>Away team</th>
                <th>Home prob</th>
                <th>Draw prob</th>
                <th>Away prob</th></tr></thead>
        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 26 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
             foreach (var fx in matchFixtures)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 29 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxLeague

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 30 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 31 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxHomeTeam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxAwayTeam

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxHomeProb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 34 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxDrawProb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 35 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
                         fx.FxAwayProb

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/home/simon/GithubRepo/MLFootyWebsite/Pages/Index.razor"
      
    public List<Fixture> matchFixtures = new List<Fixture>();
    private List<Fixture> ReadCsvFx(){
        matchFixtures = FixtureService.GetPredFixtures();
        return matchFixtures;
    }
    protected override void OnInitialized(){
        ReadCsvFx();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private FixtureService FixtureService { get; set; }
    }
}
#pragma warning restore 1591
