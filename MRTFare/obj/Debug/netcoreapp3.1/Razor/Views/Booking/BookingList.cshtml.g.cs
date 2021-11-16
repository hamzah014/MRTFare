#pragma checksum "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00044b0f10cb3fae9639e6e36bd521cbf16cfab7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_BookingList), @"mvc.1.0.view", @"/Views/Booking/BookingList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00044b0f10cb3fae9639e6e36bd521cbf16cfab7", @"/Views/Booking/BookingList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b921d73098824b2554a9d33e2f74f48355f0bfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_BookingList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MRTFare.Models.MRT>>
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
#line 1 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
  
    ViewData["Title"] = "My Booking";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00044b0f10cb3fae9639e6e36bd521cbf16cfab73281", async() => {
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12 mx-auto\">\r\n\r\n                <div class=\"table-responsive\">\r\n                    <h2 class=\"card-title text-center mb-5 fw-light fs-5\">My Booking List</h2>\r\n\r\n\r\n\r\n");
#nullable restore
#line 17 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                     using (Html.BeginForm("SearchBooking", "Booking", FormMethod.Get))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>\r\n                            <label>Search by Booking ID : </label>\r\n                            ");
#nullable restore
#line 21 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                       Write(Html.TextBox("SearchString"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            <input class=\"btn btn-secondary\" type=\"submit\" value=\"Search\" />\r\n                            ");
#nullable restore
#line 24 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                       Write(Html.ActionLink("Back to Full List", "UserBooking", new { }, new { @class = "btn btn-info" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </p>\r\n");
#nullable restore
#line 26 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    <table class=\"table table-responsive table-bordered\">\r\n                        <thead>\r\n                            <tr class=\"bg-light text-center\">\r\n                                <th scope=\"col\">");
#nullable restore
#line 32 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.BookingId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 33 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.BookDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 34 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.IndexOrigin));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 35 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.IndexDestination));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 36 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.IndexCategory));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 37 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.IndexTrip));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 38 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">");
#nullable restore
#line 39 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                           Write(Html.DisplayNameFor(x => x.totalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                <th scope=\"col\">Action</th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 44 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                             foreach (var x in Model)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr class=\"text-center\">\r\n                                    <th scope=\"row\">");
#nullable restore
#line 47 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                               Write(Html.DisplayFor(y => x.ViewId));

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                                    <td>");
#nullable restore
#line 48 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.DisplayFor(y => x.ViewDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 49 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.DisplayFor(y => x.DictStation[x.IndexOrigin]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 50 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.DisplayFor(y => x.DictStation[x.IndexDestination]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 51 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.DisplayFor(y => x.DictCategory[x.IndexCategory]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 52 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.DisplayFor(y => x.DictTrip[x.IndexTrip]));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 53 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.DisplayFor(y => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>RM ");
#nullable restore
#line 54 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                      Write(Html.DisplayFor(y => x.ViewTotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"
                                   Write(Html.ActionLink("Details", "BookingDetails", new { id = x.Id }, new { @class = "btn btn-md btn-primary" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 59 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingList.cshtml"

                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MRTFare.Models.MRT>> Html { get; private set; }
    }
}
#pragma warning restore 1591
