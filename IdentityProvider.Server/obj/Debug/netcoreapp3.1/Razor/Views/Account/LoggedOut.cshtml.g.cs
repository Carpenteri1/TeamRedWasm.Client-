#pragma checksum "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bb84ebf8ff1f7762cc16c7d934127578faca537"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_LoggedOut), @"mvc.1.0.view", @"/Views/Account/LoggedOut.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bb84ebf8ff1f7762cc16c7d934127578faca537", @"/Views/Account/LoggedOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bec599faa2156b5976535a194fedf34093459faa", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_LoggedOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoggedOutViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
   
    // set this so the layout rendering sees an anonymous user
    ViewData["signed-out"] = true;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"logged-out-page\">\n    <h1>\n        Logout\n        <small>You are now logged out</small>\n    </h1>\n\n");
#nullable restore
#line 14 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
     if (Model.PostLogoutRedirectUri != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\n            Click <a class=\"PostLogoutRedirectUri\"");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 394, 1);
#nullable restore
#line 17 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 366, Model.PostLogoutRedirectUri, 366, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">here</a> to return to the\n            <span>");
#nullable restore
#line 18 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
             Write(Model.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> application.\n        </div>\n");
#nullable restore
#line 20 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
     if (Model.SignOutIframeUrl != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <iframe width=\"0\" height=\"0\" class=\"signout\"");
            BeginWriteAttribute("src", " src=\"", 599, "\"", 628, 1);
#nullable restore
#line 24 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
WriteAttributeValue("", 605, Model.SignOutIframeUrl, 605, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></iframe>\n");
#nullable restore
#line 25 "C:\Users\Admin\source\repos\AspNetProjekt\OfficialSolution\TeamRedBlazor.Server\IdentityProvider.Server\Views\Account\LoggedOut.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoggedOutViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
