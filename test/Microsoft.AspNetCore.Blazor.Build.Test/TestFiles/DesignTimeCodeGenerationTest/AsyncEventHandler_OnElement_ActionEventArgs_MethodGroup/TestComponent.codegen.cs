// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 1 "x:\dir\subdir\Test\TestComponent.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#line 2 "x:\dir\subdir\Test\TestComponent.cshtml"
using Microsoft.AspNetCore.Blazor;

#line default
#line hidden
    public class TestComponent : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 219
        private void __RazorDirectiveTokenHelpers__() {
        }
        #pragma warning restore 219
        #pragma warning disable 0414
        private static System.Object __o = null;
        #pragma warning restore 0414
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            __o = Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(OnClick);
        }
        #pragma warning restore 1998
#line 4 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    Task OnClick(UIMouseEventArgs e) 
    {
        return Task.CompletedTask;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591