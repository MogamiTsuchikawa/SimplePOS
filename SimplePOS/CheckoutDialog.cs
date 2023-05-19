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
    public partial class CheckoutDialog : Form
    {
        private int _totalValue;
        public CheckoutDialog(int totalValue)
        {
            InitializeComponent();
            _totalValue = totalValue;
            totalValueLabel.Text = $"合計金額:{totalValue}円";
        }

        public Action<int> OnSubmit { get; set; }

        private void inputValueBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            int value = 0;
            try
            {
                value = int.Parse(inputValueBox.Text);
                if (value < _totalValue) throw new Exception();
            }
            catch
            {
                MessageBox.Show("値段が不正です");
                return;
            }
            this.DialogResult = DialogResult.OK;
            OnSubmit(value);


            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            inputValueBox.Text = "500";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            inputValueBox.Text = "1000";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            inputValueBox.Text = "1500";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            inputValueBox.Text = "2000";
        }
    }
}
