using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

// No do professor usa esse próximo using mas no nosso o compilador reclama
//using WebAPIAuth;

var builder = WebApplication.CreateBuilder(args);

// Chave convertida para bytes
var chave = Encoding.ASCII.GetBytes(Ambiente.Chave);

// Add services to the container.

// Adicionando os serviços de autenticação
builder.Services
    .AddAuthentication(config =>
    {
        config.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        config.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }
    )
    .AddJwtBearer(config =>

    {
        config.RequireHttpsMetadata = false;
        config.SaveToken = true;
        config.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(chave),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Adicionando autenticação e autorização
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
