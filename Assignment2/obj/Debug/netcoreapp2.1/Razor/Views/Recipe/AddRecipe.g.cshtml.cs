#pragma checksum "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment2\Assignment2\Views\Recipe\AddRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1971292006bcd0c858f91d43d372d866bdd10a7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_AddRecipe), @"mvc.1.0.view", @"/Views/Recipe/AddRecipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Recipe/AddRecipe.cshtml", typeof(AspNetCore.Views_Recipe_AddRecipe))]
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
#line 1 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models;

#line default
#line hidden
#line 2 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment2\Assignment2\Views\_ViewImports.cshtml"
using Assignment2.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1971292006bcd0c858f91d43d372d866bdd10a7e", @"/Views/Recipe/AddRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab3e0a553b3d9e277dc0f9786ec7a40b5f192d27", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_AddRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Assignment2.Models.Recipe>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 486, true);
            WriteLiteral(@"
<div class=""w3-content"" style=""max-width:1100px"">
    <div class=""w3-container w3-padding-64"" id=""contact"">
        <h1>Post Your Recipe</h1><br>
        <p>Willing to share your recipe through our community? That's wonderful! All you need to do is to fill in the form below. </p>
        <p class=""w3-text-blue-grey w3-large""><b>Some form guides:</b></p>
        <p>Ingredients and Instructions field: you can devide ingredients and instructions by using "";"" sign.</p>
        ");
            EndContext();
            BeginContext(521, 33, false);
#line 9 "C:\Users\ostri\OneDrive\Desktop\Folders\College\Fall 2019\COMP 229\Assignments\Assignment2\Assignment2\Views\Recipe\AddRecipe.cshtml"
   Write(Html.Partial("RecipeForm", Model));

#line default
#line hidden
            EndContext();
            BeginContext(554, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Assignment2.Models.Recipe> Html { get; private set; }
    }
}
#pragma warning restore 1591
