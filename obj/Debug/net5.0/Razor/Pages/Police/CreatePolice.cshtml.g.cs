#pragma checksum "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be58e066d0fc63c1e87898c020bca0ca204d40df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zadatak1.Pages.Police.Pages_Police_CreatePolice), @"mvc.1.0.razor-page", @"/Pages/Police/CreatePolice.cshtml")]
namespace Zadatak1.Pages.Police
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
#line 1 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\_ViewImports.cshtml"
using Zadatak1;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be58e066d0fc63c1e87898c020bca0ca204d40df", @"/Pages/Police/CreatePolice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe77674b751c6cc65792ec48271d086e12e5806", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Police_CreatePolice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br>\r\n<h2>New Police</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning alert-dismissible fade show\" role=\"alert\">\r\n        <strong>");
#nullable restore
#line 11 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        <button type=\"button\" class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be58e066d0fc63c1e87898c020bca0ca204d40df4301", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Broj police</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"brojpolice\"");
                BeginWriteAttribute("value", " value=\"", 595, "\"", 631, 1);
#nullable restore
#line 20 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
WriteAttributeValue("", 603, Model.policeInfo.BrojPolice, 603, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Iznos police</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"iznospolice\"");
                BeginWriteAttribute("value", " value=\"", 862, "\"", 899, 1);
#nullable restore
#line 26 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
WriteAttributeValue("", 870, Model.policeInfo.IznosPolice, 870, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 30 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
     if (Model.successMessage.Length > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                    <strong>");
#nullable restore
#line 35 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
                       Write(Model.successMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <button type=\"button\" class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 40 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\CreatePolice.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
        </div>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zadatak1.Pages.Police.CreatePoliceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zadatak1.Pages.Police.CreatePoliceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zadatak1.Pages.Police.CreatePoliceModel>)PageContext?.ViewData;
        public Zadatak1.Pages.Police.CreatePoliceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591