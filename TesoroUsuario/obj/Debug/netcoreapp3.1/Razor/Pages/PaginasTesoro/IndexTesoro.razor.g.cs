#pragma checksum "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd13830df94e278c6de05bb672f5e4621581765c"
// <auto-generated/>
#pragma warning disable 1591
namespace TestTesoroUsuario.Pages.PaginasTesoro
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using TestTesoroUsuario;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/javi/Documentos/GitHub/TestTesoroUsuario/_Imports.razor"
using TestTesoroUsuario.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor"
using TestTesoroUsuario.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor"
using TestTesoroUsuario.Pages.PaginasTesoro;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/indexTesoro")]
    public partial class IndexTesoro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-xs-12");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenComponent<TestTesoroUsuario.Pages.PaginasTesoro.TesorosAgg>(3);
            __builder.AddAttribute(4, "Uid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 8 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor"
                     userId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n<br>\n");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenComponent<TestTesoroUsuario.Pages.PaginasTesoro.DatosTesoro>(9);
            __builder.AddAttribute(10, "Uid", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Guid>(
#nullable restore
#line 12 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor"
                      userId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/IndexTesoro.razor"
 
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private Usuarios usu = new Usuarios();
    private Guid userId;

    private void evnt(){
        Console.WriteLine("enento");
    }

    protected override async Task OnInitializedAsync()
    {
        var authState = await authenticationStateTask;
        usu = await UserManager.GetUserAsync(authState.User);
        userId = usu.Id_Usuario;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuarios> UserManager { get; set; }
    }
}
#pragma warning restore 1591
