#pragma checksum "C:\Dev\CheckmatesMoq\WebApplication1\Views\FormDefinition\sortable-table.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d205664c23d171c274be81dadffd12ab94fcab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FormDefinition_sortable_table), @"mvc.1.0.view", @"/Views/FormDefinition/sortable-table.cshtml")]
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
#line 1 "C:\Dev\CheckmatesMoq\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Dev\CheckmatesMoq\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Dev\CheckmatesMoq\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d205664c23d171c274be81dadffd12ab94fcab", @"/Views/FormDefinition/sortable-table.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e8bf045fc77d7267a7f635ee5fe4bb5453c7a78", @"/Views/_ViewImports.cshtml")]
    public class Views_FormDefinition_sortable_table : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/sortable-table.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Dev\CheckmatesMoq\WebApplication1\Views\FormDefinition\sortable-table.cshtml"
  
    ViewData["Title"] = "帳票定義";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""row"">
        <h3>■帳票定義一覧</h3>
        <div class=""input-group justify-content-end"">
            <input type=""button"" class=""col btn btn-primary mr-2"" value=""イメージ登録"" />
            <input type=""button"" class=""col btn btn-primary mr-2"" value=""項目登録"" />
            <input type=""button"" class=""col btn btn-primary "" value=""解答・配点登録"" />
        </div>
    </div>
</div>
<div class=""border-top border mt-2 mb-2""></div>
<div class=""container-fluid"">
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d205664c23d171c274be81dadffd12ab94fcab4773", async() => {
                WriteLiteral(@"
        <div class=""form-inline"">
            <label class=""justify-content-end font-weight-bold mr-1 ml-1"" for=""examId"">
                試験ID
            </label>
            <input id=""examId"" type=""text"" class=""col-1 input-group-text bg-white mr-1 ml-1"" />
            <label class=""justify-content-end font-weight-bold mr-1 ml-3"" for=""formNo"">
                帳票No
            </label>
            <input id=""formNo"" type=""text"" class=""col-1 input-group-text bg-white mr-1 ml-1"" />
            <label class=""justify-content-end font-weight-bold mr-1 ml-3"" for=""examName"">
                試験名
            </label>
            <input id=""examName"" type=""text"" class=""col-3 input-group-text bg-white mr-1 ml-1"" />
            <label class=""justify-content-end font-weight-bold mr-1 ml-3"" for=""formName"">
                帳票名
            </label>
            <input id=""formName"" type=""text"" class=""col-3 input-group-text bg-white mr-1 ml-1"" />
        </div>
        <div class=""text-right mt-2"">
      ");
                WriteLiteral("      <button type=\"submit\" class=\"btn btn-outline-primary\">検　索</button>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<div class=""border-top border mt-2 mb-2""></div>
<div class=""container-fluid"">
    <div class=""row"">

        <div class=""p-1 col-sm-12 sortable-table"">

            <table class=""table table-hover table-bordered"" id=""reportList"">
                <thead>
                    <tr class=""text-center border"" style=""font-size:24px;background-color:#e6e6fa"">
");
            WriteLiteral(@"                        <th scope=""col"" data-id=""examId"" data-header>
                            <div>試験ID</div>
                        </th>

                        <th scope=""col"" data-id=""repoNo"" sortable>
                            帳票No
                        </th>
                        <th scope=""col"" data-id=""examName"" sortable>
                            試験名
                        </th>
                        <th scope=""col"" data-id=""repoName"" sortable>
                            帳票名
                        </th>
                    </tr>
                </thead>
                <tbody class=""text-center"">

                </tbody>
            </table>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9d205664c23d171c274be81dadffd12ab94fcab8474", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        const data = [
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
 ");
                WriteLiteral(@"               repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
            {
                examId: '20-1009-1',
                repoNo: '1000',
                examName: '2020年10月定期試験',
                repoName: '2020年10月国語',
            },
        ];

        const sortableTable = new SortableTable();
        // set table element
        sortableTable.setTable(document.querySelector('#reportList'));
        // set data to be sorted
        sortableTable.setData(data);
        // handling events
        sortableTable.events()
            .on('sort', (event) =>");
                WriteLiteral(" {\r\n                console.log(`[SortableTable#onSort]\r\n          event.colId=${event.colId}\r\n          event.sortDir=${event.sortDir}\r\n          event.data=\\n${JSON.stringify(event.data)}`);\r\n            });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n");
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
