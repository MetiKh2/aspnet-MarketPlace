#pragma checksum "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fe0f0ec2a46a97f0b7d1029d19b491bd4ee205d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Ticket_TicketDetail), @"mvc.1.0.view", @"/Areas/User/Views/Ticket/TicketDetail.cshtml")]
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
#line 1 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\_ViewImports.cshtml"
using MarketPlace.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
using MarketPlace.application.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fe0f0ec2a46a97f0b7d1029d19b491bd4ee205d", @"/Areas/User/Views/Ticket/TicketDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4611585adaf0e3258a968658f1a770fefe09285e", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Ticket_TicketDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MarketPlace.dataLayer.DTOs.Contact.TicketDetailDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AnswerTicketPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_JqueryValidators", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/SiteTemplate/css/ChatRoom.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
  
    ViewData["Title"] = Model.Ticket.Title;
    Layout = "~/Views/Shared/_MainLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""breadcrumbs_area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""breadcrumb_content"">
                    <ul>
                        <li><a href=""/"">خانه</a></li>
                        <li>");
#nullable restore
#line 16 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<section class=""main_content_area"">
    <div class=""container"">
        <div class=""account_dashboard"">
            <div class=""row"">
                <div class=""col-sm-12 col-md-3 col-lg-3"">
                    ");
#nullable restore
#line 29 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
               Write(await Component.InvokeAsync("UserSideBar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""col-sm-12 col-md-9 col-lg-9"">
                    <!-- Tab panes -->
                    <div class=""tab-content dashboard_content"">
                        <div class=""tab-pane fade active show"" id=""account-details"">
                            <h3>");
#nullable restore
#line 35 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fe0f0ec2a46a97f0b7d1029d19b491bd4ee205d6940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 36 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = (new MarketPlace.dataLayer.DTOs.Contact.AddTicketMessageDto{TicketId = Model.Ticket.Id});

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                            <hr />\r\n                            <ul class=\"messages\" id=\"messages\">\r\n");
#nullable restore
#line 40 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                 if (Model.TicketMessages != null && Model.TicketMessages.Any())
                                {
                                    foreach (var message in Model.TicketMessages)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li");
            BeginWriteAttribute("class", " class=\"", 1781, "\"", 1868, 3);
            WriteAttributeValue("", 1789, "message", 1789, 7, true);
#nullable restore
#line 44 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
WriteAttributeValue(" ", 1796, message.SenderId == Model.Ticket.OwnerId ? "right" : "left", 1797, 62, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1859, "appeared", 1860, 9, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"avatar\">\r\n                                                <img");
            BeginWriteAttribute("src", " src=\"", 1990, "\"", 2183, 1);
#nullable restore
#line 46 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
WriteAttributeValue("", 1996, (!string.IsNullOrEmpty(Model.Ticket.User.Avatar)&&message.SenderId == Model.Ticket.OwnerId)?PathExtension.UserAvatarThumbPath+Model.Ticket.User.Avatar:PathExtension.DefaultAvatarOrigin, 1996, 187, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Alternate Text"">
                                            </div>
                                            <div class=""text_wrapper"">
                                                <div class=""time"">
                                                    ");
#nullable restore
#line 50 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                               Write(message.CreateDate.ToStringShamsiDate());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ساعت ");
#nullable restore
#line 50 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                                                                             Write(message.CreateDate.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                                <div class=\"text\" style=\"font-size: 16px\">\r\n                                                    ");
#nullable restore
#line 53 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                               Write(Html.Raw(message.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 57 "D:\MarketPlace\MarketPlace\MarketPlace.web\Areas\User\Views\Ticket\TicketDetail.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fe0f0ec2a46a97f0b7d1029d19b491bd4ee205d12577", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            DefineSection("styles", async() => {
                WriteLiteral(" \r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fe0f0ec2a46a97f0b7d1029d19b491bd4ee205d13875", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MarketPlace.dataLayer.DTOs.Contact.TicketDetailDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
