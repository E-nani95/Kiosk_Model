using Kiosk_ver_1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kiosk_ver_1.Component.Products
{
    [DefaultEvent("ItemClicked")]
    public partial class ProductList : UserControl
    {
        public event EventHandler<Product> ItemClicked;
        public ProductList()
        {
            InitializeComponent();
            Items.CollectionChanged += Item_Collection;
        }

        private void Item_Collection(object sender, NotifyCollectionChangedEventArgs e)
        {
            flpnl.Controls.Clear();
            foreach (var item in Items)
            {
                var ProductCard = new ProductCard
                { 
                    ID = item.ID,
                    Title = item.Title,
                    Price = item.Price,
                    Image = item.Image,
                };
                ProductCard.Clicked += ProductCard_Clicked;
                flpnl.Controls.Add(ProductCard);
            }
        }

        private void ProductCard_Clicked(object sender, IProductCard e)
        {
            ItemClicked?.Invoke(this, new Product
            { 
             ID=e.ID,
             Title = e.Title,
             Price = e.Price,
             Image = e.Image,
            });

        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public ObservableCollection<Product> Items { get; set; } = new ObservableCollection<Product>();
    }
}
