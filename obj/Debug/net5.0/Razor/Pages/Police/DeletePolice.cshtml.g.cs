#pragma checksum "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\DeletePolice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "946c85377c5ce58be6200bb8883e56e1d384976a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Zadatak1.Pages.Police.Pages_Police_DeletePolice), @"mvc.1.0.razor-page", @"/Pages/Police/DeletePolice.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\DeletePolice.cshtml"
using System.Data.SqlClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"946c85377c5ce58be6200bb8883e56e1d384976a", @"/Pages/Police/DeletePolice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe77674b751c6cc65792ec48271d086e12e5806", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Police_DeletePolice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Jurica\source\repos\Zadatak1\Zadatak1\Pages\Police\DeletePolice.cshtml"
  
    try
    {
        String id = Request.Query["id"];

        string connectionString = "Data Source=.\\DESKTOP-8UDK3S7;Initial Catalog=Police;Integrated Security=True";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            String sql = "DELETE FROM Partneri WHERE @id = id";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
        }
    }

    catch (Exception ex)
    {

    }
    Response.Redirect("/Police/Index");

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Police_DeletePolice> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Police_DeletePolice> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Police_DeletePolice>)PageContext?.ViewData;
        public Pages_Police_DeletePolice Model => ViewData.Model;
    }
}
#pragma warning restore 1591
