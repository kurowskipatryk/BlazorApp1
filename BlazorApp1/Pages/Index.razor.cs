using BlazorApp1.Data;
using MudBlazor;

namespace BlazorApp1.Pages
{
    public partial class Index
    {
        MudTabs tabs;

        private List<User> usersList = new()
       {
           new User(){Name = "Adam", Surname="Kowalski", City="Radom", ImagePath="Images/Batman.png", Identifier="Empty"},
           new User(){Name = "Piotr", Surname="Piotrkowski", City="Radom", ImagePath="Images/Rick.png", Identifier="Empty"},
           new User(){Name = "Magda", Surname="Nowakowska", City="Warszawa", ImagePath="Images/Lena.png", Identifier="Empty"},
           new User(){Name = "Jan", Surname="Nowak", City="Radom", ImagePath="Images/Boy.png", Identifier="Empty"},
       };

        private async Task ItemUpdated(MudItemDropInfo<User> item)
        {
            item.Item.Identifier = item.DropzoneIdentifier;
        }

        //private async Task OpenTab(int selectedIndex)
        //{
        //    //tabs.ActivatePanel(selectedIndex);


        //}
    }
}
