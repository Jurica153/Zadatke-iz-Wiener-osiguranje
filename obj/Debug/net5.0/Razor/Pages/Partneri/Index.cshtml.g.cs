#pragma checksum "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a6721d1c9ce42963fc25fa33f85826a36dafbfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zadatak1.Pages.Partneri.Pages_Partneri_Index), @"mvc.1.0.razor-page", @"/Pages/Partneri/Index.cshtml")]
namespace Zadatak1.Pages.Partneri
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a6721d1c9ce42963fc25fa33f85826a36dafbfc", @"/Pages/Partneri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe77674b751c6cc65792ec48271d086e12e5806", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Partneri_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
  
    ViewData["Title"] = "Zadatak 1";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<h2>List of Partneri</h2>
<br>
<a class='btn btn-primary btn-sm' href='/Partneri/Create'>New Partneri</a><br>
<br>
<table class=""table"">
    <thead>
        <tr>
            <th>id</th>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Address</th>
            <th>Partner Number</th>
            <th>Croatian PIN</th>
            <th>Partner Type ID</th>
            <th>Created At Utc</th>
            <th>Created By User</th>
            <th>Is Foreign</th>
            <th>External Code</th>
            <th>Gender</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
         foreach (var i in Model.listClients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.PartnerNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.CroatianPIN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.PartnerTypeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.CreatedAtUtc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.CreatedByUser);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.IsForeign);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.ExternalCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 44 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
               Write(i.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a class=\"btn btn-primary btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1343, "\"", 1373, 2);
            WriteAttributeValue("", 1350, "/Partneri/Edit?id=", 1350, 18, true);
#nullable restore
#line 46 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
WriteAttributeValue("", 1368, i.id, 1368, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                    <a class=\"btn btn-danger btn-sm\"");
            BeginWriteAttribute("href", " href=\"", 1437, "\"", 1469, 2);
            WriteAttributeValue("", 1444, "/Partneri/Delete?id=", 1444, 20, true);
#nullable restore
#line 47 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
WriteAttributeValue("", 1464, i.id, 1464, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>        \r\n");
#nullable restore
#line 50 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Partneri\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Zadatak1.Pages.Partneri.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zadatak1.Pages.Partneri.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Zadatak1.Pages.Partneri.IndexModel>)PageContext?.ViewData;
        public Zadatak1.Pages.Partneri.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
