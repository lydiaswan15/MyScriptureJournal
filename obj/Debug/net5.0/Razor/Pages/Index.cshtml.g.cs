#pragma checksum "/Users/lydiaswanson/Desktop/MyScriptureJournal/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf8ef3ad96e86ea416dc4dd540b2f0b48c5d48f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MySciptureJournal.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MySciptureJournal.Pages
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
#line 1 "/Users/lydiaswanson/Desktop/MyScriptureJournal/Pages/_ViewImports.cshtml"
using MySciptureJournal;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf8ef3ad96e86ea416dc4dd540b2f0b48c5d48f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db1ece89a677f43fe569a6cdfa07939eb26162e6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/lydiaswanson/Desktop/MyScriptureJournal/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""preconnect"" href=""https://fonts.googleapis.com"">
<link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
<link href=""https://fonts.googleapis.com/css2?family=Roboto+Slab:wght@200&display=swap"" rel=""stylesheet"">

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>

</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
