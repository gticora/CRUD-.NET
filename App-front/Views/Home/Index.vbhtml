@model RH.Presentacion.MVC_C.Models.PersonaModel

@{
    ViewBag.Title = "Home Page";
}

<div class="jumbotron">
    <h1>CRUD</h1>
</div>


@Html.BeginForm()
{ 
<div class="row">
    <div class="col-xs-6">
        <label>Id persona</label>
    </div>
    <div class="col-xs-6">
        @Html.TextBoxFor(m >= m.IdPersona, New  { @class = "form-control" })
    </div>
</div>
<br />
<div class="row">
    <div class="col-xs-6">
        <label>Nombre</label>
    </div>
    <div class="col-xs-6">
        @Html.TextBoxFor(m >= m.Nombre, New { @class = "form-control" })
    </div>
</div>
<br />
<div class="row">
    <div class="col-xs-6">
        <label>Apellido</label>
    </div>
    <div class="col-xs-6">
        @Html.TextBoxFor(m => m.Apellido, new { @class = "form-control" })
    </div>
</div>

<input type="button" name="Enviar" />
}

