﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.Reports;
    using Frapid.WebsiteBuilder;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Source.cshtml")]
    public partial class _Views_Source_cshtml : System.Web.Mvc.WebViewPage<string>
    {
        public _Views_Source_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Source.cshtml"
  
    ViewBag.Title = "Frapid Dashboard";

            
            #line default
            #line hidden
WriteLiteral("\r\n<!DOCTYPE html>\r\n<html");

WriteLiteral(" lang=\"en\"");

WriteLiteral(">\r\n<head>\r\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(@">
    <title>Frapid Report</title>
    <style>
        html, body {
            font-family: ""Segoe UI"", ""Helvetica Neue"", Arial, sans-serif;
            font-size: 12px;
            color: #444;
            cursor: default;
        }

        .report.title {
            font-size: 3em;
            text-transform: fullsize-kana;
            letter-spacing: 2px;
            text-align: center;
            font-weight: 100;
        }

        h1,h2,h3,h4,h5,h6 {
            letter-spacing: 0.1em;
            font-weight: 400;            
        }

        .gridviews table {
            width: 100%;
        }

        table {
            border: 1px solid #ddd;
            border-collapse: collapse;
        }

        table td {
            border: 1px solid #ddd;
            padding: 0.5em;
        }

        table thead tr,table tfoot tr  {
            background-color: #efefef;
            text-transform: uppercase;
            font-size: 0.87em;
        }

        table thead tr th, table tfoot tr th {
            padding: 1em;
            border: 1px solid #ddd;
        }

        table tbody tr:nth-child(odd) {
            background-color: #fafafa;
        }

        .right.aligned {
            text-align: right;
        }

        .center.aligned {
            text-align: center;
        }
    </style>
</head>
<body>
");

WriteLiteral("    ");

            
            #line 71 "..\..\Views\Source.cshtml"
Write(Html.Action("ReportMarkup", new { path = Model }));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591
