#pragma checksum "C:\Users\Anderson\Desktop\Projetos\Meusitemvc\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b45b0d2c5afd0ad5a63e3106b2edab4e36c3f872f473bdf32d642adad75caaf5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Anderson\Desktop\Projetos\Meusitemvc\Views\_ViewImports.cshtml"
using Meusitemvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anderson\Desktop\Projetos\Meusitemvc\Views\_ViewImports.cshtml"
using Meusitemvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b45b0d2c5afd0ad5a63e3106b2edab4e36c3f872f473bdf32d642adad75caaf5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b4038c2a52a1c6768608a7b15079747dc649eccb82d07c11dfbfe6088ef35589", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Anderson\Desktop\Projetos\Meusitemvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Pagina inicial";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Bem Vindo, ");
#nullable restore
#line 7 "C:\Users\Anderson\Desktop\Projetos\Meusitemvc\Views\Home\Index.cshtml"
                                Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Saiba mais<a href=\"https://docs.microsoft.com/aspnet/core\">\r\n sobre como criar aplicativos da Web com ASP.NET Core</a>.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
