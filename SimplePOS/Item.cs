using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePOS
{
    public partial class Item : UserControl
    {
        private string _id;
        public string ItemId
        {
            get => _id;
            set
            {
                _id = value;
                SetImage(_id);
            }
        }
        public string ItemName { get => itemNameLabel.Text; set => itemNameLabel.Text = value; }
        public int ItemValue
        {
            get => _itemValue;
            set
            {
                _itemValue = value;
                itemValueLabel.Text = $"{value}円";
            }
        }
        private int _itemValue;
        public string ItemSellerName { get => sellerLabel.Text; set => sellerLabel.Text = value; }
        public Action<string> onAddCart;
        public Item()
        {
            InitializeComponent();
        }

        private void Item_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            onAddCart(ItemId);
        }
        private void SetImage(string id)
        {
            var files = Directory.GetFiles("images");

            var target = files.ToList().Find(f => f.IndexOf(id) != -1);
            if (target == null) return;
            itemPictureBox.Load(target);
        }
    }
    public class ItemData
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
        public string SellerName { get; set; }
    }
}
