using Microsoft.EntityFrameworkCore;
using YellowBlog.Application.Interfaces;
using YellowBlog.Application.Services;
using YellowBlog.Domain.Interfaces;
using YellowBlog.Infrastructure.Context;
using YellowBlog.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<YellowBlogDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<IAuthorService, AuthorService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();