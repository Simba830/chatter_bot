using ChatterBot.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;

namespace ChatterBot.State
{
    public interface IMainMenuItemsSet
    {
        BindingList<IMenuItemViewModel> MenuItems { get; }
        BindingList<IMenuItemViewModel> MenuOptionItems { get; }
        void Initialize(IEnumerable<IMenuItemViewModel> menuItems, IEnumerable<IMenuItemViewModel> menuOptionItems);
    }
}