using Microsoft.Extensions.DependencyInjection;
using TaskManagerSystem.Application.Interface.Repository;
using TaskManagerSystem.Persistance.Context;
using TaskManagerSystem.Persistance.Repository;
using MediatR;
using AutoMapper;
using System.Reflection;
using TaskManagerSystem.Application.Features.Command.CreateProject;
using TaskManagerSystem.Application.Features.Commat.CreateProject;
using TaskManagerSystem.Application.Wrapper;
using Microsoft.AspNetCore.Hosting;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<TaskManagerSystemContext>();

builder.Services.AddMediatR(typeof(Program));

//builder.Services.AddTransient<IRequestHandler<CreateProjectCommand,BaseResponse<CreateProjectCommantResponse>>,CreateProjectCommandHandler>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


builder.Services.AddScoped<IProjectRepository, ProjectRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
