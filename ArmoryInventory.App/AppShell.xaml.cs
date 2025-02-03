using ArmoryInventory.App.Views;

namespace ArmoryInventory.App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            //Routing
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(AddItemPage), typeof(AddItemPage));
            Routing.RegisterRoute(nameof(ViewItemPage), typeof(ViewItemPage));
        }
    }
}
