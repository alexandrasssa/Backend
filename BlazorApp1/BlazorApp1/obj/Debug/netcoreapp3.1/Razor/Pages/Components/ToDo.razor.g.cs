#pragma checksum "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60e72292c92580834e2de822fda632ea646d7d0d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Data.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class ToDo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>ToDo</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
                 task

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "form-inline");
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
                                                          AddTask

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(6, "\r\n\t");
                __builder2.OpenElement(7, "input");
                __builder2.AddAttribute(8, "class", "form-control mx-2");
                __builder2.AddAttribute(9, "type", "text");
                __builder2.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
                                                              task.TaskName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => task.TaskName = __value, task.TaskName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n\t");
                __builder2.AddMarkupContent(13, "<button class=\"btn btn-outline-primary mx-2\">Add Task</button>\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "progress-bar my-2 mx-2");
            __builder.AddAttribute(17, "role", "progressbar");
            __builder.AddAttribute(18, "style", "width:" + (
#nullable restore
#line 9 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
                                                                      PercentageCompleted

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.AddAttribute(19, "aria-valuemax", "100");
            __builder.AddAttribute(20, "aria-valuemin", "0");
            __builder.AddMarkupContent(21, "\r\n\t");
#nullable restore
#line 10 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
__builder.AddContent(22, PercentageCompleted);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "%\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "ul");
            __builder.AddAttribute(26, "class", "list-group my-2");
            __builder.AddMarkupContent(27, "\r\n");
#nullable restore
#line 14 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
     foreach(var taskitem in taskList)
	{
		if(taskitem.IsComplete)
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "\t\t\t");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "list-group-item list-group-item-success mx-1");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
                                                                               (() => taskitem.IsComplete=!taskitem.IsComplete)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(32, "del");
#nullable restore
#line 18 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
__builder.AddContent(33, taskitem.TaskName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 19 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
		}
		else
		{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\t\t\t");
            __builder.OpenElement(36, "li");
            __builder.AddAttribute(37, "class", "list-group-item list-group-item-secondary mx-1");
            __builder.AddAttribute(38, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
                                                                                 (() => taskitem.IsComplete=!taskitem.IsComplete)

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 22 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
__builder.AddContent(39, taskitem.TaskName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
#nullable restore
#line 23 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
		}
	}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "\t\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\Kamil\source\repos\BlazorApp1\BlazorApp1\Pages\Components\ToDo.razor"
       
	protected List<TaskModel> taskList = new List<TaskModel>();

	protected TaskModel task = new TaskModel();

	

	private void AddTask()
	{
		taskList.Add(task);
		task = new TaskModel();
	}

	public int PercentageCompleted { get { 
			return taskList.Count > 0 ? (taskList.Count(x=> x.IsComplete)*100/taskList.Count) : 0;
		}
	}


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
