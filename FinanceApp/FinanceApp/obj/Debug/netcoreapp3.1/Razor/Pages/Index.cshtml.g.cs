#pragma checksum "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "397e2dd57c8420b8b13d23a062d3b0e2d5f4cb5e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"397e2dd57c8420b8b13d23a062d3b0e2d5f4cb5e", @"/Pages/Index.cshtml")]
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
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Cash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Checking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Savings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fund[0].Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
 foreach (var item in Model.Fund) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cash));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Checking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Savings));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Credit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1192, "\"", 1220, 1);
#nullable restore
#line 47 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
WriteAttributeValue("", 1207, item.IdFunds, 1207, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1273, "\"", 1301, 1);
#nullable restore
#line 48 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
WriteAttributeValue("", 1288, item.IdFunds, 1288, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1356, "\"", 1384, 1);
#nullable restore
#line 49 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
WriteAttributeValue("", 1371, item.IdFunds, 1371, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Chris\source\repos\Finance-App\FinanceApp\FinanceApp\Pages\Index.cshtml"
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
