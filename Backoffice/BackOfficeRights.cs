using System.Collections.Generic;

namespace Backoffice
{
    public static class Menu
    {
        public const string Partners = "Partners";
    }
    
    public static class Actions
    {
        public const string DeleteRecordsRight = "DeleteRecords";
        public const string EditAchievementStatus = nameof(EditAchievementStatus);
    }

    public static class BackOfficeRightCache
    {
        private static readonly List<BackOfficeRight> Rights = new()
        {
            BackOfficeRight.Create(Menu.Partners, "Access to the partners menu"),
        };

        public static List<BackOfficeRight> Get() => Rights;
    }

    public class BackOfficeRight
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public static BackOfficeRight Create(string id, string name)
        {
            return new()
            {
                Id = id,
                Name = name
            };
        }
    }

    public static class MenuGenerator
    {
        //oi pack
        private static readonly List<NavsItem> MenuItems = new()
        {
            NavsItem.Create("Partners", "Partners", "list-rich", Menu.Partners),

        };
        
        public static IEnumerable<NavsItem> GenerateMenuItems() => MenuItems;
    }

    public class NavsItem
    {
        public string Name { get; set; }

        public string Href { get; set; }

        public string Icon { get; set; }

        public string Right { get; set; }

        public static NavsItem Create(string name, string href, string icon, string right)
        {
            return new()
            {
                Name = name,
                Href = href,
                Icon = icon,
                Right = right
            };
        }
    }
}