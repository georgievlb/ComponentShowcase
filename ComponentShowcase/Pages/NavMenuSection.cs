using ComponentShowcase.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComponentShowcase.Pages
{
    public partial class NavMenuSection : ComponentBase
    {
        [Parameter]
        public IEnumerable<NavItem> NavMenuItems { get; set; }

        [Parameter]
        public EventCallback<NavItem> OnSelect { get; set; }
        private async Task OnItemSelected(NavItem item)
        {
            await OnSelect.InvokeAsync(item);
        }
    }
}
