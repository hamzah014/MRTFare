#pragma checksum "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23aaf09bd0ef1e8d99213d984ded8b77c429edf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewProfile), @"mvc.1.0.view", @"/Views/User/ViewProfile.cshtml")]
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
#line 1 "E:\C# Project\MRTFare\MRTFare\Views\_ViewImports.cshtml"
using MRTFare;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C# Project\MRTFare\MRTFare\Views\_ViewImports.cshtml"
using MRTFare.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23aaf09bd0ef1e8d99213d984ded8b77c429edf6", @"/Views/User/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b921d73098824b2554a9d33e2f74f48355f0bfd", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MRTFare.Models.Users>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
  
    ViewData["Title"] = "My Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23aaf09bd0ef1e8d99213d984ded8b77c429edf63260", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 col-xl-9 mx-auto"">
                <div class=""card flex-row my-5 border-0 shadow rounded-3 overflow-hidden"">
                    <div class=""card-body p-4 p-sm-5"">
                        <h2 class=""card-title text-center mb-5 fw-light fs-5"">My Profile!</h2>
");
#nullable restore
#line 16 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                         using (Html.BeginForm())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <table class=\" table\">\r\n                                <tr>\r\n                                    <th>");
#nullable restore
#line 20 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 21 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>");
#nullable restore
#line 24 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 25 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>");
#nullable restore
#line 28 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.DisplayNameFor(x => x.IcNo));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 29 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.TextBoxFor(x => x.IcNo, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>");
#nullable restore
#line 32 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.DisplayNameFor(x => x.Password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 33 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"
                                   Write(Html.TextBoxFor(x => x.Password, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                </tr>\r\n\r\n                            </table>\r\n");
                WriteLiteral("                            <div class=\"d-grid mb-2\">\r\n                                <input class=\"btn btn-md btn-success btn-login fw-bold text-uppercase\" type=\"submit\" value=\"Update\" />\r\n                            </div>\r\n");
#nullable restore
#line 41 "E:\C# Project\MRTFare\MRTFare\Views\User\ViewProfile.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MRTFare.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591