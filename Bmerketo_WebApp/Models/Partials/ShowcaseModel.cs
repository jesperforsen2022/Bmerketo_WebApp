using Bmerketo_WebApp.Models.Navigation;

namespace Bmerketo_WebApp.Models.Partials
{
    public class ShowcaseModel
    {
        public string Title_1 { get; set; } = string.Empty;
        public string Title_2 { get; set; } = string.Empty;
        public string Title_3 { get; set; } = string.Empty;
        public NavLinkModel NavLink { get; set; } = new NavLinkModel();
        public string ButtonText { get; set; } = string.Empty;
        public ImageModel Image { get; set; } = new ImageModel();
    }
}
