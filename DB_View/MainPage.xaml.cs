using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


namespace DB_View
{
    /// <summary>
    /// The primary viewer interface
    /// </summary>
    public sealed partial class MainPage : Page
    {

        Database _database = new Database();

        public MainPage()
        {
            this.InitializeComponent();

            /* These fields are all going to be filled in by the database
            name.Text = "Component Name";
            description.Text = "This is a description. It should stay pretty concise; extended info belongs in the notes section.";

            BitmapImage placeholder = new BitmapImage(new Uri(this.BaseUri, "/Assets/Square150x150Logo.png"));
            symbol.Source = placeholder;
            footprint.Source = placeholder;

            notes.Text = "This is a longer description of this component. Or it doesn't have to be - this is the 'uncatagorized' space.";
            applications.Text = "This is a list of products this component has been used in.";

            manufacturer.Text = "Aperture Science";
            manufacturer_part_number.Text = "BLACKMESASUX";

            supplier.Text = "Acme Corp.";
            supplier_part_number.Text = "BEEPBEEP";
            price.Text = "like, a billion";
            */
        }

        private async void OnClickBrowse( object sender, RoutedEventArgs e )
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker
            {
                SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary,
                ViewMode = Windows.Storage.Pickers.PickerViewMode.List
            };
            picker.FileTypeFilter.Add(".accdb");
            _database.LoadFile(await picker.PickSingleFileAsync());
            db_filename.Text = _database.GetPath();

            name.Text = _database.GetName();
            description.Text = _database.GetDescription();
            notes.Text = _database.GetNotes();
            manufacturer.Text = _database.GetManufacturer();
            supplier.Text = _database.GetSupplier();
        }

        void OnClickSearch(object sender, RoutedEventArgs e)
        {
            // open a search window
        }
    }
}
