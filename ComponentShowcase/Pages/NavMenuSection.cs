using ComponentShowcase.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace ComponentShowcase.Pages
{
    public partial class NavMenuSection : ComponentBase
    {
        [Parameter]
        public IEnumerable<NavItem> NavMenuItems { get; set; }
    }
}
