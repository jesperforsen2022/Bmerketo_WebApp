using Bmerketo_WebApp.Models.Navigation;

namespace Bmerketo_WebApp.ViewModels.Navigation
{
    public class NavLinksViewModel
    {
        public string ClassName { get; set; } = "menu-links";
        public List<NavLinkModel> Links { get; set; } = new List<NavLinkModel>();
    }
}
