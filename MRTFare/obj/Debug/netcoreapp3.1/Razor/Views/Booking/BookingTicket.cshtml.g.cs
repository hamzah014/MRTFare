#pragma checksum "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f098ebf9ec4be88f61512018cebed91a5ac75958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_BookingTicket), @"mvc.1.0.view", @"/Views/Booking/BookingTicket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f098ebf9ec4be88f61512018cebed91a5ac75958", @"/Views/Booking/BookingTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b921d73098824b2554a9d33e2f74f48355f0bfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_BookingTicket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MRTFare.Models.MRT>
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
#line 1 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
  
    ViewData["Title"] = "Booking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f098ebf9ec4be88f61512018cebed91a5ac759583285", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 col-xl-9 mx-auto"">
                <div class=""card flex-row my-5 border-0 shadow rounded-3 overflow-hidden"">
                    <div class=""card-body p-4 p-sm-5"">
                        <h2 class=""card-title text-center mb-5 fw-light fs-5"">Booking Ticket!</h2>
");
#nullable restore
#line 16 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                         using (Html.BeginForm())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"row\">\r\n\r\n                                <div class=\"col-6\">\r\n                                    <div class=\"form-floating mb-3\">\r\n                                        <label>");
#nullable restore
#line 22 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexOrigin));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        ");
#nullable restore
#line 23 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                   Write(Html.DropDownListFor(x => x.IndexOrigin, new SelectList(Model.DictStation, "Key", "Value"), "Select Origin", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span class=\"errormsg\">");
#nullable restore
#line 24 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                                          Write(Html.ValidationMessageFor(x => x.IndexOrigin, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>

                                </div>


                                <div class=""col-6"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 32 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexDestination));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        ");
#nullable restore
#line 33 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                   Write(Html.DropDownListFor(x => x.IndexDestination, new SelectList(Model.DictStation, "Key", "Value"), "Select Destination", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span class=\"errormsg\">");
#nullable restore
#line 34 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                                          Write(Html.ValidationMessageFor(x => x.IndexDestination, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n                            </div>\r\n");
                WriteLiteral("                            <div class=\"row\">\r\n\r\n                                <div class=\"col-12\">\r\n                                    <div class=\"form-floating mb-3\">\r\n                                        <label>");
#nullable restore
#line 46 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexCategory));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        ");
#nullable restore
#line 47 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                   Write(Html.DropDownListFor(x => x.IndexCategory, new SelectList(Model.DictCategory, "Key", "Value"), "Select Category", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span class=\"errormsg\">");
#nullable restore
#line 48 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                                          Write(Html.ValidationMessageFor(x => x.IndexCategory, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n\r\n\r\n                            </div>\r\n");
                WriteLiteral("                            <div class=\"row\">\r\n\r\n                                <div class=\"col-6\">\r\n\r\n                                    <div class=\"form-floating mb-3\">\r\n                                        <label>");
#nullable restore
#line 61 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexTrip));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        ");
#nullable restore
#line 62 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                   Write(Html.DropDownListFor(x => x.IndexTrip, new SelectList(Model.DictTrip, "Key", "Value"), "Select Trip", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <span class=\"errormsg\">");
#nullable restore
#line 63 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                                          Write(Html.ValidationMessageFor(x => x.IndexTrip, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>
                                </div>


                                <div class=""col-6"">


                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 72 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                          Write(Html.DisplayNameFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        ");
#nullable restore
#line 73 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"
                                   Write(Html.TextBoxFor(x => x.Quantity, "1", new { @class = "form-control", @type = "number" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </div>\r\n\r\n                                </div>\r\n\r\n\r\n                            </div>\r\n");
                WriteLiteral("                            <div class=\"d-grid mb-2\">\r\n                                <input class=\"btn btn-md btn-success btn-login fw-bold text-uppercase\" type=\"submit\" value=\"Submit\" />\r\n                            </div>\r\n");
#nullable restore
#line 84 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingTicket.cshtml"


                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MRTFare.Models.MRT> Html { get; private set; }
    }
}
#pragma warning restore 1591
