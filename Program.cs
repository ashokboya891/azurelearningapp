var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
// builder.Configuration.AddAzureAppConfiguration("Endpoint=https://applicationconfigwebapps.azconfig.io;Id=sWlo;Secret=7r5G7196XXNErI1Xl1Ytz8aRHfcJgxak9dklFH1yPoyS6o8VrJRtJQQJ99ALACBsN5437ao2AAACAZAC2npp");
// .AddJsonFile("appsettings.json")
//     .AddEnvironmentVariables();

builder.Configuration
.AddJsonFile("appsettings.json")
    .AddEnvironmentVariables();
    
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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
