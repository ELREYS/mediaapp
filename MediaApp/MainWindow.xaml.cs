using Microsoft.UI.Xaml;
using MyMediaCollection.Model;
using MyMediaCollection.Enums;
using System.Collections.Generic;
// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MediaApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private IList<MediaItem> _items { get; set; }
        private bool _isLoaded;

        public MainWindow()
        {

            this.InitializeComponent();
            PopulateData();
        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
            
        }

        public void PopulateData()
        {


            if (_isLoaded) return;
            _isLoaded = true;

            var cd = new MediaItem
            {
                Id = 1,
                Name = "Classical Favorites",
                MediaType =  ItemType.Music,
                MediumInfo = new Medium
                {
                    Id = 1,
                    MediaType = ItemType.Music,
                    Name = "CD"
                }

            };

            var book = new MediaItem
            {

                Id = 2,
                Name = "Classic Fairy Tales",
                MediaType = ItemType.Book,
                MediumInfo = new Medium
                {
                    Id = 2,
                    MediaType = ItemType.Book,
                    Name = "Book",
                }
            };

            var bluRay = new MediaItem
            {
                Id = 3,
                Name = "The Mummy",
                MediaType = ItemType.Video,
                MediumInfo = new Medium
                {
                    MediaType = ItemType.Video,
                    Name = "Blu Ray",
                }
            };

            _items = new List<MediaItem>
            {
                cd,
                book,
                bluRay,
            };

        }
    }
}


