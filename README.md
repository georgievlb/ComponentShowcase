# Component showcase

This project is a showcase of Blazor components. 

## Navigation menu
The first component, `<NavMenu>`, is a nested navigation dropdown menu.

The component exposes two properties: `Items` and `OnItemSelected`.

The `Items` property is a collection of type `Enumerable<NavItem>`. The model for the collection is located under `Models/NavItem.cs`.

The `OnItemSelected` property expects a callback method as a parameter. In the showcase application, the sample `ShowElementData` method is used. It simply prints the `Text` property of the passed `NavItem`.