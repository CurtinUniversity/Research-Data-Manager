﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Urdms.Dmp.Web.Menu;

namespace Urdms.Dmp.Web.Views.Menu
{
	using System.Collections.Generic;
	using System.Linq;

	[System.CodeDom.Compiler.GeneratedCodeAttribute("MvcRazorClassGenerator", "1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Menu/_MenuNav.cshtml")]
    public class _Page_Views_Menu__MenuNav_cshtml : Urdms.Dmp.Web.Pages.BasePage<IList<Urdms.Dmp.Web.Menu.MenuItem>>
    {
#line hidden
#line hidden
public System.Web.WebPages.HelperResult PrintMenu(IList<MenuItem> menu)
    {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {


     
    if (Model.Any()) {

WriteLiteralTo(@__razor_helper_writer, "    <ul>\r\n");


         foreach (var item in menu) {
            var cssClass = item.Selected ? "selected" : item.Children.Any() ? "has_sub_menu" : "";

WriteLiteralTo(@__razor_helper_writer, "            <li class=\"");


WriteTo(@__razor_helper_writer, cssClass);

WriteLiteralTo(@__razor_helper_writer, "\"><a href=\"");


            WriteTo(@__razor_helper_writer, Url.Content("~"+item.Path));

WriteLiteralTo(@__razor_helper_writer, "\">");


                                         WriteTo(@__razor_helper_writer, item.Title);

WriteLiteralTo(@__razor_helper_writer, "</a>\r\n");


             if (item.Selected && item.Children.Any())
	        {
                
WriteTo(@__razor_helper_writer, PrintMenu(item.Children));

                                         
	        }

WriteLiteralTo(@__razor_helper_writer, "            </li>\r\n");


        }

WriteLiteralTo(@__razor_helper_writer, "    </ul>\r\n");


    }

});

}


        public _Page_Views_Menu__MenuNav_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


Write(PrintMenu(Model));

WriteLiteral("\r\n\r\n");




        }
    }
}
