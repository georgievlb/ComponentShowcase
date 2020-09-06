using System.Collections.Generic;

namespace ComponentShowcase.Models
{
    public class NavItem
    {
        public IEnumerable<NavItem>? Children { get; set; }

        public string Text { get; set; }
    }
}
