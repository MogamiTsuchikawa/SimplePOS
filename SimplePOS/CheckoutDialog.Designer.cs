namespace SimplePOS
{
    partial class CheckoutDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            totalValueLabel = new Label();
            submitBtn = new Button();
            cancelBtn = new Button();
            inputValueBox = new TextBox();
            label2 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // totalValueLabel
            // 
            totalValueLabel.AutoSize = true;
            totalValueLabel.Font = new Font("UD デジタル 教科書体 N-R", 36F, FontStyle.Regular, GraphicsUnit.Point);
            totalValueLabel.Location = new Point(94, 36);
            totalValueLabel.Name = "totalValueLabel";
            totalValueLabel.Size = new Size(611, 83);
            totalValueLabel.TabIndex = 0;
            totalValueLabel.Text = "合計金額: 3000円";
            // 
            // submitBtn
            // 
            submitBtn.BackColor = Color.FromArgb(128, 255, 128);
            submitBtn.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            submitBtn.Location = new Point(103, 325);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(263, 103);
            submitBtn.TabIndex = 1;
            submitBtn.Text = "確定";
            submitBtn.UseVisualStyleBackColor = false;
            submitBtn.Click += submitBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.FromArgb(255, 128, 128);
            cancelBtn.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn.Location = new Point(442, 325);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(263, 103);
            cancelBtn.TabIndex = 2;
            cancelBtn.Text = "キャンセル";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // inputValueBox
            // 
            inputValueBox.Location = new Point(177, 174);
            inputValueBox.Name = "inputValueBox";
            inputValueBox.Size = new Size(189, 31);
            inputValueBox.TabIndex = 3;
            inputValueBox.KeyPress += inputValueBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 177);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 4;
            label2.Text = "受取金額";
            // 
            // button3
            // 
            button3.Location = new Point(457, 172);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "500";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(593, 171);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 6;
            button4.Text = "1000";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(457, 235);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 7;
            button5.Text = "1500";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(593, 235);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 8;
            button6.Text = "2000";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // CheckoutDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label2);
            Controls.Add(inputValueBox);
            Controls.Add(cancelBtn);
            Controls.Add(submitBtn);
            Controls.Add(totalValueLabel);
            Name = "CheckoutDialog";
            Text = "CheckoutDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalValueLabel;
        private Button submitBtn;
        private Button cancelBtn;
        private TextBox inputValueBox;
        private Label label2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}