#pragma checksum "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85ce649c091ef6477225415cad2a11b2fca689f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85ce649c091ef6477225415cad2a11b2fca689f9", @"/Pages/Index.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<h2>");
#nullable restore
#line 14 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
Write(DateTime.Now.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<h2>");
#nullable restore
#line 15 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
Write(DateTime.Now.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Cash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Checking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Savings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n\r\n    </thead>\r\n    <tbody>\r\n\r\n   \r\n\r\n");
#nullable restore
#line 40 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
         foreach (var item in Model.Fund)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Checking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Savings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinanceApp.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinanceApp.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FinanceApp.Pages.IndexModel>)PageContext?.ViewData;
        public FinanceApp.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
