using AP204_Pronia.DAL;
using AP204_Pronia.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AP204_Pronia.Services
{
    public class LayoutService
    {
        private readonly AppDbContext context;

        public LayoutService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<Setting> getData()
        {
            Setting setting = await context.settings.FirstOrDefaultAsync();

            return setting;
        }
    }
}
