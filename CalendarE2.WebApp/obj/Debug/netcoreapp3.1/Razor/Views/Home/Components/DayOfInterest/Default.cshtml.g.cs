#pragma checksum "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3037b72972f911425b04d4cfe63c6385648956a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_DayOfInterest_Default), @"mvc.1.0.view", @"/Views/Home/Components/DayOfInterest/Default.cshtml")]
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
#line 1 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\_ViewImports.cshtml"
using CalendarE2.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\_ViewImports.cshtml"
using CalendarE2.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
using CalendarE2.Domain.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3037b72972f911425b04d4cfe63c6385648956a9", @"/Views/Home/Components/DayOfInterest/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d73c691568de0b03fb22a8ec8f578d132cd937", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_DayOfInterest_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CalendarE2.Domain.ViewModels.PeriodViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/addUpdateEventBase.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3037b72972f911425b04d4cfe63c6385648956a93864", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div id=\"periodEvents\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3 topDate\"><span>");
#nullable restore
#line 7 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                           Write(Model.Yr.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 7 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                                                 Write(Model.MoStr);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                                                              Write(Model.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        </div>\r\n        ");
#nullable restore
#line 9 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
   Write(await Component.InvokeAsync("AddUpdateModal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n");
#nullable restore
#line 11 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
         foreach (RowWithHour rwh in Model.Schedule.RowsOfHour)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row eventRow\">\r\n                <span>");
#nullable restore
#line 14 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                 Write(rwh.DisplayHour.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                             Write(rwh.AMPM);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
            WriteLiteral("                    <div>\r\n                        <span class=\"oneSpace\"></span>\r\n                        <span class=\"timeslot actionField\" onclick=\'aUEventDay(this)\' data-datet=\"");
#nullable restore
#line 18 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                                                                             Write(rwh.EventsOfHour[0].DateT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-hour=\"");
#nullable restore
#line 18 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                                                                                                                    Write(rwh.EventsOfHour[0].HourInt);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><span class=\"fa fa-edit\"></span></span>\r\n                        <span class=\"timeslot\">");
#nullable restore
#line 19 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                          Write(rwh.EventsOfHour[0].Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span class=\"timeslot\">");
#nullable restore
#line 20 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
                                          Write(rwh.EventsOfHour[0].Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n");
            WriteLiteral("            </div>\r\n");
#nullable restore
#line 24 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\WebApp\Views\Home\Components\DayOfInterest\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    <script>\r\n\r\n");
            WriteLiteral(@"
        function checkUpdateDay (elem) {
            // Check if there is already an entry for the chosen timeslot. If so, then an update.
            if (elem.parentNode.children[3].innerHTML.length > 0) {
                document.getElementById(""modalEventTitle"").value = elem.parentNode.children[2].innerHTML;
                document.getElementById(""modalDescription"").value = elem.parentNode.children[3].innerHTML;
            }
        }

        function aUEventDay(elem) {
            // aUEvent in a file in the js directory, used in week functionality as well. Could be used in Monthly functionality, if added.
            aUEvent(elem, packForm, checkUpdateDay);
        }        
    </script>    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CalendarE2.Domain.ViewModels.PeriodViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591