// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace x00153302_CA3_EAD_Blazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using x00153302_CA3_EAD_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using x00153302_CA3_EAD_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\Pages\Counter.razor"
using Basketball_CA3_EAD.Classes;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\shuai\source\repos\x00153302 CA3 EAD Blazor\x00153302 CA3 EAD Blazor\Pages\Counter.razor"
       
    string strfeedback;
    private string player;
    private bool found;

    private Player data;

    private async Task ButtononClick()
    {
        try
        {
            data = await Http.GetFromJsonAsync<Player>("https://www.balldontlie.io/api/v1/players?search=" + player);
            found = true;
            strfeedback = String.Empty;
        }
        catch (Exception e)
        {
            found = false;
            strfeedback = e.Message;
        }
    }

    private Root root;
    private Player getnameandid;
    private string nameofplayer;
    private string season;
    int id;
    private Root statsdata;
    private bool foundstats;

    private async Task StatsButton()
    {
        getnameandid = await Http.GetFromJsonAsync<Player>("https://www.balldontlie.io/api/v1/players?search=" + nameofplayer);

        foreach (Player pl in getnameandid.data)
        {
            id = pl.id;
        }

        season = season;

        try
        {
            statsdata = await Http.GetFromJsonAsync<Root>("https://www.balldontlie.io/api/v1/season_averages?season=" + season + "&player_ids[]=" + id);
            foundstats = true;
            strfeedback = String.Empty;
        }
        catch (Exception e)
        {
            foundstats = false;
            strfeedback = e.Message;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
