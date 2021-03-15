#pragma checksum "/home/nils/Developement/dotNET/bugtracker/bugtracker/Views/Dashboard/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6523dbc9b75ac74c85c89b7958f08cc95251fdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "/home/nils/Developement/dotNET/bugtracker/bugtracker/Views/_ViewImports.cshtml"
using bugtracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/nils/Developement/dotNET/bugtracker/bugtracker/Views/_ViewImports.cshtml"
using bugtracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6523dbc9b75ac74c85c89b7958f08cc95251fdd", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0f6d28711a37fcc49f3e06f268355fe7f9b568", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/home/nils/Developement/dotNET/bugtracker/bugtracker/Views/Dashboard/Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!-- Page Heading -->
<div class=""d-sm-flex align-items-center justify-content-between mb-4"">
    <h1 class=""h3 mb-0 text-gray-800"">Dashboard</h1>
</div>


<!-- Stats Row -->
<div class=""row"">

    <!-- Tickets in Progress Card -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-primary shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">
                            Tickets in Progress</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">34</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-ticket-alt fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Solving Time Card -->
    <div class=""col-xl-3 col-md");
            WriteLiteral(@"-6 mb-4"">
        <div class=""card border-left-success shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">
                            Solving Time (Average)</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">2 Days</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fas fa-hourglass-half fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Tickets Stuck Card -->
    <div class=""col-xl-3 col-md-6 mb-4"">
        <div class=""card border-left-warning shadow h-100 py-2"">
            <div class=""card-body"">
                <div class=""row no-gutters align-items-center"">
                    <div class=""col mr-2"">
                        <div class=");
            WriteLiteral(@"""text-xs font-weight-bold text-warning text-uppercase mb-1"">
                            Tickets Stuck</div>
                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">18</div>
                    </div>
                    <div class=""col-auto"">
                        <i class=""fab fa-stack-overflow fa-2x text-gray-300""></i>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Chart Row -->
<div class=""row"">

    <!-- History Chart -->
    <div class=""col-xl-8 col-lg-7"">
        <div class=""card shadow mb-4"">
            <!-- Card Header -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Solving Time History</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myAreaChart""></canvas>
                </div>
       ");
            WriteLiteral(@"     </div>
        </div>
    </div>

    <!-- Pie Chart -->
    <div class=""col-xl-4 col-lg-5"">
        <div class=""card shadow mb-4"">
            <!-- Card Header -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Tickets</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-pie pt-4 pb-2"">
                    <canvas id=""myPieChart""></canvas>
                </div>
                <div class=""mt-4 text-center small"">
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-primary""></i> In Progress
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-info""></i> Waiting
                    </span>
                    <span class=""mr-2"">
                        <i class=""fas fa-circle text-warning""></i> Stuck
           ");
            WriteLiteral(@"         </span>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Overdue Row -->
<div class=""row"">

    <!-- History Chart -->
    <div class=""col-xl-7 col-lg-6"">
        <div class=""card shadow mb-4"">
            <!-- Card Header -->
            <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                <h6 class=""m-0 font-weight-bold text-primary"">Overdue Tickets</h6>
            </div>
            <!-- Card Body -->
            <div class=""card-body"">
                <div class=""chart-area"">
                    <canvas id=""myOverdueList""></canvas>
                </div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591