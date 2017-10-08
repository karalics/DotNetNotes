using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using DotNetNotes.Models;
using DotNetNotes.Data;

namespace DotNetNotes.Services
{
    public class DataService : IDataService
    {
        private readonly IServiceProvider _provider;
 
        public DataService(IServiceProvider serviceProvider)
        {
            _provider = serviceProvider;
        }
 
        public Task CreateTestData()
    {
        using (var serviceScope = _provider.GetService<IServiceScopeFactory>().CreateScope())
        {
            var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
            for(int i = 1; i < 6; i++)
            {
                 context.Note.Add(new Note
                {
                   Title = "Eintrag Nummer " + i,
                   DueDate =DateTime.Now.AddDays(-i),
                   Priority = i,
                   Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua."
                });
            }
            context.SaveChanges();
            return Task.CompletedTask;

        }
    }
 
        
    }
}