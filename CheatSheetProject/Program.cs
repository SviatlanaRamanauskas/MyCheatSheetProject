using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

/*
 * CheatSheetProject.Repositories.Migrations.run();
CheatSheetProject.Repositories.TopicRepository.AddNewTopic("For loop");
CheatSheetProject.Repositories.TopicRepository.AddNewTopic("if statement");
CheatSheetProject.Repositories.TopicRepository.AddNewTopic("while");
var topics = CheatSheetProject.Repositories.TopicRepository.GetAllTopics();
var firstTopic = CheatSheetProject.Repositories.TopicRepository.GetTopic(topics[0].Id);
Console.WriteLine(firstTopic);
if (firstTopic != null)
{
    CheatSheetProject.Repositories.TopicRepository.UpdateNameById(firstTopic.Id, "Cheat Sheet Project");
}
firstTopic = CheatSheetProject.Repositories.TopicRepository.GetTopic(topics[0].Id);
CheatSheetProject.Repositories.TopicRepository.UpdateNameById(firstTopic.Id, "Cheat Sheet Project");
CheatSheetProject.Repositories.TopicRepository.DeleteTopicByName("if statement");*/
/*var cheatSheetItem = new CheatSheetProject.Models.CheatSheetItem()
{
    Name = "if else",
    CodeSnippet = "if (a < b) {... code} else {... some code} ",
    AdditionalInfo = "a",
   // TopicId = "c59112a5-9d20-4aa9-87d5-5d3851534738"
};*/
//CheatSheetProject.Repositories.CheatSheetItemRepository.AddNewCheatSheetItem(cheatSheetItem, "c59112a5-9d20-4aa9-87d5-5d3851534738");
//CheatSheetProject.Repositories.CheatSheetItemRepository.UpdateItemById("ce73c9ee-e29a-4190-99ef-14557567fd4a", cheatSheetItem);
//CheatSheetProject.Repositories.CheatSheetItemRepository.DeleteItemById("ce73c9ee-e29a-4190-99ef-14557567fd4a");
//var item = CheatSheetProject.Repositories.CheatSheetItemRepository.GetItem("ce73c9ee-e29a-4190-99ef-14557567fd4a");
//var allItems = CheatSheetProject.Repositories.CheatSheetItemRepository.GetAllItems();
//var allItemsById = CheatSheetProject.Repositories.CheatSheetItemRepository.GetAllItemsByTopicId("32fa4115-2d75-4cb0-8c29-3007077ff541");
 /*var usefulLink = new CheatSheetProject.Models.UsefulLink()
    {
        LinkAddress = "w3school",
        LinkOrder = 2,
        CheatSheetItemId = "1531eab1-5dbb-45fa-89d9-f8f76e0543e0"
    };*/
//CheatSheetProject.Repositories.UsefulLinkRepository.AddNewUsefulLink(usefulLink, "1531eab1-5dbb-45fa-89d9-f8f76e0543e0");
//CheatSheetProject.Repositories.UsefulLinkRepository.UpdateLinkById("82eed8c6-e9c1-4ef2-86e4-42337d3617df", usefulLink);
//CheatSheetProject.Repositories.UsefulLinkRepository.DeleteLinkById("3bc6c371-349c-4a09-a77c-de19e3679ee9");
//var allLinks = CheatSheetProject.Repositories.UsefulLinkRepository.GetAllLinks();

//var allLinksByItemId = CheatSheetProject.Repositories.UsefulLinkRepository.GetAllUsefulLinksByItemId("013b626f-abd3-4232-a230-80862a0e047a");
//var link = CheatSheetProject.Repositories.UsefulLinkRepository.GetLink("82eed8c6-e9c1-4ef2-86e4-42337d3617df");

var topicWithAllData = CheatSheetProject.Repositories.TopicRepository.GetTopicWithAllItems("32fa4115-2d75-4cb0-8c29-3007077ff541");

app.Run();
