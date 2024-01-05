using CW1_MVC_Food_Bank_Website.Services;

using System.Net.Http.Headers;
using System.Text.Json;

/* Making JSON api objects
using HttpClient client = new();
client.DefaultRequestHeaders.Accept.Clear();
client.DefaultRequestHeaders.Accept.Add(
    new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

var repositories = await ProcessRepositoriesAsync(client);

foreach (var repo in repositories)
    Console.Write(repo.Name);

static async Task<List<Repository>> ProcessRepositoriesAsync(HttpClient client)
{
    var json = await client.GetStringAsync(
         "https://www.givefood.org.uk/api/2/foodbank/sid-valley/");

    await using Stream stream =
    await client.GetStreamAsync("https://www.givefood.org.uk/api/2/foodbank/sid-valley/");
    var repositories =
        await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
    return repositories ?? new();

    foreach (var repo in repositories ?? Enumerable.Empty<Repository>())
        Console.Write(repo.Name);
}
*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddHttpClient<FoodBankService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
