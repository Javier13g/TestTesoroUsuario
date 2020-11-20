#pragma checksum "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/DatosTesoro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47f58a0ca9b472335f819c3453cf962bcb644ac1"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/DatosTesoro.razor"
using TestTesoroUsuario.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/DatosTesoro.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    public partial class DatosTesoro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/home/javi/Documentos/GitHub/TestTesoroUsuario/Pages/PaginasTesoro/DatosTesoro.razor"
 
    [Parameter]
    public Guid Uid {get; set;}
    [Parameter]
    public EventCallback ChangeRL {get; set;}

    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    private string bColor = "#ffffff";
    
    private Usuarios user = new Usuarios();

    protected override async Task OnInitializedAsync(){
        var authState = await authenticationStateTask;
        user = await UserManager.GetUserAsync(authState.User);
        Uid = user.Id_Usuario;
        bColor = user.Color_Usuario;
    }

    List<TesoroUser> treasures = new List<TesoroUser>();
    TesoroUser ModalT = new TesoroUser();
    private string modalId = "tesoroModalDetalle";
    private void SetTreasureModal(TesoroUser t){
        ModalT = t;
    }
    protected override async Task OnParametersSetAsync()
    {
        await Load();
        StateHasChanged();    
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        //if(firstRender)
        StateHasChanged();
        await Load();
    }

    private async Task Load(){
            if(Uid != null)
            treasures = await IST.GetAllTreasure(Uid);
    }

    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<Usuarios> UserManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SignInManager<Usuarios> SignInManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServicioTesoro IST { get; set; }
    }
}
#pragma warning restore 1591