#pragma checksum "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b87a860654e1ff85bfafec284de71d5aacc9f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(qadi.Views.Home.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(qadi.Views.Home.Views_Home_Index))]
namespace qadi.Views.Home
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
using qadi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b87a860654e1ff85bfafec284de71d5aacc9f0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0092a6fce646c4c8c5e1681d41699916b2004c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DeviceViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 8, true);
            WriteLiteral("\n<html>\n");
            EndContext();
            BeginContext(50, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2e91b23da5749568d250e24cef81e31", async() => {
                BeginContext(56, 78, true);
                WriteLiteral("\n    <title>Inventory</title>\n    <link href=\"/style.css\" rel=\"stylesheet\" />\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(141, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(143, 2246, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1fce5998845a4c2b886837cbf8453e02", async() => {
                BeginContext(149, 255, true);
                WriteLiteral("\n    <input type=\"submit\" onclick=location.href=\"/CiCo/Prologue\" value=\"In-and-Out Portal\" />\n    <input type=\"submit\" onclick=location.href=\"/User/UserList\" value=\"User List\" /><br /><br />\n    <table style=\"width:100%\">\n        <thead>\n            <tr>\n");
                EndContext();
                BeginContext(436, 310, true);
                WriteLiteral(@"                <th>Device ID</th>
                <th>Serial No.</th>
                <th>Make</th>
                <th>Model</th>
                <th>OS</th>
                <th>Type</th>
                <th>Availability</th>
                <th>User</th>
            </tr>
        </thead>

        <tbody>
");
                EndContext();
#line 29 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
               var editID = Url.ActionContext.RouteData.Values["id"];
                int ID;
                if (editID != null) {
                    int.TryParse(editID.ToString(), out ID);
                }

                foreach (Device item in Model.Inventory)
                {
                    //var editID = Url.ActionContext.RouteData.Values["id"];
                    if (editID != null && item.id.ToString() == editID.ToString())
                    {
                        Model.device = item;
                    

#line default
#line hidden
                BeginContext(1281, 39, false);
#line 41 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
               Write(await Html.PartialAsync("_Edit", Model));

#line default
#line hidden
                EndContext();
#line 41 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                                                            
                    }
                    else {

#line default
#line hidden
                BeginContext(1370, 21, true);
                WriteLiteral("                <tr>\n");
                EndContext();
                BeginContext(1433, 24, true);
                WriteLiteral("                    <td>");
                EndContext();
                BeginContext(1458, 13, false);
#line 46 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.deviceID);

#line default
#line hidden
                EndContext();
                BeginContext(1471, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1502, 13, false);
#line 47 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.serialNo);

#line default
#line hidden
                EndContext();
                BeginContext(1515, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1546, 9, false);
#line 48 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.make);

#line default
#line hidden
                EndContext();
                BeginContext(1555, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1586, 10, false);
#line 49 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.model);

#line default
#line hidden
                EndContext();
                BeginContext(1596, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1627, 7, false);
#line 50 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.os);

#line default
#line hidden
                EndContext();
                BeginContext(1634, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1665, 9, false);
#line 51 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.type);

#line default
#line hidden
                EndContext();
                BeginContext(1674, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1705, 17, false);
#line 52 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.availability);

#line default
#line hidden
                EndContext();
                BeginContext(1722, 30, true);
                WriteLiteral("</td>\n                    <td>");
                EndContext();
                BeginContext(1753, 9, false);
#line 53 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                   Write(item.user);

#line default
#line hidden
                EndContext();
                BeginContext(1762, 86, true);
                WriteLiteral("</td>\n                    <td><input type=\"submit\" onclick=location.href=\"/Home/Index/");
                EndContext();
                BeginContext(1849, 7, false);
#line 54 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                                                                           Write(item.id);

#line default
#line hidden
                EndContext();
                BeginContext(1856, 104, true);
                WriteLiteral("\" value=\"Edit\" /></td>\n                    <td><input type=\"submit\" onclick=location.href=\"/Home/Remove/");
                EndContext();
                BeginContext(1961, 7, false);
#line 55 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                                                                            Write(item.id);

#line default
#line hidden
                EndContext();
                BeginContext(1968, 47, true);
                WriteLiteral("\" value=\"Remove\" /></td>\n                </tr>\n");
                EndContext();
#line 57 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                        }
                    }
                

#line default
#line hidden
                BeginContext(2081, 46, true);
                WriteLiteral("        </tbody>\n        <tfoot>\r\n            ");
                EndContext();
                BeginContext(2128, 31, false);
#line 62 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
       Write(await Html.PartialAsync("_Add"));

#line default
#line hidden
                EndContext();
                BeginContext(2159, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 63 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
               var pageID = Url.ActionContext.RouteData.Values["id"];
                if (pageID != null && pageID.ToString() == "-1"){

#line default
#line hidden
                BeginContext(2295, 40, true);
                WriteLiteral(" <td><div>Duplicate Device ID</div></td>");
                EndContext();
#line 64 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/Home/Index.cshtml"
                                                                                                         }
            

#line default
#line hidden
                BeginContext(2352, 30, true);
                WriteLiteral("        </tfoot>\n    </table>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2389, 8, true);
            WriteLiteral("\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DeviceViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
