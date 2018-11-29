#pragma checksum "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5dcf18e02e8287a2c54e2d565f721af714c90b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MvcGrid__Pager), @"mvc.1.0.view", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/MvcGrid/_Pager.cshtml", typeof(AspNetCore.Views_Shared_MvcGrid__Pager))]
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
#line 1 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\_ViewImports.cshtml"
using BenefitsTracker.Controllers;

#line default
#line hidden
#line 2 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\_ViewImports.cshtml"
using BenefitsTracker.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\_ViewImports.cshtml"
using BenefitsTracker.Data.Entities;

#line default
#line hidden
#line 1 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5dcf18e02e8287a2c54e2d565f721af714c90b3", @"/Views/Shared/MvcGrid/_Pager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774bcac11ba9b4727d993516a40a82f7c260a09c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MvcGrid__Pager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IGridPager>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
  
    Int32 totalPages = Model.TotalPages;
    Int32 currentPage = Model.CurrentPage;
    Int32 firstDisplayPage = Model.FirstDisplayPage;

#line default
#line hidden
            BeginContext(197, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 203, "\"", 243, 2);
            WriteAttributeValue("", 211, "mvc-grid-pager", 211, 14, true);
#line 10 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue(" ", 225, Model.CssClasses, 226, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(244, 23, true);
            WriteLiteral(" data-show-page-sizes=\"");
            EndContext();
            BeginContext(268, 19, false);
#line 10 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                                               Write(Model.ShowPageSizes);

#line default
#line hidden
            EndContext();
            BeginContext(287, 4, true);
            WriteLiteral("\">\r\n");
            EndContext();
#line 11 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
     if (totalPages > 0)
    {
        if (currentPage > 1)
        {

#line default
#line hidden
            BeginContext(365, 83, true);
            WriteLiteral("            <button data-page=\"1\">&laquo;</button>\r\n            <button data-page=\"");
            EndContext();
            BeginContext(450, 15, false);
#line 16 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                           Write(currentPage - 1);

#line default
#line hidden
            EndContext();
            BeginContext(466, 21, true);
            WriteLiteral("\">&lsaquo;</button>\r\n");
            EndContext();
#line 17 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(523, 139, true);
            WriteLiteral("            <button class=\"disabled\" tabindex=\"-1\">&laquo;</button>\r\n            <button class=\"disabled\" tabindex=\"-1\">&lsaquo;</button>\r\n");
            EndContext();
#line 22 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        for (Int32 page = firstDisplayPage; page <= totalPages && page < firstDisplayPage + Model.PagesToDisplay; page++)
        {
            if (page == currentPage)
            {

#line default
#line hidden
            BeginContext(860, 50, true);
            WriteLiteral("                <button class=\"active\" data-page=\"");
            EndContext();
            BeginContext(912, 4, false);
#line 27 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                              Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(917, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(921, 4, false);
#line 27 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                                       Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(926, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 28 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(985, 35, true);
            WriteLiteral("                <button data-page=\"");
            EndContext();
            BeginContext(1022, 4, false);
#line 31 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                               Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1027, 2, true);
            WriteLiteral("\">");
            EndContext();
            BeginContext(1031, 4, false);
#line 31 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                        Write(page);

#line default
#line hidden
            EndContext();
            BeginContext(1036, 11, true);
            WriteLiteral("</button>\r\n");
            EndContext();
#line 32 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
            }
        }
        if (currentPage < totalPages)
        {

#line default
#line hidden
            BeginContext(1123, 31, true);
            WriteLiteral("            <button data-page=\"");
            EndContext();
            BeginContext(1156, 15, false);
#line 36 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                           Write(currentPage + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1172, 52, true);
            WriteLiteral("\">&rsaquo;</button>\r\n            <button data-page=\"");
            EndContext();
            BeginContext(1225, 10, false);
#line 37 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                          Write(totalPages);

#line default
#line hidden
            EndContext();
            BeginContext(1235, 20, true);
            WriteLiteral("\">&raquo;</button>\r\n");
            EndContext();
#line 38 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1291, 139, true);
            WriteLiteral("            <button class=\"disabled\" tabindex=\"-1\">&rsaquo;</button>\r\n            <button class=\"disabled\" tabindex=\"-1\">&raquo;</button>\r\n");
            EndContext();
#line 43 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        if (Model.ShowPageSizes)
        {

#line default
#line hidden
            BeginContext(1486, 47, true);
            WriteLiteral("            <div class=\"mvc-grid-page-sizes\">\r\n");
            EndContext();
#line 47 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                 if (Model.PageSizes.Count > 0)
                {

#line default
#line hidden
            BeginContext(1601, 58, true);
            WriteLiteral("                    <select class=\"mvc-grid-pager-rows\">\r\n");
            EndContext();
#line 50 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                         foreach (KeyValuePair<Int32, String> size in Model.PageSizes)
                        {
                            if (Model.RowsPerPage == size.Key)
                            {

#line default
#line hidden
            BeginContext(1869, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(1901, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a7abc087b51e4f81a6fa201c8fcbf1d1", async() => {
                BeginContext(1937, 10, false);
#line 54 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                                              Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 54 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1956, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 55 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(2054, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2086, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5e899db4a5b4caf961547e983bdefda", async() => {
                BeginContext(2113, 10, false);
#line 58 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                                     Write(size.Value);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                                   WriteLiteral(size.Key);

#line default
#line hidden
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
            EndContext();
            BeginContext(2132, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(2192, 31, true);
            WriteLiteral("                    </select>\r\n");
            EndContext();
#line 62 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2283, 54, true);
            WriteLiteral("                    <input class=\"mvc-grid-pager-rows\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2337, "\"", 2363, 1);
#line 65 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2345, Model.RowsPerPage, 2345, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2364, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 66 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
                }

#line default
#line hidden
            BeginContext(2388, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 68 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2444, 60, true);
            WriteLiteral("            <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2504, "\"", 2530, 1);
#line 71 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2512, Model.RowsPerPage, 2512, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2531, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 72 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
        }
    }
    else
    {

#line default
#line hidden
            BeginContext(2571, 56, true);
            WriteLiteral("        <input class=\"mvc-grid-pager-rows\" type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2627, "\"", 2653, 1);
#line 76 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
WriteAttributeValue("", 2635, Model.RowsPerPage, 2635, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2654, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 77 "C:\Users\nxpearson\source\repos\BenefitsTracker\BenefitsTracker\Views\Shared\MvcGrid\_Pager.cshtml"
    }

#line default
#line hidden
            BeginContext(2666, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IGridPager> Html { get; private set; }
    }
}
#pragma warning restore 1591
