using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

using Und_System.Context;
using Und_System.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddBootstrapBlazor();
builder.Services.AddScoped<CGLInsuredService>();
builder.Services.AddScoped<CGLCreditDebitServices>();
builder.Services.AddScoped<CGLPolicyHolderServices>();
builder.Services.AddScoped<CGLCoverageService>();
builder.Services.AddScoped<CGLInsuredStatusService>();
builder.Services.AddScoped<CGLUndStatusService>();
builder.Services.AddScoped<CGLSubstandardRatingService>();
builder.Services.AddScoped<CGLHealthQuestionsService>();
builder.Services.AddScoped<CGLHealthAnswerService>();
builder.Services.AddScoped<CGLBeneficiaryService>();
builder.Services.AddScoped<CGLUnderwritingUserService>();
builder.Services.AddScoped<StateService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
