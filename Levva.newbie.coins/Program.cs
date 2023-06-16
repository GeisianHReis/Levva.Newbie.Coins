using Levva.newbie.coins.Data;
using Levva.newbie.coins.Data.Interfaces;
using Levva.newbie.coins.Data.Repositories;
using Levva.newbie.coins.Logic.MapperProfiles;
using Levva.newbie.coins.Logic.Services;
using Levva.newbie.coins.Logic.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddMvc(config => 
{
    var policy = new AuthorizationPolicyBuilder()
        .RequireAuthenticatedUser()
        .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddAuthentication(x => 
    {
        x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    }).AddJwtBearer(x => 
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.Default.GetBytes(builder.Configuration.GetSection("Secret").Value)),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });

builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "apiagenda", Version = "v1" });

        c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme() 
        { 
            Name = "Authorization", 
            Type = SecuritySchemeType.ApiKey, 
            Scheme = "Bearer", 
            BearerFormat = "JWT", 
            In = ParameterLocation.Header, 
            Description = "JWT Authorization header using the Bearer scheme." +
            "\r\n\r\n Enter 'Bearer' [space] and then your token in the text input below." +
            "\r\n\r\nExample: \"Bearer 12345abcdef\"", 
        }); 
        c.AddSecurityRequirement(new OpenApiSecurityRequirement 
        { 
            { 
                    new OpenApiSecurityScheme 
                    { 
                        Reference = new OpenApiReference 
                        { 
                            Type = ReferenceType.SecurityScheme, 
                            Id = "Bearer" 
                        } 
                    }, 
                    new string[] {} 
            } 
        }); 
    });

builder.Services.AddAutoMapper(typeof(DefaulMapper));

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();

builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<ITransactionService, TransactionService>();


builder.Services.AddDbContext<Context>(options => options
    .UseSqlite(builder.Configuration
    .GetConnectionString("Default"),b => b.MigrationsAssembly("Levva.newbie.coins")));

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "levvacoins",
                      policy  =>
                      {
                          policy.WithOrigins("http://localhost:5173")
                          .AllowAnyHeader();

                      });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors("levvacoins");

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
