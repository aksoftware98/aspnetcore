// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "input");
            builder.AddAttribute(1, "type", "text");
            builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindMethods.GetValue(CurrentDate, "MM/dd/yyyy"));
            builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.BindMethods.SetValueHandler(__value => CurrentDate = __value, CurrentDate, "MM/dd/yyyy"));
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 3 "x:\dir\subdir\Test\TestComponent.cshtml"
            
    public DateTime CurrentDate { get; set; } = new DateTime(2018, 1, 1);

#line default
#line hidden
    }
}
#pragma warning restore 1591
