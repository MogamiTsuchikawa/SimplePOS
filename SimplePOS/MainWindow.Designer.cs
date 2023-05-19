namespace SimplePOS
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            itemFlowLayoutPanel = new FlowLayoutPanel();
            cartItemListBox = new ListBox();
            clearButton = new Button();
            checkoutButton = new Button();
            SuspendLayout();
            // 
            // itemFlowLayoutPanel
            // 
            itemFlowLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemFlowLayoutPanel.AutoScroll = true;
            itemFlowLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemFlowLayoutPanel.BackColor = SystemColors.ControlDark;
            itemFlowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            itemFlowLayoutPanel.Location = new Point(340, 12);
            itemFlowLayoutPanel.Name = "itemFlowLayoutPanel";
            itemFlowLayoutPanel.Size = new Size(1014, 803);
            itemFlowLayoutPanel.TabIndex = 0;
            itemFlowLayoutPanel.WrapContents = false;
            // 
            // cartItemListBox
            // 
            cartItemListBox.FormattingEnabled = true;
            cartItemListBox.ItemHeight = 25;
            cartItemListBox.Location = new Point(12, 12);
            cartItemListBox.Name = "cartItemListBox";
            cartItemListBox.Size = new Size(322, 454);
            cartItemListBox.TabIndex = 1;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(255, 128, 128);
            clearButton.Font = new Font("UD デジタル 教科書体 N-R", 20F, FontStyle.Regular, GraphicsUnit.Point);
            clearButton.Location = new Point(12, 722);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(322, 93);
            clearButton.TabIndex = 2;
            clearButton.Text = "キャンセル";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // checkoutButton
            // 
            checkoutButton.BackColor = Color.FromArgb(128, 255, 255);
            checkoutButton.Font = new Font("UD デジタル 教科書体 N-R", 20F, FontStyle.Regular, GraphicsUnit.Point);
            checkoutButton.Location = new Point(12, 584);
            checkoutButton.Name = "checkoutButton";
            checkoutButton.Size = new Size(322, 93);
            checkoutButton.TabIndex = 3;
            checkoutButton.Text = "会計";
            checkoutButton.UseVisualStyleBackColor = false;
            checkoutButton.Click += checkoutButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1366, 827);
            Controls.Add(checkoutButton);
            Controls.Add(clearButton);
            Controls.Add(cartItemListBox);
            Controls.Add(itemFlowLayoutPanel);
            Name = "MainWindow";
            Text = "SimplePOS";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel itemFlowLayoutPanel;
        private ListBox cartItemListBox;
        private Button clearButton;
        private Button checkoutButton;
    }
}