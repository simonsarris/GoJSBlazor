#pragma checksum "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "daba123ccdd867112ddb2ebf5cf1b086798fd5f1"
// <auto-generated/>
#pragma warning disable 1591
namespace GoJSBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using GoJSBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\_Imports.razor"
using GoJSBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : GoJSMinimal
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>GoJS / Blazor Minimal Sample</h1>\r\n\r\n<div id=\"myDiagramDiv\" style=\"height: 400px; width: 400px; border: 1px solid black;\"></div>\r\n\r\n<textarea id=\"mySavedModel\"></textarea>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-success");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\Pages\Index.razor"
                                          SaveDiagram

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "class", "btn btn-success");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\rjohn\source\repos\GoJSBlazor\GoJSBlazor\Pages\Index.razor"
                                          LoadDiagram

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(9, "Load");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591