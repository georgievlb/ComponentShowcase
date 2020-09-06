using System.Collections.Generic;

namespace ComponentShowcase.Models
{
    public class NavItem
    {
        public NavItem? Parent { get; set; }
        public IEnumerable<NavItem>? Children { get; set; }

        public string Text { get; set; }

        public void Action()
        {

        }
    }
}
