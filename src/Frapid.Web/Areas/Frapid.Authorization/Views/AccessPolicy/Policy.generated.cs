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
    using Frapid.Authorization;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/AccessPolicy/Policy.cshtml")]
    public partial class _Views_AccessPolicy_Policy_cshtml : System.Web.Mvc.WebViewPage<Frapid.Authorization.ViewModels.UserEntityAccessPolicy>
    {
        public _Views_AccessPolicy_Policy_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\AccessPolicy\Policy.cshtml"
  
    ViewBag.Title = "Entity Access Policy";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    <div");

WriteLiteral(" class=\"ui attached padded segment\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Entity Access Policy</div>\r\n        <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"ui vpad8 form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"three fields\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>Select a User</label>\r\n                    <select");

WriteLiteral(" id=\"UserDropdown\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral(">\r\n                        <option>Select</option>\r\n");

            
            #line 17 "..\..\Views\AccessPolicy\Policy.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 17 "..\..\Views\AccessPolicy\Policy.cshtml"
                         foreach (var item in Model.Users)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 709), Tuple.Create("\"", 729)
            
            #line 19 "..\..\Views\AccessPolicy\Policy.cshtml"
, Tuple.Create(Tuple.Create("", 717), Tuple.Create<System.Object, System.Int32>(item.UserId
            
            #line default
            #line hidden
, 717), false)
);

WriteLiteral(">");

            
            #line 19 "..\..\Views\AccessPolicy\Policy.cshtml"
                                                    Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 20 "..\..\Views\AccessPolicy\Policy.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>Select an Office</label>\r\n                    <sele" +
"ct");

WriteLiteral(" id=\"OfficeDropdown\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral(">\r\n                        <option>Select</option>\r\n");

            
            #line 27 "..\..\Views\AccessPolicy\Policy.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\AccessPolicy\Policy.cshtml"
                         foreach (var item in Model.Offices)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1174), Tuple.Create("\"", 1196)
            
            #line 29 "..\..\Views\AccessPolicy\Policy.cshtml"
, Tuple.Create(Tuple.Create("", 1182), Tuple.Create<System.Object, System.Int32>(item.OfficeId
            
            #line default
            #line hidden
, 1182), false)
);

WriteLiteral(">");

            
            #line 29 "..\..\Views\AccessPolicy\Policy.cshtml"
                                                      Write(item.OfficeCode);

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 29 "..\..\Views\AccessPolicy\Policy.cshtml"
                                                                        Write(item.OfficeName);

            
            #line default
            #line hidden
WriteLiteral(")</option>\r\n");

            
            #line 30 "..\..\Views\AccessPolicy\Policy.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>&nbsp;</label>\r\n                    <button data-ge" +
"t-policy-button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(">Load</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n   " +
"     <table");

WriteLiteral(" class=\"ui attached selector table\"");

WriteLiteral(">\r\n            <thead>\r\n            <tr>\r\n                <th>\r\n                 " +
"   Entity\r\n                </th>\r\n");

            
            #line 46 "..\..\Views\AccessPolicy\Policy.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Views\AccessPolicy\Policy.cshtml"
                 foreach (var type in Model.AccessTypes)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th>\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteAttribute("id", Tuple.Create(" id=\"", 1874), Tuple.Create("\"", 1918)
, Tuple.Create(Tuple.Create("", 1879), Tuple.Create("AccessInputCheckbox", 1879), true)
            
            #line 49 "..\..\Views\AccessPolicy\Policy.cshtml"
, Tuple.Create(Tuple.Create("", 1898), Tuple.Create<System.Object, System.Int32>(type.AccessTypeId
            
            #line default
            #line hidden
, 1898), false)
);

WriteLiteral(" data-toggle-target=\"");

            
            #line 49 "..\..\Views\AccessPolicy\Policy.cshtml"
                                                                                                           Write(type.AccessTypeId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("/>\r\n                        <label");

WriteAttribute("for", Tuple.Create(" for=\"", 1993), Tuple.Create("\"", 2038)
, Tuple.Create(Tuple.Create("", 1999), Tuple.Create("AccessInputCheckbox", 1999), true)
            
            #line 50 "..\..\Views\AccessPolicy\Policy.cshtml"
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create<System.Object, System.Int32>(type.AccessTypeId
            
            #line default
            #line hidden
, 2018), false)
);

WriteLiteral(">");

            
            #line 50 "..\..\Views\AccessPolicy\Policy.cshtml"
                                                                        Write(type.AccessTypeName);

            
            #line default
            #line hidden
WriteLiteral("</label>                       \r\n                    </th>\r\n");

            
            #line 52 "..\..\Views\AccessPolicy\Policy.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n            </thead>\r\n            <tbody>\r\n");

            
            #line 56 "..\..\Views\AccessPolicy\Policy.cshtml"
            
            
            #line default
            #line hidden
            
            #line 56 "..\..\Views\AccessPolicy\Policy.cshtml"
             foreach (var item in Model.Entities)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr");

