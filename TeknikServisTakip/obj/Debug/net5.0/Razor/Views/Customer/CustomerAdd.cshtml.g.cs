#pragma checksum "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7686463b5cc3aa8330c04c8ccd8584a03ec44c40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerAdd), @"mvc.1.0.view", @"/Views/Customer/CustomerAdd.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7686463b5cc3aa8330c04c8ccd8584a03ec44c40", @"/Views/Customer/CustomerAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81e0c5f1d103c91cd8eb313adf22311d2cc0b9c0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CustomerAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
  
    ViewData["Title"] = "CustomerAdd";
    Layout = "~/Views/Shared/_IndexLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7686463b5cc3aa8330c04c8ccd8584a03ec44c404377", async() => {
                WriteLiteral(@"
    <div class=""form-group row"">
        <label for=""CustomerName"" class=""col-2 col-form-label"">M????teri Ad??</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fa fa-address-card""></i>
                    </div>
                </div>
                <input id=""CustomerName"" name=""CustomerName"" type=""text"" class=""form-control"" required=""required"">
            </div>
            ");
#nullable restore
#line 20 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
       Write(Html.ValidationMessageFor(x=>x.CustomerName,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""CustomerSurname"" class=""col-2 col-form-label"">M????teri Soyad??</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fa fa-address-book""></i>
                    </div>
                </div>
                <input id=""CustomerSurname"" name=""CustomerSurname"" type=""text"" class=""form-control"" required=""required"">
               
            </div>
             ");
#nullable restore
#line 35 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
        Write(Html.ValidationMessageFor(x=>x.CustomerSurname,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""CustomerPhone"" class=""col-2 col-form-label"">Telefon</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fa fa-phone-square""></i>
                    </div>
                </div>
                <input id=""CustomerPhone"" name=""CustomerPhone"" type=""text"" class=""form-control"">
                
            </div>
            ");
#nullable restore
#line 50 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
       Write(Html.ValidationMessageFor(x=>x.CustomerPhone,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""CustomerEmail"" class=""col-2 col-form-label"">Email</label>
        <div class=""col-8"">
            <div class=""input-group"">
                <div class=""input-group-prepend"">
                    <div class=""input-group-text"">
                        <i class=""fa fa-at""></i>
                    </div>
                </div>
                <input id=""CustomerEmail"" name=""CustomerEmail"" type=""text"" class=""form-control"" required=""required"">
               
            </div>
             ");
#nullable restore
#line 65 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
        Write(Html.ValidationMessageFor(x=>x.CustomerEmail,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""Province"" class=""col-2 col-form-label"">??l</label>
        <div class=""col-8"">
            <select id=""Province"" name=""Province"" class=""custom-select"" required=""required"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7686463b5cc3aa8330c04c8ccd8584a03ec44c408583", async() => {
                    WriteLiteral("Se??iniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
                 foreach (var item in ViewBag.City)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7686463b5cc3aa8330c04c8ccd8584a03ec44c4010115", async() => {
#nullable restore
#line 75 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
                                        Write(item.CityName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            </select>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""select"" class=""col-2 col-form-label"">??l??e</label>
        <div class=""col-8"">
            <select id=""district"" name=""DistrictId"" class=""custom-select"" required=""required"">
                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7686463b5cc3aa8330c04c8ccd8584a03ec44c4012564", async() => {
                    WriteLiteral("Se??iniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

            </select>
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""textarea"" class=""col-2 col-form-label"">Adres</label>
        <div class=""col-8"">
            <textarea id=""textarea"" name=""Address"" cols=""40"" rows=""4"" class=""form-control""></textarea><br />
            ");
#nullable restore
#line 93 "C:\Users\UlasCan\source\repos\TeknikServisTakip\TeknikServisTakip\Views\Customer\CustomerAdd.cshtml"
       Write(Html.ValidationMessageFor(x=>x.Address,"",new {@class="text-danger"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group row\">\r\n        <div class=\"offset-2 col-8\">\r\n            <button name=\"submit\" type=\"submit\" class=\"btn btn-primary\">Kaydet</button>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>


    $('#Province').on('change', function() {
         let id = this.value
         let ilceler="""";
        $.ajax({
            url:""/Customer/GetDistiric/""+id,
            method:""GET""
        }).done((result)=>{
           var options=""<option>Se??iniz</option>"";
            $.each(result,function(index,item){
               options+=`<option value=""${item.id}"">${item.provinceName}</option>`;
            })
            $(""#district"").html(options);
        })
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
