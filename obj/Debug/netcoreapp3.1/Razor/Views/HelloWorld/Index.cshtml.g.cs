#pragma checksum "C:\kodeprojekter\hjemmside\MvcMovie\Views\HelloWorld\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dc16be1691e9c16fe9f6f8c70b963e014adece0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HelloWorld_Index), @"mvc.1.0.view", @"/Views/HelloWorld/Index.cshtml")]
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
#line 1 "C:\kodeprojekter\hjemmside\MvcMovie\Views\_ViewImports.cshtml"
using mvcmovie;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\kodeprojekter\hjemmside\MvcMovie\Views\_ViewImports.cshtml"
using mvcmovie.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dc16be1691e9c16fe9f6f8c70b963e014adece0", @"/Views/HelloWorld/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbf00667ad599ef10f342411828493902d91e8fc", @"/Views/_ViewImports.cshtml")]
    public class Views_HelloWorld_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\kodeprojekter\hjemmside\MvcMovie\Views\HelloWorld\Index.cshtml"
  
    ViewData["Title"] = "Gustav";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function loveNumberf()
    {
        var input1 =  document.getElementById(""input1"").value;
        var input2 = document.getElementById(""input2"").value;
        var resultat = Math.floor(Math.random() * 100) + 1;
        document.getElementById(""loveNumber"").innerHTML =  resultat +'%'  ;
    }       
</script>

<h2>Gustav</h2>

<p>dette er Gustavs første hjemmeside </p>
<!-- #######  THIS IS A COMMENT - Visible only in the source editor #########-->
<h2>Hej Velkommen til den magiske Match Maker der giver en 100% valid indikation af hvorgodt du macher med en person.</h2>
<table class=""editorDemoTable"">
<tbody>
<tr>
<td style=""width: 57.7778px;"">navn+</td>
<td style=""width: 70.2222px;"">navn = </td>
<td style=""width: 50.6667px;"">procent:</td>
</tr>
</tbody>
</table>
<table>
<tbody>
<tr>
<td>
<p>procenten idikere hvor godt du macher med....</p>
<p><textarea id=""input1""></textarea> <textarea id=""input2""></textarea> <button type=""button"" onclick=""loveNumberf()"">generate</b");
            WriteLiteral(@"utton></p>
</td>
<td style=""position:relative;""><img style=""font-size: 14px;"" src=""https://upload.wikimedia.org/wikipedia/commons/8/86/A_perfect_SVG_heart.svg"" alt=""hart"" width=""200"" height=""200"" />
<div id=""loveNumber"" 
style=""width: 100%; color: white; font-size: 40px; font-weight: bold; position: absolute; top: 55px; text-align:center;"">

</div>
</td>
</tr>
</tbody>
</table>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
