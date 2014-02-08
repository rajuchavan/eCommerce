using System.Web.Routing;
using Orchard.Environment;
using Orchard.Localization;
using Orchard.UI.Navigation;

namespace Iota.eCommerce {
    public class AdminMenu : INavigationProvider
    {
        public Localizer T { get; set; }

        public string MenuName
        {
            get { return "admin"; }
        }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.Add(T("Iota eCommerce"), "2", BuildMenu);
        }

        private void BuildMenu(NavigationItemBuilder menu)
        {
            menu.LinkToFirstChild(false);
            menu.Add(T("Category"), "1.1", item =>
                item.Action("List", "Admin", new { area = "Contents", id = "Category" }));

            menu.Add(T("Product"), "1.2", item =>
                item.Action("List", "Admin", new { area = "Contents", id = "Product" }));

            //menu.Add(T("Movie Lookup"), "1.2", item =>
            //    item.Action("Index", "MovieLookup", new { area = "Pluralsight.Movies" }).Permission(Permissions.LookupMovie));

            //menu.Add(T("Actors"), "2.0", item =>
            //    item.Action("Index", "ActorsAdmin", new { area = "Pluralsight.Movies" }));
        }
    }
}