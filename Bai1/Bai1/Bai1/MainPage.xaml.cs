using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bai1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Flower> flowers = new ObservableCollection<Flower>();
        public MainPage()
        {
            InitializeComponent();

            flowers.Add(new Flower
            {
                flowerName = "Đón Xuân",
                price = 50000,
                imageName = "cuc_9.jpg",
                description = "Hoa cúc các màu: trắng, vàng, cam"
            });

            flowers.Add(new Flower
            {
                flowerName = "Hồn nhiên",
                price = 60000,
                imageName = "cuc_2.jpg",
                description = "Hoa cúc vàng, cam, lá măng"
            });

            flowers.Add(new Flower
            {
                flowerName = "Tím thủy chung",
                price = 45000,
                imageName = "cuc_3.jpg",
                description = "Hoa cúc tím"
            });

            listFlowers.ItemsSource = flowers;
        }
    }
}
