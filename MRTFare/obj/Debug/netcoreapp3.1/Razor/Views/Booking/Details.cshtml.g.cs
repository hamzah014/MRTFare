#pragma checksum "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "282d378803232e3e99e1861296a68c8410f10d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Details), @"mvc.1.0.view", @"/Views/Booking/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"282d378803232e3e99e1861296a68c8410f10d3d", @"/Views/Booking/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b921d73098824b2554a9d33e2f74f48355f0bfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MRTFare.Models.MRT>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-md d-print-none"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserBooking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
  
    ViewData["Title"] = "Booking Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282d378803232e3e99e1861296a68c8410f10d3d4700", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-10 col-xl-9 mx-auto"">
                <div class=""card flex-row my-5 border-0 shadow rounded-3 overflow-hidden"">
                    <div class=""card-img-booking d-none d-print-inline-block d-md-flex"">
                        <!-- Background image for card set in CSS! -->
                    </div>
                    <div class=""card-body p-4 p-sm-5"">
                        <h2 class=""card-title text-center mb-5 fw-light fs-5"">Booking Ticket Information!</h2>
                            <div class=""row"">

                                <div class=""col-6"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 24 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.BookingId));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 25 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.ViewId));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>

                                <div class=""col-6"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 33 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.BookDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 34 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.BookDateTime));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>

                            </div>

                            <div class=""row"">


                                <div class=""col-6"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 47 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexOrigin));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 48 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.DictStation[Model.IndexOrigin]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>



                                <div class=""col-6"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 58 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexDestination));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 59 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.DictStation[Model.IndexDestination]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>


                            </div>

                            <div class=""row"">


                                <div class=""col-4"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 73 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexCategory));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 74 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.DictCategory[Model.IndexCategory]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>

                                <div class=""col-4"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 82 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.IndexTrip));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 83 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.DictTrip[Model.IndexTrip]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>

                                <div class=""col-4"">
                                    <div class=""form-floating mb-3"">
                                        <label>");
#nullable restore
#line 91 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">");
#nullable restore
#line 92 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                          Write(Html.DisplayFor(x => x.Quantity));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>


                            </div>

                            <div class=""row"">


                                <div class=""col-12"">
                                    <div class=""form-floating mb-3 text-left"">
                                        <label>");
#nullable restore
#line 106 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                          Write(Html.DisplayNameFor(x => x.totalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                                        <p class=\"txtlabel bg-dark text-white\">RM ");
#nullable restore
#line 107 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                                                                             Write(Html.DisplayFor(x => x.totalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                                    </div>

                                </div>


                            </div>

                            <div class=""row"">
                                <div class=""col-12"">
                                    <button onclick=""window.print()"" class=""btn btn-md btn-primary d-print-none"">Print</button>
                                    ");
#nullable restore
#line 119 "E:\C# Project\MRTFare\MRTFare\Views\Booking\Details.cshtml"
                               Write(Html.ActionLink("Email Me!", "SendMail", new { id = Model.Id }, new { @class = "btn btn-md btn-success d-print-none" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "282d378803232e3e99e1861296a68c8410f10d3d14179", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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