﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using NewLife;
    using NewLife.Cube;
    
    #line 1 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
    using NewLife.Cube.Extensions;
    
    #line default
    #line hidden
    using NewLife.Reflection;
    using NewLife.Web;
    using XCode;
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Log/_List_Search.cshtml")]
    public partial class _Areas_Admin_Views_Log__List_Search_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Areas_Admin_Views_Log__List_Search_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 7 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.ActionLink("访问统计", "Index", "VisitStat", null, new { @class = "btn btn-success btn-sm" }));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <label");

WriteLiteral(" for=\"category\"");

WriteLiteral(" class=\"control-label\"");

WriteLiteral(">类别：</label>\r\n");

WriteLiteral("    ");

            
            #line 9 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.ForDropDownList("category", Log.FindAllCategoryName(), page["category"], "全部", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

            
            #line 11 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.Partial("_SelectUser", "userId"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..\Areas\Admin\Views\Log\_List_Search.cshtml"
Write(Html.Partial("_DateRange"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
