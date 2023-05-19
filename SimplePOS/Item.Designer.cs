namespace SimplePOS
{
    partial class Item
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            itemNameLabel = new Label();
            itemPictureBox = new PictureBox();
            itemValueLabel = new Label();
            sellerLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)itemPictureBox).BeginInit();
            SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new Point(459, 24);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new Size(66, 25);
            itemNameLabel.TabIndex = 0;
            itemNameLabel.Text = "商品名";
            itemNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // itemPictureBox
            // 
            itemPictureBox.Location = new Point(3, 3);
            itemPictureBox.Name = "itemPictureBox";
            itemPictureBox.Size = new Size(319, 188);
            itemPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            itemPictureBox.TabIndex = 1;
            itemPictureBox.TabStop = false;
            // 
            // itemValueLabel
            // 
            itemValueLabel.AutoSize = true;
            itemValueLabel.Location = new Point(459, 73);
            itemValueLabel.Name = "itemValueLabel";
            itemValueLabel.Size = new Size(48, 25);
            itemValueLabel.TabIndex = 2;
            itemValueLabel.Text = "値段";
            itemValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sellerLabel
            // 
            sellerLabel.AutoSize = true;
            sellerLabel.Location = new Point(459, 124);
            sellerLabel.Name = "sellerLabel";
            sellerLabel.Size = new Size(48, 25);
            sellerLabel.TabIndex = 3;
            sellerLabel.Text = "値段";
            sellerLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 24);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 4;
            label1.Text = "商品名";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 73);
            label2.Name = "label2";
            label2.Size = new Size(48, 25);
            label2.TabIndex = 5;
            label2.Text = "値段";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(348, 124);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 6;
            label3.Text = "出品者";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Location = new Point(685, 8);
            button1.Name = "button1";
            button1.Size = new Size(171, 183);
            button1.TabIndex = 7;
            button1.Text = "カートへ追加";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(sellerLabel);
            Controls.Add(itemValueLabel);
            Controls.Add(itemPictureBox);
            Controls.Add(itemNameLabel);
            Name = "Item";
            Size = new Size(859, 198);
            Load += Item_Load;
            ((System.ComponentModel.ISupportInitialize)itemPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label itemNameLabel;
        private PictureBox itemPictureBox;
        private Label itemValueLabel;
        private Label sellerLabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
