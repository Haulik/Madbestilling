#pragma checksum "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f51d1f7cc37afb6b1a7ed94949d3cc0e257077dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MadMenu_MineBestillinger), @"mvc.1.0.view", @"/Views/MadMenu/MineBestillinger.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f51d1f7cc37afb6b1a7ed94949d3cc0e257077dc", @"/Views/MadMenu/MineBestillinger.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9ebdbd927947f4f5adb284202aa9c7aaabdb7d6", @"/Views/_ViewImports.cshtml")]
    public class Views_MadMenu_MineBestillinger : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcMadMenu.Models.MadMenu>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
  
    ViewData["Title"] = "MineBestillinger";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    

<div class=""text-center"">
        <hr class=""new1"">
        <h1 class=""display-4"">Mine Bestillinger</h1>
        <hr class=""new2"">
        <br>
</div>
    <table class=""table"">

        <thead>
            <tr>
                <th>
                    ");
#nullable restore
#line 19 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
               Write(Html.DisplayNameFor(model => model.Dato));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </th>
                <th>
                    Mad
                </th>
                <th>
                    Antal
                </th>
                
               
            </tr>
        </thead>
        
        <tbody>
");
#nullable restore
#line 33 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
             foreach (var item in Model)
            {

                



#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
                   Write(Html.DisplayFor(modelItem => item.UgeNavn));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.Dato));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Med_Hjem_Køkken));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Uge));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 53 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\thoma\source\repos\Madbestilling\Madbestilling\Views\MadMenu\MineBestillinger.cshtml"
              await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
                WriteLiteral("        ");
            }
            );
            WriteLiteral("    </table>");
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
