#pragma checksum "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52c6594d4ed1fe2f2401273c01e90020c7820548"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Delete), @"mvc.1.0.view", @"/Views/Member/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Delete.cshtml", typeof(AspNetCore.Views_Member_Delete))]
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
#line 1 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\_ViewImports.cshtml"
using AzureCosmosDbExample;

#line default
#line hidden
#line 2 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\_ViewImports.cshtml"
using AzureCosmosDbExample.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52c6594d4ed1fe2f2401273c01e90020c7820548", @"/Views/Member/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a747970ee200879a20078a72b35e9bd644afbf1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AzureCosmosDbExample.Models.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(87, 70, true);
            WriteLiteral("\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n\r\n\r\n<ul>\r\n    <li>");
            EndContext();
            BeginContext(158, 36, false);
#line 12 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(194, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(210, 39, false);
#line 13 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
            EndContext();
            BeginContext(249, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(265, 37, false);
#line 14 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(302, 15, true);
            WriteLiteral("</li>\r\n    <li>");
            EndContext();
            BeginContext(318, 44, false);
#line 15 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
   Write(Html.DisplayFor(model => model.RegisterDate));

#line default
#line hidden
            EndContext();
            BeginContext(362, 18, true);
            WriteLiteral("</li>\r\n</ul>\r\n\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(415, 23, false);
#line 21 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(442, 123, true);
            WriteLiteral("    <div class=\"form-actions no-color\">\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
            EndContext();
            BeginContext(566, 40, false);
#line 25 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(606, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 27 "C:\Users\Sercan\source\repos\AzureCosmosDbExample\AzureCosmosDbExample\Views\Member\Delete.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AzureCosmosDbExample.Models.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
