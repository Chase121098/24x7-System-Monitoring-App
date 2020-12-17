#pragma checksum "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "009dcba1eb23014695aecbf876d79288bc54e12b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\_ViewImports.cshtml"
using SystemMonitoring;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\_ViewImports.cshtml"
using SystemMonitoring.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009dcba1eb23014695aecbf876d79288bc54e12b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"154a556c6993cd4ab2cd1d685cecaf1e22c21dfe", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SystemMonitoring.ViewModels.HomeIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("taskForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";



#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--Container for task columns-->
<div class=""text-center"">


    <div class=""card"" style=""width: 28rem; display: inline-block;"">
        <div class=""card-header"">
            <h1 style=""display:inline"">Scheduled Tasks</h1>
            <button type=""button"" class=""btn btn-secondary"" style=""display:inline;margin-left:8px;margin-bottom:15px;"" id=""addTask"">+</button>

            <div id=""popup"" style=""display:none;"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "009dcba1eb23014695aecbf876d79288bc54e12b4363", async() => {
                WriteLiteral(@"

                    <label for=""disName""> Display Name for Task </label><br />
                    <input type=""text"" name=""disName"" /><br />

                    <label for=""taskRepeat""> How often would you like this task to repeat? </label><br />
                    <input type=""radio"" id=""repeatHourly"" name=""taskRepeat"" value=""hourly"">
                    <label>Hourly</label>
                    <input type=""radio"" id=""repeatDaily"" name=""taskRepeat"" value=""daily"">
                    <label>Daily</label>
                    <input type=""radio"" id=""repeatWeekly"" name=""taskRepeat"" value=""weekly"">
                    <label>Weekly</label>
                    <input type=""radio"" id=""repeatMonthly"" name=""taskRepeat"" value=""monthly"">
                    <label>Monthly</label>

                    <label for=""taskTime"">What time would you like the task to be ran?</label> <br />
                    <input type=""radio"" id=""midnight"" name=""taskTime"" value=""midnight"">
                    <label>Mi");
                WriteLiteral(@"dnight</label>
                    <input type=""radio"" id=""noon"" name=""taskTime"" value=""noon"">
                    <label>Noon</label>
                    <input type=""radio"" id=""sixAm"" name=""taskTime"" value=""sixAm"">
                    <label>6am</label>
                    <input type=""radio"" id=""sixPm"" name=""taskTime"" value=""sixPm"">
                    <label>6pm</label> <br />

                    <button type=""submit"" id=""submitNewTask"" form=""taskForm"" class=""btn btn-primary"">Save New Task</button>

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
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n        <ul class=\"list-group list-group-flush\" id=\"taskList\">\r\n\r\n");
#nullable restore
#line 52 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml"
             foreach (var jobPanel in Model.JobResults)
            {
                //<h1>@jobPanel.Id</h1>
                //<h1>@jobPanel.TotalJobs</h1>
                //<h1>@jobPanel.TotalFailedJobs</h1>

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"list-group-item\">Id: ");
#nullable restore
#line 57 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml"
                                       Write(jobPanel.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> TotalJobs : ");
#nullable restore
#line 57 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml"
                                                                       Write(jobPanel.TotalJobs);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> TotalFailedJobs: ");
#nullable restore
#line 57 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml"
                                                                                                                   Write(jobPanel.TotalFailedJobs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 58 "C:\Users\hunte\Desktop\bsu.247monitoring\SystemMonitoring\SystemMonitoring\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>

</div> <!--End of card container-->

<script>

    var returnedData;

    $(document).ready(function () {
        $.ajax({
            url: "" https://api.covidtracking.com/v1/us/current.json"",
            type: ""GET"",
            contenttype: ""application/json; charset=utf-8"",
            data: { show: true },
            success: function (data) {
                returnedData = data;
            }
        }).done(function () {
            $(""#updateMe"").text(""API Test: "" + returnedData[0].date);

        })
    });

    $('#addTask').click(function () {
        $('#popup').toggle();
    });

    $('#submitNewTask').click(function () {
        $('#popup').toggle();

        $(""#taskList"").append('<li class=""list-group-item"">Tasks 3</li>'); //This is a proof of concept, will need to be done in $(document) before page is loaded.

    });




</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SystemMonitoring.ViewModels.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
