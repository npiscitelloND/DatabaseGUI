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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DB_View
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();

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
        }

        private async void OnClickBrowse( object sender, RoutedEventArgs e )
        {
            var picker = new Windows.Storage.Pickers.FileOpenPicker();
            picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
            picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.List;
            picker.FileTypeFilter.Add("*");
            Windows.Storage.StorageFile file = await picker.PickSingleFileAsync();
            
            if( file != null)
            {
                db_filename.Text = file.Name;
            }
            
        }

        void OnClickSearch(object sender, RoutedEventArgs e)
        {
            // open a search window
        }
    }
}
