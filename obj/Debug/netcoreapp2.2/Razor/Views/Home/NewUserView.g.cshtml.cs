#pragma checksum "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8922b1f1699400a7899f08772bafdbc37631793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_NewUserView), @"mvc.1.0.view", @"/Views/Home/NewUserView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/NewUserView.cshtml", typeof(AspNetCore.Views_Home_NewUserView))]
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
#line 1 "D:\GrandCircus\Labs\Lab21\Views\_ViewImports.cshtml"
using Lab21;

#line default
#line hidden
#line 2 "D:\GrandCircus\Labs\Lab21\Views\_ViewImports.cshtml"
using Lab21.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8922b1f1699400a7899f08772bafdbc37631793", @"/Views/Home/NewUserView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad79ed0e4f1e6fedc7595510007a398923d0a029", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_NewUserView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RegistrationViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
  
    ViewData["Title"] = "NewUserView";

#line default
#line hidden
            BeginContext(79, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 8 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
 try
{

#line default
#line hidden
            BeginContext(92, 32, true);
            WriteLiteral("    <h2>Thanks for registering, ");
            EndContext();
            BeginContext(125, 15, false);
#line 10 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
                           Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(140, 34, true);
            WriteLiteral("!</h2>\r\n    <h3>We\'ve got a fresh ");
            EndContext();
            BeginContext(175, 20, false);
#line 11 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
                     Write(Model.FavoriteCoffee);

#line default
#line hidden
            EndContext();
            BeginContext(195, 29, true);
            WriteLiteral(" brewing just for you.</h3>\r\n");
            EndContext();
#line 12 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
     if (Model.DoSendEmails)
    {

#line default
#line hidden
            BeginContext(261, 53, true);
            WriteLiteral("        <h3>We\'ll be sending you email offers.</h3>\r\n");
            EndContext();
#line 15 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(338, 44, true);
            WriteLiteral("        <h3>We won\'t be emailing you.</h3>\r\n");
            EndContext();
#line 19 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
    }

#line default
#line hidden
#line 19 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
     
}
catch
{

#line default
#line hidden
            BeginContext(402, 79, true);
            WriteLiteral("    <h3>Something went wrong in the registration, go back and try again.</h3>\r\n");
            EndContext();
#line 24 "D:\GrandCircus\Labs\Lab21\Views\Home\NewUserView.cshtml"
}

#line default
#line hidden
            BeginContext(484, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RegistrationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
