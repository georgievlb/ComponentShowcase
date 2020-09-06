using ComponentShowcase.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComponentShowcase.Pages
{
    public partial class NavMenuSection : ComponentBase
    {
        [Parameter]
        public IEnumerable<NavItem> NavMenuItems { get; set; }

        [Parameter]
        public EventCallback<EventArgs> OnSelect { get; set; }
        private async Task DoStuff(EventArgs eventData)
        {
            await OnSelect.InvokeAsync(eventData);
        }
    }
}
