#pragma checksum "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a82ea24f3e7705df77923bb5239e7bbcf838d1"
// <auto-generated/>
#pragma warning disable 1591
namespace TeamRedBlazor.Client.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using TeamRedBlazor.Client.Server.Data.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Http.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RealEstates")]
    public partial class RealEstates : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>RealEstates</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
 if (RealEstatesArray == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "d-flex flex-wrap");
            __builder.AddAttribute(9, "style", "justify-content: center;");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
             foreach (var objectData in RealEstatesArray)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "p-2");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "card");
            __builder.AddAttribute(17, "onclick", "location.href=\'/counter\'");
            __builder.AddAttribute(18, "style", "width:250px; height: 250px; border: 1px solid #21211f;");
            __builder.AddMarkupContent(19, "\r\n                        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body text-dark cards");
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "h4");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, 
#nullable restore
#line 19 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
                                                    objectData.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                            ");
            __builder.OpenElement(27, "p");
            __builder.AddContent(28, "Can it be purchesed: ");
            __builder.AddContent(29, 
#nullable restore
#line 20 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
                                                     objectData.CanBePurchased

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                            ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, ":Purches Price: ");
            __builder.AddContent(33, 
#nullable restore
#line 21 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
                                                objectData.PurchasePrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, "Can be rented: ");
            __builder.AddContent(37, 
#nullable restore
#line 22 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
                                               objectData.CanBeRented

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.OpenElement(39, "p");
            __builder.AddContent(40, "Rent Price: ");
            __builder.AddContent(41, 
#nullable restore
#line 23 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
                                            objectData.RentingPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\Blazor.Client.Server\Pages\RealEstates.razor"
       

    private RealEstateModel[] RealEstatesArray;

    protected override async Task OnInitializedAsync()
    {
        RealEstatesArray = await Service.GetRealEstateAsync();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RealEstateService Service { get; set; }
    }
}
#pragma warning restore 1591
