﻿using ComponentShowcase.Models;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ComponentShowcase.Pages
{
    public partial class NavMenu : ComponentBase
    {
        [Parameter]
        public IEnumerable<NavItem> Items { get; set; }

        [Parameter]
        public EventCallback<NavItem> OnItemSelected { get; set; }

        private async Task NotifyComponentUser(NavItem item)
        {
            await OnItemSelected.InvokeAsync(item);
        }

        public static IEnumerable<NavItem> TestItems = new List<NavItem>()
            {
                new NavItem
                {
                    Text = "Item 1", Children = new List<NavItem>()
                    {
                        new NavItem { Text = "Item 1.1" },
                        new NavItem
                        {
                            Text = "Item 1.2", Children = new List<NavItem>
                            {
                                new NavItem {Text = "Item 1.2.1" },
                                new NavItem
                                {
                                    Text = "Item 1.2.2", Children = new List<NavItem>()
                                    {
                                        new NavItem()
                                        {
                                            Text = "Item 1.2.2.1",
                                            Children = new List<NavItem>()
                                            {
                                                new NavItem()
                                                {
                                                    Text = "Item 1.2.2.1.1"
                                                }
                                            }
                                        },
                                        new NavItem()
                                        {
                                            Text = "Item 1.2.2.2"
                                        }
                                    }
                                }
                            }
                        },
                        new NavItem
                        {
                            Text = "Item 1.3", Children = new List<NavItem>
                            {
                                new NavItem
                                {
                                    Text = "Item 1.3.1"
                                    , Children = new List<NavItem>()
                                    {
                                        new NavItem()
                                    {
                                        Text = "Item 1.3.1.1"}
                                    }
                                }
                            }
                        }
                    }
                },
                new NavItem
                {
                    Text = "Item 2",
                },
                new NavItem
                {
                    Text = "Item 3", Children = new List<NavItem>
                            {
                                new NavItem
                                {
                                    Text = "Item 3.1"
                                    , Children = new List<NavItem>()
                                    {
                                        new NavItem()
                                    {
                                        Text = "Item 3.1.1"}
                                    }
                                }
                            }
                }
            };
    }
}
