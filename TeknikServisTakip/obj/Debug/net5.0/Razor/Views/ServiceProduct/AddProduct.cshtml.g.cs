#pragma checksum "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2328b1e270912aea525e0f6c9b3a0400bbba0e8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ServiceProduct_AddProduct), @"mvc.1.0.view", @"/Views/ServiceProduct/AddProduct.cshtml")]
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
#line 1 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\_ViewImports.cshtml"
using TeknikServisTakip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\_ViewImports.cshtml"
using TeknikServisTakip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2328b1e270912aea525e0f6c9b3a0400bbba0e8a", @"/Views/ServiceProduct/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e0c5f1d103c91cd8eb313adf22311d2cc0b9c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_ServiceProduct_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
  
    ViewData["Title"] = "AddProduct";
    Layout = "~/Views/Shared/_IndexLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/select2/4.0.13/css/select2.min.css"" integrity=""sha512-nMNlpuaDPrqlEls3IX/Q56H36qvBASwb3ipuo3MxeWbsQB1881ox0cRv7UPTgBlriqoynt35KjEwgGUeUXIPnw=="" crossorigin=""anonymous"" referrerpolicy=""no-referrer"" />

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2328b1e270912aea525e0f6c9b3a0400bbba0e8a4367", async() => {
                WriteLiteral(@"
    <div class=""form-group row"">
        <label for=""brand"" class=""col-2 col-form-label"">Marka</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fa fa-address-card""></i>
                    </div>
                </div>
                <input id=""brand"" name=""Brand"" placeholder=""Marka"" type=""text"" class=""form-control"" required=""required"">
            </div>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""Model"" class=""col-2 col-form-label"">Model</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fab fa-apple""></i>
                    </div>
                </div>
                <input id=""Model"" name=""Model"" placeholder=""Model"" type=""text"" cla");
                WriteLiteral(@"ss=""form-control"" required=""required"">
            </div>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""owner"" class=""col-2 col-form-label"">Sahibi</label>
        <div class=""col-8"">
            <select id=""owner"" name=""CustomerId"" class=""custom-select"" data-live-search=""true"" style=""height:550px"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2328b1e270912aea525e0f6c9b3a0400bbba0e8a6113", async() => {
                    WriteLiteral("Se??in");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 39 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                 foreach (var item in ViewBag.customers)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2328b1e270912aea525e0f6c9b3a0400bbba0e8a7444", async() => {
#nullable restore
#line 41 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                                                                                                       Write(item.CustomerName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                                                                                                                          Write(item.CustomerSurname);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                       WriteLiteral(item.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 41 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                                                             Write(item.CustomerName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                                                                                Write(item.CustomerSurname);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-tokens", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </select>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""problem"" class=""col-2 col-form-label"">Problem</label>
        <div class=""col-8"">
            <textarea id=""problem"" name=""Problem"" cols=""40"" rows=""5"" class=""form-control"" required=""required""></textarea>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""Notes"" class=""col-2 col-form-label"">Notlar</label>
        <div class=""col-8"">
            <textarea id=""Notes"" name=""Notes"" cols=""40"" rows=""5"" class=""form-control""></textarea>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""price"" class=""col-2 col-form-label"">??cret</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fas fa-dollar-sign""></i>
                    </div>
                </div>
                <input id=""price");
                WriteLiteral(@""" name=""Price"" type=""text"" class=""form-control"" required=""required"">
            </div>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""ServicesStatus"" class=""col-2 col-form-label"">Durumu</label>
        <div class=""col-8"">
            <select id=""ServicesStatus"" name=""ServicestatusId"" class=""custom-select"">
");
#nullable restore
#line 76 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                 foreach (var item in ViewBag.status)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2328b1e270912aea525e0f6c9b3a0400bbba0e8a12824", async() => {
#nullable restore
#line 78 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                                                                       Write(item.StatusName);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                                                     Write(item.StatusName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-tokens", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 79 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\ServiceProduct\AddProduct.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"offset-2 col-8\">\r\n            <button name=\"submit\" type=\"submit\" class=\"btn btn-primary\">??r??n?? Kay??t Et</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script src=\"https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js\"></script>\r\n\r\n<script>\r\n\r\n        $(document).ready(function() {\r\n            $(\'#owner\').select2();\r\n\r\n        });\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
