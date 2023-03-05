using Bmerketo_WebApp.Models.Navigation;

namespace Bmerketo_WebApp.ViewModels.Navigation
{
    public class LinksViewModel
    {
        public string ClassName { get; set; } = "link";
        public List<LinkModel> Links { get; set; } = new List<LinkModel>();
    }
}
