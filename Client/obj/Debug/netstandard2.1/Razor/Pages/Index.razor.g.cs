#pragma checksum "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbfe04c42d82659cee22099b531faeab840fad07"
// <auto-generated/>
#pragma warning disable 1591
namespace TeamRedFrontEnd.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using TeamRedFrontEnd.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\_Imports.razor"
using TeamRedFrontEnd.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Lediga Objekt</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
 if (HouseObjects == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 9 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
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
#line 14 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
             foreach (var s in HouseObjects)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "p-2");
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card");
            __builder.AddAttribute(17, "style", "width:300px; height: 300px; border: 1px solid #21211f;");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-body text-dark cards");
            __builder.AddMarkupContent(21, "\r\n                            ");
            __builder.OpenElement(22, "h4");
            __builder.AddAttribute(23, "class", "card-title");
            __builder.AddContent(24, 
#nullable restore
#line 19 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
                                                    s.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(25, " - ");
            __builder.AddContent(26, 
#nullable restore
#line 19 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
                                                               s.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "p");
            __builder.AddContent(29, "Adress: ");
            __builder.AddContent(30, 
#nullable restore
#line 20 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
                                        s.Address

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(31, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, "Type: ");
            __builder.AddContent(35, 
#nullable restore
#line 21 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
                                      s.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                            ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, "Description: ");
            __builder.AddContent(39, 
#nullable restore
#line 22 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
                                             s.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 26 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(44, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
#nullable restore
#line 29 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Admin\source\repos\AspNet 2 Projekt\TeamRedFrontEnd\Client\Pages\Index.razor"
       


    private RealEstate[] HouseObjects;
    protected override async Task OnInitializedAsync() =>
        HouseObjects = await Http.GetFromJsonAsync<RealEstate[]>("http://localhost:5000/api/RealEstates");

    public class RealEstate
    {
        private DateTime time;
        public int Id { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public int RentingPrice { get; set; }
        public int PurchasePrice { get; set; }
        public bool CanBeRented { get; set; }
        public bool CanBePurchased { get; set; }
        public string Contact { get; set; }
        public string ConstructionYear { get; set; }
        public DateTimeOffset adCreated { get; set; }
        //public User Creator { get; set; }
        public int UserId { get; set; }

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