WriteLiteral(" data-object-id=\"");

            
            #line 58 "..\..\Views\AccessPolicy\Policy.cshtml"
                               Write(item.ObjectId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 60 "..\..\Views\AccessPolicy\Policy.cshtml"
                   Write(item.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 62 "..\..\Views\AccessPolicy\Policy.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\AccessPolicy\Policy.cshtml"
                     foreach (var type in Model.AccessTypes)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <td>\r\n                            <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-type=\"");

            
            #line 65 "..\..\Views\AccessPolicy\Policy.cshtml"
                                                         Write(type.AccessTypeId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("/>\r\n                        </td>\r\n");

            
            #line 67 "..\..\Views\AccessPolicy\Policy.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tr>\r\n");

            
            #line 69 "..\..\Views\AccessPolicy\Policy.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n        <div");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral("></div>\r\n        <button data-save-button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(">Save</button>\r\n    </div>\r\n<script>\r\n    $(\"[data-toggle-target]\").change(functi" +
"on () {\r\n        var el = $(this);\r\n        var target = el.attr(\"data-toggle-ta" +
"rget\");\r\n\r\n        var state = el.prop(\"checked\");\r\n        var table = el.close" +
"st(\"table\");\r\n        var selector = \"[data-type=\" + target + \"]\";\r\n\r\n        if" +
" (!state) {\r\n            $(selector).removeAttr(\"checked\");\r\n            return;" +
"\r\n        };\r\n\r\n        table.find(selector).prop(\"checked\", true);\r\n    });\r\n\r\n" +
"    $(window).keypress(function (event) {\r\n        if (!(event.which === 115 && " +
"event.ctrlKey) && !(event.which === 19)) return true;\r\n        save();\r\n        " +
"event.preventDefault();\r\n        return false;\r\n    });\r\n\r\n    function save() {" +
"\r\n        function request(officeId, userId, model) {\r\n            var url = \"/d" +
"ashboard/authorization/entity-access/user-policy/{officeId}/{userId}\";\r\n\r\n      " +
"      url = url.replace(\"{officeId}\", officeId);\r\n            url = url.replace(" +
"\"{userId}\", userId);\r\n\r\n            var data = JSON.stringify(model);\r\n\r\n       " +
"     return window.getAjaxRequest(url, \"POST\", data);\r\n        };\r\n\r\n        var" +
" confirmed = window.confirmAction();\r\n        if (!confirmed) {\r\n            ret" +
"urn;\r\n        };\r\n\r\n        var userId = parseInt($(\"#UserDropdown\").val() || 0)" +
";\r\n        var officeId = parseInt($(\"#OfficeDropdown\").val() || 0);\r\n\r\n        " +
"if (!userId || !officeId) {\r\n            return;\r\n        };\r\n\r\n        var mode" +
"l = [];\r\n\r\n        $(\"table tbody tr\").each(function() {\r\n            var row = " +
"$(this);\r\n            var objectId = row.attr(\"data-object-id\");\r\n\r\n            " +
"var members = row.find(\"input[type=checkbox]\");\r\n            $.each(members, fun" +
"ction() {\r\n                var el = $(this);\r\n\r\n                var allowed = el" +
".is(\":checked\");\r\n\r\n                if (allowed) {\r\n                    var acce" +
"ssTypeId = el.attr(\"data-type\");\r\n\r\n                    model.push({\r\n          " +
"              EntityName: objectId,\r\n                        AccessTypeId: acces" +
"sTypeId,\r\n                        AllowAccess: allowed\r\n                    });\r" +
"\n                };\r\n            });\r\n\r\n        });\r\n\r\n\r\n        var ajax = requ" +
"est(officeId, userId, model);\r\n\r\n        ajax.success(function () {\r\n           " +
" window.displaySuccess();\r\n        });\r\n\r\n        ajax.fail(function (xhr) {\r\n  " +
"          window.logAjaxErrorMessage(xhr);\r\n        });\r\n    };\r\n\r\n    $(\"[data-" +
"save-button]\").off(\"click\").on(\"click\", function () {\r\n        save();\r\n    });\r" +
"\n\r\n\r\n    $(\"[data-get-policy-button]\").off(\"click\").on(\"click\", function () {\r\n " +
"       function request(officeId, userId) {\r\n            var url = \"/dashboard/a" +
"uthorization/entity-access/user-policy/{officeId}/{userId}\";\r\n            url = " +
"url.replace(\"{officeId}\", officeId);\r\n            url = url.replace(\"{userId}\", " +
"userId);\r\n\r\n            return window.getAjaxRequest(url);\r\n        };\r\n\r\n      " +
"  var userId = parseInt($(\"#UserDropdown\").val() || 0);\r\n        var officeId = " +
"parseInt($(\"#OfficeDropdown\").val() || 0);\r\n\r\n        if (!userId || !officeId) " +
"{\r\n            return;\r\n        };\r\n\r\n        var ajax = request(officeId, userI" +
"d);\r\n\r\n        ajax.success(function (response) {\r\n            $(\"table input[ty" +
"pe=checkbox]\").removeAttr(\"checked\");\r\n\r\n            $.each(response, function (" +
") {\r\n                var selector = \"tr[data-object-id=\\\"{entityName}\\\"]\";\r\n    " +
"            selector = selector.replace(\"{entityName}\", this.EntityName);\r\n\r\n   " +
"             var row = $(selector);\r\n                selector = \"[data-type=\\\"{a" +
"ccessTypeId}\\\"]\";\r\n                selector = selector.replace(\"{accessTypeId}\"," +
" this.AccessTypeId);\r\n\r\n                var target = row.find(selector);\r\n\r\n    " +
"            if (this.AllowAccess) {\r\n                    target.prop(\"checked\", " +
"true);\r\n                };\r\n            });\r\n        });\r\n\r\n    });\r\n\r\n</script>" +
"");

        }
    }
}
#pragma warning restore 1591
