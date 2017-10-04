using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
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
            for(int i = 1; i< 10; i++)
            {
                 context.Note.Add(new Note
                {
                   Title = "Beispiel Titel" + i,
                   DueDate =DateTime.Now,
                   Priority = "1",
                   Text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua."
                });
            }
            context.SaveChanges();
            return Task.CompletedTask;

        }
    }
 
        
    }
}