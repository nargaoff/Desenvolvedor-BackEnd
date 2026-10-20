using Banco.Classes.Models.Contextos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Criação do banco
ContextoConta contexto = new ContextoConta();
contexto.Database.EnsureCreated();



builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
//Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes =>
{
    opcoes.SwaggerDoc("Versão 1", new Microsoft.OpenApi.OpenApiInfo
    {
        Title = "API para conta bancaria no SENAI",
        Version = "Versão 1",
        Description = "API didática para cadastrar contas bancárias com operações CRUD, use os endpoints (rotas) para listar, criar, atualizar e excluir contas",
        Contact = new Microsoft.OpenApi.OpenApiContact
        {
            Name = "César Brandão",
            Email = "cesar.brandao@senai.br",
            Url = new Uri("https://github.com/cesar-brandao")
        }

    });
});

builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    //Swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/Versão 1/swagger.json", "Banco API");
        c.DocumentTitle = "Documentação da API de contas do SENAI";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
