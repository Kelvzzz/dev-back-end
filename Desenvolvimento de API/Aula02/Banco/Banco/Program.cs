using Banco.Classes.Models.Contextos;

var builder = WebApplication.CreateBuilder(args);


//Criação do banco
ContextoConta contexto = new ContextoConta();
contexto.Database.EnsureCreated();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes =>
{
    opcoes.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
    {
        Title = "API para conta bancaria no SENAI",
        Version = "1.0",
        Description = "API didática para cadsatrar contas bancárias com operações CRUD, use os endpoints (rotas) para listar, criar, atualizar e excluir contas",
        Contact = new Microsoft.OpenApi.OpenApiContact
        {
            Name = "Kelv",
            Email = "eukelvin.ati@gmail.com",
            Url = new Uri("https://github.com/Kelvzzz")
        }
    });
});



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //Swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Banco API");
        c.DocumentTitle = "Documentação da API de contas do SENAI";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
