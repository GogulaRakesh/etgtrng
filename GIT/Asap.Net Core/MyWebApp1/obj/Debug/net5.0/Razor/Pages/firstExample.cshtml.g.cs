#pragma checksum "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b12dffa671706624a8cdcc946a5827e76ff5ada"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyWebApp1.Pages.Pages_firstExample), @"mvc.1.0.razor-page", @"/Pages/firstExample.cshtml")]
namespace MyWebApp1.Pages
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
#line 1 "C:\Users\gogula.rakesh\MyWebApp1\Pages\_ViewImports.cshtml"
using MyWebApp1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b12dffa671706624a8cdcc946a5827e76ff5ada", @"/Pages/firstExample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a56c940525c7c063bb9c5fa4565120c3ba8a1273", @"/Pages/_ViewImports.cshtml")]
    public class Pages_firstExample : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
   string Use = "Rakesh"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 6 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
Write(Use);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<a href=\"https://www.google.co.in/\">Google</a>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
   string message = "foreignObject example with Scalable Vector Graphics (SVG)"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<svg width=\"200\" height=\"200\" xmlns=\"http://www.w3.org/2000/svg\">\r\n    <rect x=\"0\" y=\"0\" rx=\"10\" ry=\"10\" width=\"200\" height=\"200\" stroke=\"black\"\r\n          fill=\"none\" />\r\n    <foreignObject x=\"20\" y=\"20\" width=\"160\" height=\"160\">\r\n        <p>");
#nullable restore
#line 16 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
      Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </foreignObject>\r\n</svg>\r\n\r\n<p>");
#nullable restore
#line 20 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 21 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
Write(DateTime.IsLeapYear(2016));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
            WriteLiteral("<p>Last week this time: ");
#nullable restore
#line 24 "C:\Users\gogula.rakesh\MyWebApp1\Pages\firstExample.cshtml"
                    Write(DateTime.Now - TimeSpan.FromDays(7));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>Last week: 7/7/2016 4:39:52 PM - TimeSpan.FromDays(7)</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyWebApp1.Pages.firstExampleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp1.Pages.firstExampleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyWebApp1.Pages.firstExampleModel>)PageContext?.ViewData;
        public MyWebApp1.Pages.firstExampleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
