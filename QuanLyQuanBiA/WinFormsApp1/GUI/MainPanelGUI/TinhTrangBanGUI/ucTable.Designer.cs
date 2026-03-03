namespace WinFormsApp1.GUI.MainPanel.TinhTrangBanGUI
{
    partial class ucTable
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
            pctTable = new PictureBox();
            lblName = new Label();
            lblPrice = new Label();
            btnOrderTable = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pctTable).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pctTable
            // 
            pctTable.BorderStyle = BorderStyle.FixedSingle;
            pctTable.Location = new Point(4, 12);
            pctTable.Name = "pctTable";
            pctTable.Size = new Size(116, 93);
            pctTable.TabIndex = 0;
            pctTable.TabStop = false;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblName.AutoSize = true;
            lblName.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(17, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(48, 19);
            lblName.TabIndex = 1;
            lblName.Text = "Bàn 1";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(17, 29);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(69, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "50.000 VNĐ";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOrderTable
            // 
            btnOrderTable.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderTable.Location = new Point(0, 47);
            btnOrderTable.Name = "btnOrderTable";
            btnOrderTable.Size = new Size(114, 25);
            btnOrderTable.TabIndex = 3;
            btnOrderTable.Text = "Mở Bàn";
            btnOrderTable.UseVisualStyleBackColor = true;
            btnOrderTable.Click += btnOrderTable_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(btnOrderTable);
            panel1.Controls.Add(lblPrice);
            panel1.Location = new Point(4, 110);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(116, 74);
            panel1.TabIndex = 4;
            // 
            // ucTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(125, 195);
            Controls.Add(panel1);
            Controls.Add(pctTable);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ucTable";
            Text = "ucTable";
            ((System.ComponentModel.ISupportInitialize)pctTable).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pctTable;
        private Label lblName;
        private Label lblPrice;
        private Button btnOrderTable;
        private Panel panel1;
    }
}