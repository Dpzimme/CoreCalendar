#pragma checksum "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\CalendarE2.WebApp\Views\Home\Components\AddUpdateModal\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8f99d353e378d3510168c5fe7618dd53d50941e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_AddUpdateModal_Default), @"mvc.1.0.view", @"/Views/Home/Components/AddUpdateModal/Default.cshtml")]
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
#line 1 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\CalendarE2.WebApp\Views\_ViewImports.cshtml"
using CalendarE2.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\CalendarE2.WebApp\Views\_ViewImports.cshtml"
using CalendarE2.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8f99d353e378d3510168c5fe7618dd53d50941e", @"/Views/Home/Components/AddUpdateModal/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2d73c691568de0b03fb22a8ec8f578d132cd937", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_AddUpdateModal_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div id=\"aUModal\" class=\"modal\" tabindex=\"-1\">    \r\n        <div class=\"modal-dialog\">\r\n            <div class=\"modal-content\">\r\n");
#nullable restore
#line 4 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\CalendarE2.WebApp\Views\Home\Components\AddUpdateModal\Default.cshtml"
                 using (Html.BeginForm("CreateOrUpdateEvent", "Home", FormMethod.Post))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""modal-header"">
                        <h5 class=""modal-title"">Add Update Event</h5>
                        <button type=""button"" class=""close"" data-dismiss=""modal"">
                            <span>&times</span>
                        </button>
                        </div>
                    <div class=""modal-body"" >
                        <div class=""row""> 
                        <label class=""col-sm-3"" for=""modalEventTitle"">Title</label>
                        <input class=""col-sm-3"" id=""modalEventTitle"" required name=""newTitle"" placeholder=""Enter Title of appointment"" />
                        </div>
                        <div class=""row"">
                            <label class=""col-sm-3"" for=""modalDescription"">Description</label>
                            <input class=""col-sm-3"" id=""modalDescription"" required name=""newDescription"" placeholder=""Enter description"" />
                        </div>
                        <input id=""modalYr"" nam");
            WriteLiteral(@"e=""Yr"" required style=""display:none;"" />
                        <input id=""modalMo"" name=""Mo"" required style=""display:none;"" />
                        <input id=""modalDy"" name=""Dy"" required style=""display:none;"" />
                        <input id=""modalTimeFrame"" name=""ModalTimeFrame"" style=""display:none;"" />
                        <input id=""displayHr"" required readonly=""readonly"" style=""display:none"" ; />
                        <input id=""modalHr"" name=""Hour"" style=""display:none;"" />
                        <br />                       
                    </div>
                    <div class=""modal-footer"">
                        <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close </button>
                        <button class=""btn btn-primary"" type=""submit"">Save Changes</button>
                    </div>
");
#nullable restore
#line 33 "C:\Users\danzi\source\repos\Folders\mvcWebApi\CalendarE2\CalendarE2.WebApp\Views\Home\Components\AddUpdateModal\Default.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
<div id=""pastEventMessage"" class=""modal"" tabindex=""-1"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Please Note</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"">
                    <span>&times</span>
                </button>
            </div>
            <div class=""modal-body"">
                Cannot edit past events
            </div>
            <div class=""modal-footer"">
                <button class=""btn btn-secondary"" type=""button"" data-dismiss=""modal"">Close </button>               
            </div>
        </div>
    </div>
</div>    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591