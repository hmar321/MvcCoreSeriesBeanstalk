using Microsoft.EntityFrameworkCore;
using MvcCoreSeriesBeanstalk.Data;
using MvcCoreSeriesBeanstalk.Models;

namespace MvcCoreSeriesBeanstalk.Repositories
{
    public class RepositorySeries
    {
        private TelevisionContext context;

        public RepositorySeries(TelevisionContext context)
        {
            this.context = context;
        }

        public async Task<List<Serie>> GetSeriesAsync()
        {
            return await this.context.Series.ToListAsync();
        }
        private async Task<int> GetMaxIdAsync()
        {
            return await this.context.Series.MaxAsync(x=>x.IdSerie)+1;
        }

        public async Task CreateSerieAsync(string nombre,string imagen,int anyo)
        {
            Serie serie = new Serie
            {
                IdSerie = await this.GetMaxIdAsync(),
                Nombre=nombre,
                Imagen=imagen,
                Anyo=anyo
            };
            this.context.Series.Add(serie);
            await this.context.SaveChangesAsync();
        }
    }
}
