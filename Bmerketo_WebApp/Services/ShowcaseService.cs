using Bmerketo_WebApp.Models.Navigation;
using Bmerketo_WebApp.Models;
using AutoMapper;
using Bmerketo_WebApp.Contexts;
using Bmerketo_WebApp.Models.Partials;
using Microsoft.EntityFrameworkCore;

namespace Bmerketo_WebApp.Services
{
    public class ShowcaseService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public ShowcaseService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ShowcaseModel> GetLatestShowcase()
        {
            return _mapper.Map<ShowcaseModel>(
                    await _context.Showcases
                        .Include(x => x.NavLink)
                        .Include(x => x.Image)
                        .OrderByDescending(x => x.Id)
                        .FirstOrDefaultAsync()
                );
        }
    }
}
