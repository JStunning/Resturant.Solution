#pragma checksum "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27f4c383e8fec0f267a8a2f3e6e97ecd5909b7db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Create), @"mvc.1.0.view", @"/Views/Cuisines/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cuisines/Create.cshtml", typeof(AspNetCore.Views_Cuisines_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27f4c383e8fec0f267a8a2f3e6e97ecd5909b7db", @"/Views/Cuisines/Create.cshtml")]
    public class Views_Cuisines_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 28, true);
            WriteLiteral("\n<h2>Add a new Cuisine</h2>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(117, 34, false);
#line 11 "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(157, 36, false);
#line 12 "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(193, 10, true);
            WriteLiteral("<br> <br>\n");
            EndContext();
            BeginContext(204, 67, true);
            WriteLiteral("    <input class=\"button\" type=\"submit\" value=\"Add new Cuisine\" />\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml"
}

#line default
#line hidden
            BeginContext(273, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(277, 45, false);
#line 16 "/Users/Guest/Desktop/Resturant.Solution/Food/Views/Cuisines/Create.cshtml"
Write(Html.ActionLink("Show all Cuisines", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(322, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
