#pragma checksum "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98f1f73c178d40edcd6a20cd65213839d28d9510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_BookingInvoice), @"mvc.1.0.view", @"/Views/Booking/BookingInvoice.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98f1f73c178d40edcd6a20cd65213839d28d9510", @"/Views/Booking/BookingInvoice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b921d73098824b2554a9d33e2f74f48355f0bfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_BookingInvoice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MRTFare.Models.MRT>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"
 using (Html.BeginForm())
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        <label>Booking ID :</label>\r\n        ");
#nullable restore
#line 8 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"
   Write(Html.DisplayFor(x => x.BookingId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        <label>Origin :</label>\r\n        ");
#nullable restore
#line 14 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"
   Write(Html.DisplayFor(x => x.DictStation[Model.IndexOrigin]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        <label>Destination :</label>\r\n        ");
#nullable restore
#line 19 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"
   Write(Html.DisplayFor(x => x.DictStation[Model.IndexDestination]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        <label>Price Ticket :</label>\r\n        ");
#nullable restore
#line 25 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"
   Write(Html.DisplayFor(x => x.ticketPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 30 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"
   Write(Html.ActionLink("Back to List", "Index", "", new { _class = "btn btn-block btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 32 "E:\C# Project\MRTFare\MRTFare\Views\Booking\BookingInvoice.cshtml"


}

#line default
#line hidden
#nullable disable
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