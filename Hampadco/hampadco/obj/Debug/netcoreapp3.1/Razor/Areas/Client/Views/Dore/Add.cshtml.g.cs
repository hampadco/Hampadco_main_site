#pragma checksum "f:\Projects\Hampadco\Hampadco\hampadco\Areas\Client\Views\Dore\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d03f59a17754563de165c4af1b1b3f6879283bff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_Dore_Add), @"mvc.1.0.view", @"/Areas/Client/Views/Dore/Add.cshtml")]
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
#line 1 "f:\Projects\Hampadco\Hampadco\hampadco\Areas\Client\Views\_ViewImports.cshtml"
using hampadco;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "f:\Projects\Hampadco\Hampadco\hampadco\Areas\Client\Views\_ViewImports.cshtml"
using hampadco.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d03f59a17754563de165c4af1b1b3f6879283bff", @"/Areas/Client/Views/Dore/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a77c7bfff406093198dff2bc9c98ebe6752e4157", @"/Areas/Client/Views/_ViewImports.cshtml")]
    public class Areas_Client_Views_Dore_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("edit-profile m-b30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<!--Main container start -->
<main class=""ttr-wrapper"">
	<div class=""container-fluid"">
		<div class=""db-breadcrumb"">
			<h4 class=""breadcrumb-title"">افزودن دوره</h4>
			<ul class=""db-breadcrumb-list"">
				<li><a href=""#""><i class=""fa fa-home""></i>خانه</a></li>
				<li>افزودن دوره</li>
			</ul>
		</div>	
		<div class=""row"">
			<!-- Your Profile Views Chart -->
			<div class=""col-lg-12 m-b30"">
				<div class=""widget-box"">
					<div class=""wc-title"">
						<h4>افزودن دوره</h4>
					</div>
					<div class=""widget-inner"">
						");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d03f59a17754563de165c4af1b1b3f6879283bff4184", async() => {
                WriteLiteral(@"
							<div class=""row"">
								<div class=""col-12"">
									<div class=""ml-auto"">
										<h3>1. اطلاعات پایه</h3>
									</div>
								</div>
								<div class=""form-group col-6"">
									<label class=""col-form-label"">نام دوره</label>
									<div>
										<input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 903, "\"", 911, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-6\">\r\n\t\t\t\t\t\t\t\t\t<label class=\"col-form-label\">نام دوره</label>\r\n\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1110, "\"", 1118, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-6\">\r\n\t\t\t\t\t\t\t\t\t<label class=\"col-form-label\">تاریخ شروع دوره</label>\r\n\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1324, "\"", 1332, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-6\">\r\n\t\t\t\t\t\t\t\t\t<label class=\"col-form-label\">تاریخ پایان دوره</label>\r\n\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1539, "\"", 1547, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"form-group col-6\">\r\n\t\t\t\t\t\t\t\t\t<label class=\"col-form-label\">نام مدرس</label>\r\n\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 1746, "\"", 1754, 0);
                EndWriteAttribute();
                WriteLiteral(@">
									</div>
								</div>
								<div class=""seperator""></div>
								
								<div class=""col-12 m-t20"">
									<div class=""ml-auto m-b5"">
										<h3>2. توضیحات</h3>
									</div>
								</div>
								<div class=""form-group col-12"">
									<label class=""col-form-label""> توضیحات دوره</label>
									<div>
										<textarea class=""form-control""> </textarea>
									</div>
								</div>
								<div class=""col-12 m-t20"">
									<div class=""ml-auto"">
										<h3 class=""m-form__section"">3. افزودن</h3>
									</div>
								</div>
								<div class=""col-12"">
									<table id=""item-add"" style=""width:100%;"">
										<tr class=""list-item"">
											<td>
												<div class=""row"">
													<div class=""col-md-4"">
														<label class=""col-form-label"">نام دوره</label>
														<div>
															<input class=""form-control"" type=""text""");
                BeginWriteAttribute("value", " value=\"", 2677, "\"", 2685, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label class=\"col-form-label\">دسته‌بندی</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2907, "\"", 2915, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"col-md-3\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<label class=\"col-form-label\"> دسته‌بندی دوره</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<input class=\"form-control\" type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 3143, "\"", 3151, 0);
                EndWriteAttribute();
                WriteLiteral(@">
														</div>
													</div>
													<div class=""col-md-2"">
														<label class=""col-form-label"">بستن</label>
														<div class=""form-group"">
															<a class=""delete"" href=""#""><i class=""fa fa-close""></i></a>
														</div>
													</div>
												</div>
											</td>
										</tr>
									</table>
								</div>
								<div class=""col-12"">
									<button type=""button"" class=""btn-secondry add-item m-r5""><i class=""fa fa-fw fa-plus-circle""></i>افزودن</button>
									<button type=""reset"" class=""btn"">ذخیره تغییرات</button>
								</div>
							</div>
						");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t\t<!-- Your Profile Views Chart END-->\r\n\t\t</div>\r\n\t</div>\r\n</main>");
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