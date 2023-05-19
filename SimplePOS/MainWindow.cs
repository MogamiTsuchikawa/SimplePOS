using System.Drawing.Printing;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;

namespace SimplePOS
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public static List<ItemData> itemList = new List<ItemData>();
        private List<Item> itemCtrls = new List<Item>();
        public static List<string> cartList = new List<string>();

        private void 登録ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 削除ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void AddCart(string itemId)
        {
            var targetItem = itemList.Find(i => i.Id == itemId);
            cartItemListBox.Items.Add($"{targetItem.Name}:{targetItem.Value}円");
            cartList.Add(itemId);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var items = JsonSerializer.Deserialize<List<ItemData>>(File.ReadAllText("items.json"));
            if (items == null)
            {
                MessageBox.Show("items.jsonが見つかりません");
                return;
            }
            itemList = items;
            foreach (var item in items)
            {
                itemFlowLayoutPanel.Controls.Add(
                    new Item()
                    {
                        ItemId = item.Id,
                        ItemName = item.Name,
                        ItemSellerName = item.SellerName,
                        ItemValue = item.Value,
                        onAddCart = AddCart
                    });
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            int totalValue = cartList.Select(c => (itemList.Find(i => i.Id == c) ?? itemList.First()).Value).Sum();
            CheckoutDialog checkoutDialog = new(totalValue);
            checkoutDialog.OnSubmit = (inputValue) =>
            {
                Print(inputValue, totalValue);
                MessageBox.Show($"おつり:{inputValue - totalValue}円");
            };
            checkoutDialog.ShowDialog();

            cartList.Clear();
            cartItemListBox.Items.Clear();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cartList.Clear();
            cartItemListBox.Items.Clear();
        }
        private void Print(int inputValue, int totalValue)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler((sender, e) =>
            {
                Font logoFont = new Font("メイリオ", 30f);
                Font font = new Font("メイリオ", 10.5f);
                Brush brush = new SolidBrush(Color.Black);
                e.Graphics.DrawString($"デジクリ", logoFont, brush, new PointF(0, 10));
                int y = 80;
                e.Graphics.DrawString($"{DateTime.Now.ToLocalTime().ToString()}", font, brush, new PointF(10, y));
                y += 30;
                e.Graphics.DrawString($"★購入品目★", font, brush, new PointF(10, y));
                y += 20;
                cartList.Sort();
                var items = cartList.Select(c => (itemList.Find(i => i.Id == c) ?? itemList.First())).ToList();
                var gResult = items.GroupBy(i => i.Name);
                foreach (var group in gResult)
                {
                    e.Graphics.DrawString($"{group.Key} x {group.Count()}", font, brush, new PointF(10, y));
                    y += 20;
                }
                y += 20;
                e.Graphics.DrawString($"合計金額 {totalValue}円", font, brush, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString($"支払金額 {inputValue}円", font, brush, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString($"おつり {inputValue - totalValue}円", font, brush, new PointF(10, y));
                y += 30;
                e.Graphics.DrawString($"上記正に領収いたしました", font, brush, new PointF(10, y));
                y += 40;
                e.Graphics.DrawString($"デジクリでは新入部員を募集中！", font, brush, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString($"気になる方は以下サイトへ", font, brush, new PointF(10, y));
                y += 20;
                e.Graphics.DrawString($"https://digicre.net/welcome", font, brush, new PointF(10, y));
                y += 40;
                e.Graphics.DrawString($"このPOSレジシステムのコードはOSSです", font, brush, new PointF(10, y));
                y += 40;
                e.Graphics.DrawString($"", font, brush, new PointF(10, y));

            });
            pd.Print();
        }
    }
}