#pragma checksum "/Users/chen/RiderProjects/WebApplication1/WebApplication1/Pages/Management.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d93ab680b9c3935e2601681f0d662e1913ef7447"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/chen/RiderProjects/WebApplication1/WebApplication1/_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Management")]
    public partial class Management : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<head b-vuh1qt7czb><link href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css\" rel=\"stylesheet\" b-vuh1qt7czb></head>\n\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "page");
            __builder.AddAttribute(3, "b-vuh1qt7czb");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "sidebar");
            __builder.AddAttribute(6, "b-vuh1qt7czb");
            __builder.OpenComponent<WebApplication1.Shared.ManagementLayout>(7);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n");
            __builder.AddMarkupContent(9, @"<div class=""row"" b-vuh1qt7czb><div class=""col-md-4"" b-vuh1qt7czb><form b-vuh1qt7czb><p b-vuh1qt7czb>enter your imformation</p>
            <div b-vuh1qt7czb><label b-vuh1qt7czb>Name</label>
                <br b-vuh1qt7czb>
                <input placeholder=""Name"" b-vuh1qt7czb></div>
            <div b-vuh1qt7czb><label b-vuh1qt7czb>Age</label>
                <br b-vuh1qt7czb>
                <input placeholder=""Age"" b-vuh1qt7czb></div>
            <div b-vuh1qt7czb><label b-vuh1qt7czb>Country</label>
                <br b-vuh1qt7czb>
                <input placeholder=""Country"" b-vuh1qt7czb></div>
            <button b-vuh1qt7czb>Submit</button></form></div></div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
