#pragma checksum "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Areas\Admin\Views\Shared\_TopbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34bf975fe0cf2bedf0535d3b6a95f152bdca75a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared__TopbarPartial), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/_TopbarPartial.cshtml")]
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
#line 1 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Areas\Admin\Views\_ViewImports.cshtml"
using AdminLayout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Areas\Admin\Views\_ViewImports.cshtml"
using AdminLayout.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\TiBon\Desktop\DOANASP\AdminLayout\Areas\Admin\Views\_ViewImports.cshtml"
using AdminLayout.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34bf975fe0cf2bedf0535d3b6a95f152bdca75a3", @"/Areas/Admin/Views/Shared/_TopbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea7b91725ecae4beee4ec3132ed55dc0c0a6b0d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared__TopbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Top Bar -->
<nav class=""navbar"">
    <div class=""container-fluid"">
        <div class=""navbar-header"">
            <a href=""javascript:void(0);"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar-collapse"" aria-expanded=""false""></a>
            <a href=""javascript:void(0);"" class=""bars""></a>
            <a class=""navbar-brand"" href=""index.html"">ADMINBSB - MATERIAL DESIGN</a>
        </div>
        <div class=""collapse navbar-collapse"" id=""navbar-collapse"">
            <ul class=""nav navbar-nav navbar-right"">
                <!-- Call Search -->
                <li><a href=""javascript:void(0);"" class=""js-search"" data-close=""true""><i class=""material-icons"">search</i></a></li>
                <!-- #END# Call Search -->
                <!-- Notifications -->
                <li class=""dropdown"">
                    <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"">
                        <i class=""material-icons"">notifications");
            WriteLiteral(@"</i>
                        <span class=""label-count"">7</span>
                    </a>
                    <ul class=""dropdown-menu"">
                        <li class=""header"">NOTIFICATIONS</li>
                        <li class=""body"">
                            <ul class=""menu"">
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-light-green"">
                                            <i class=""material-icons"">person_add</i>
                                        </div>
                                        <div class=""menu-info"">
                                            <h4>12 new members joined</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> 14 mins ago
                                            </p>
                                        </div>
                  ");
            WriteLiteral(@"                  </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-cyan"">
                                            <i class=""material-icons"">add_shopping_cart</i>
                                        </div>
                                        <div class=""menu-info"">
                                            <h4>4 sales made</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> 22 mins ago
                                            </p>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-red");
            WriteLiteral(@""">
                                            <i class=""material-icons"">delete_forever</i>
                                        </div>
                                        <div class=""menu-info"">
                                            <h4><b>Nancy Doe</b> deleted account</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> 3 hours ago
                                            </p>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-orange"">
                                            <i class=""material-icons"">mode_edit</i>
                                        </div>
                                        <div class=""menu-info"">
                  ");
            WriteLiteral(@"                          <h4><b>Nancy</b> changed name</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> 2 hours ago
                                            </p>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-blue-grey"">
                                            <i class=""material-icons"">comment</i>
                                        </div>
                                        <div class=""menu-info"">
                                            <h4><b>John</b> commented your post</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> 4 hours ago
           ");
            WriteLiteral(@"                                 </p>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-light-green"">
                                            <i class=""material-icons"">cached</i>
                                        </div>
                                        <div class=""menu-info"">
                                            <h4><b>John</b> updated status</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> 3 hours ago
                                            </p>
                                        </div>
                                    </a>
                                </li>
                                <li>
                       ");
            WriteLiteral(@"             <a href=""javascript:void(0);"">
                                        <div class=""icon-circle bg-purple"">
                                            <i class=""material-icons"">settings</i>
                                        </div>
                                        <div class=""menu-info"">
                                            <h4>Settings updated</h4>
                                            <p>
                                                <i class=""material-icons"">access_time</i> Yesterday
                                            </p>
                                        </div>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class=""footer"">
                            <a href=""javascript:void(0);"">View All Notifications</a>
                        </li>
                    </ul>
                </li>
                <!-- #END# ");
            WriteLiteral(@"Notifications -->
                <!-- Tasks -->
                <li class=""dropdown"">
                    <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"">
                        <i class=""material-icons"">flag</i>
                        <span class=""label-count"">9</span>
                    </a>
                    <ul class=""dropdown-menu"">
                        <li class=""header"">TASKS</li>
                        <li class=""body"">
                            <ul class=""menu tasks"">
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <h4>
                                            Footer display issue
                                            <small>32%</small>
                                        </h4>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-pink"" role=");
            WriteLiteral(@"""progressbar"" aria-valuenow=""85"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 32%"">
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <h4>
                                            Make new buttons
                                            <small>45%</small>
                                        </h4>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-cyan"" role=""progressbar"" aria-valuenow=""85"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 45%"">
                                            </div>
                                        </div>
                                    </a>
                                </li>
      ");
            WriteLiteral(@"                          <li>
                                    <a href=""javascript:void(0);"">
                                        <h4>
                                            Create new dashboard
                                            <small>54%</small>
                                        </h4>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-teal"" role=""progressbar"" aria-valuenow=""85"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 54%"">
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <h4>
                                            Solve transition issue
                                            <small>65%</small");
            WriteLiteral(@">
                                        </h4>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-orange"" role=""progressbar"" aria-valuenow=""85"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 65%"">
                                            </div>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a href=""javascript:void(0);"">
                                        <h4>
                                            Answer GitHub questions
                                            <small>92%</small>
                                        </h4>
                                        <div class=""progress"">
                                            <div class=""progress-bar bg-purple"" role=""progressbar"" aria-valuenow=""85"" aria-valuemin=""0"" aria-valuemax=""100"" ");
            WriteLiteral(@"style=""width: 92%"">
                                            </div>
                                        </div>
                                    </a>
                                </li>
                            </ul>
                        </li>
                        <li class=""footer"">
                            <a href=""javascript:void(0);"">View All Tasks</a>
                        </li>
                    </ul>
                </li>
                <!-- #END# Tasks -->
                <li class=""pull-right""><a href=""javascript:void(0);"" class=""js-right-sidebar"" data-close=""true""><i class=""material-icons"">more_vert</i></a></li>
            </ul>
        </div>
    </div>
</nav>
<!-- #Top Bar -->");
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
