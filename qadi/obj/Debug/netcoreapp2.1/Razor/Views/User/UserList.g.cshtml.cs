#pragma checksum "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e22330692b87cbfa0544b131e3051608e3d37093"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(qadi.Views.User.Views_User_UserList), @"mvc.1.0.view", @"/Views/User/UserList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/UserList.cshtml", typeof(qadi.Views.User.Views_User_UserList))]
namespace qadi.Views.User
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
using qadi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e22330692b87cbfa0544b131e3051608e3d37093", @"/Views/User/UserList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0092a6fce646c4c8c5e1681d41699916b2004c", @"/Views/_ViewImports.cshtml")]
    public class Views_User_UserList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("align", new global::Microsoft.AspNetCore.Html.HtmlString("center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(52, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "903447c64ceb4c56ab46231fa0daa765", async() => {
                BeginContext(58, 81, true);
                WriteLiteral("\r\n    <title>User List</title>\r\n    <link href=\"/style.css\" rel=\"stylesheet\" />\r\n");
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
            BeginContext(146, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(148, 1568, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aebf0e68feb645c6bfc7dd948e6c9528", async() => {
                BeginContext(169, 245, true);
                WriteLiteral("\r\n    <input type=\"submit\" onclick=location.href=\"/CiCo/Prologue\" value=\"In-and-Out Portal\" />\r\n    <input type=\"submit\" onclick=location.href=\"/Home/Index\" value=\"Device List\" /><br /><br />\r\n\r\n    <table style=\"width: 300px;\" align=\"center\">\r\n");
                EndContext();
#line 14 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
           var ID = Url.ActionContext.RouteData.Values["id"];
            if (ID != null && ID.ToString() == "-1") {

#line default
#line hidden
                BeginContext(530, 55, true);
                WriteLiteral(" <div>Can\'t remove user with checked out devices.</div>");
                EndContext();
#line 15 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                                                                                                             }
            if(ID != null && ID.ToString() == "-2") {

#line default
#line hidden
                BeginContext(641, 32, true);
                WriteLiteral(" <div>User already exists.</div>");
                EndContext();
#line 16 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                                                                                     }
            

#line default
#line hidden
                BeginContext(690, 124, true);
                WriteLiteral("\r\n        <thead>\r\n            <tr>\r\n                <th>Name</th>\r\n            </tr>\r\n        </thead>\r\n\r\n        <tbody>\r\n");
                EndContext();
#line 26 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
               var editID = Url.ActionContext.RouteData.Values["id"];
                foreach (User user in Model.users)
                {
                    if (editID != null && user.id.ToString() == editID.ToString())
                    {
                        Model.user = user;
                        

#line default
#line hidden
                BeginContext(1127, 39, false);
#line 32 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                   Write(await Html.PartialAsync("_Edit", Model));

#line default
#line hidden
                EndContext();
#line 32 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                                                                
                    }
                    else { 

#line default
#line hidden
                BeginContext(1217, 46, true);
                WriteLiteral("                <tr>\r\n                    <td>");
                EndContext();
                BeginContext(1264, 9, false);
#line 36 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                   Write(user.name);

#line default
#line hidden
                EndContext();
                BeginContext(1273, 90, true);
                WriteLiteral("</td>\r\n                    <td><input type=\"submit\" onclick=location.href=\"/User/UserList/");
                EndContext();
                BeginContext(1364, 7, false);
#line 37 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                                                                              Write(user.id);

#line default
#line hidden
                EndContext();
                BeginContext(1371, 105, true);
                WriteLiteral("\" value=\"Edit\" /></td>\r\n                    <td><input type=\"submit\" onclick=location.href=\"/User/Remove/");
                EndContext();
                BeginContext(1477, 7, false);
#line 38 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                                                                            Write(user.id);

#line default
#line hidden
                EndContext();
                BeginContext(1484, 50, true);
                WriteLiteral("\" value=\"Remove\" /> </td>\r\n                </tr>\r\n");
                EndContext();
#line 40 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
                    }
                }
                

#line default
#line hidden
                BeginContext(1594, 49, true);
                WriteLiteral("        </tbody>\r\n\r\n        <tfoot>\r\n            ");
                EndContext();
                BeginContext(1644, 31, false);
#line 46 "/Users/trevarissmall/Projects/QADI/internsummer2018/QADI/qadi/Views/User/UserList.cshtml"
       Write(await Html.PartialAsync("_Add"));

#line default
#line hidden
                EndContext();
                BeginContext(1675, 34, true);
                WriteLiteral("\r\n        </tfoot>\r\n    </table>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1716, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
