#pragma checksum "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "edf3cde38245bfe4164e64431d6a18608015eec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MadMenu_Bestilling), @"mvc.1.0.view", @"/Views/MadMenu/Bestilling.cshtml")]
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
#line 1 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\_ViewImports.cshtml"
using Madbestilling;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\_ViewImports.cshtml"
using Madbestilling.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edf3cde38245bfe4164e64431d6a18608015eec3", @"/Views/MadMenu/Bestilling.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ebdbd927947f4f5adb284202aa9c7aaabdb7d6", @"/Views/_ViewImports.cshtml")]
    public class Views_MadMenu_Bestilling : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcMadMenu.Models.MadMenu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"
  
    ViewData["Title"] = "Bestilling";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    <div class=\"text-center\">\r\n        <hr class=\"new1\">\r\n        <h1 class=\"display-4\">Menu og bestillinger</h1>\r\n        <hr class=\"new2\">\r\n        <br>\r\n    </div>\r\n\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 18 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"
             foreach (var item in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-12 col-md-6 col-lg-5 col-xl-4\">\r\n\r\n\r\n                    <div class=\"card bg-light mb-3\" style=\"max-width: 20rem; height: 15rem;\">\r\n                        <div class=\"card-header\"><font color=\"black\"><b>");
#nullable restore
#line 25 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"
                                                                   Write(Html.DisplayFor(modelItem => item.UgeNavn));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 25 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"
                                                                                                               Write(Html.DisplayFor(modelItem => item.Dato));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></font></div>\r\n                        <div class=\"card-body\">\r\n                            <h6 class=\"card-title\"><font color=\"black\">");
#nullable restore
#line 27 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"
                                                                  Write(Html.DisplayFor(modelItem => item.Menu));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</font></h6>
                            <font color=""black"">Antal:</font>
                            <input type=""number"" value=""0"" min=""0"" max=""15"">
                            <button class=""button2"">BEKRÆFT ANTAL</button>
                            <p><font color=""black"">15 Menuer tilbage</font></p>
                        </div>
                    </div>

                </div>
");
#nullable restore
#line 36 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"


            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n        </div>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\Bestilling.cshtml"
                  await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcMadMenu.Models.MadMenu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
