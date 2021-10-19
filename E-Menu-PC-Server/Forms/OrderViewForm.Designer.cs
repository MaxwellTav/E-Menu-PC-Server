
namespace E_Menu_PC_Server.Forms
{
    partial class OrderViewForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.Cancel_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName_Label = new System.Windows.Forms.Label();
            this.NoOrder_Label = new System.Windows.Forms.Label();
            this.Invoice_Button = new Guna.UI2.WinForms.Guna2Button();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BackgroundPanel.Controls.Add(this.Cancel_Button);
            this.BackgroundPanel.Controls.Add(this.DGV);
            this.BackgroundPanel.Controls.Add(this.ClientName_Label);
            this.BackgroundPanel.Controls.Add(this.NoOrder_Label);
            this.BackgroundPanel.Controls.Add(this.Invoice_Button);
            this.BackgroundPanel.Location = new System.Drawing.Point(1, 1);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(724, 350);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Animated = true;
            this.Cancel_Button.CheckedState.Parent = this.Cancel_Button;
            this.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_Button.CustomImages.Parent = this.Cancel_Button;
            this.Cancel_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Cancel_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.HoverState.Parent = this.Cancel_Button;
            this.Cancel_Button.Location = new System.Drawing.Point(0, 281);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.ShadowDecoration.Parent = this.Cancel_Button;
            this.Cancel_Button.Size = new System.Drawing.Size(199, 67);
            this.Cancel_Button.TabIndex = 7;
            this.Cancel_Button.Text = "Volver";
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemCuantity,
            this.ItemPriceUnity,
            this.ItemPriceTotal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.Enabled = false;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.DGV.Location = new System.Drawing.Point(0, 72);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 40;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(722, 208);
            this.DGV.TabIndex = 5;
            this.DGV.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.DGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.DGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.DGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGV.ThemeStyle.HeaderStyle.Height = 23;
            this.DGV.ThemeStyle.ReadOnly = true;
            this.DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV.ThemeStyle.RowsStyle.Height = 22;
            this.DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ItemID
            // 
            this.ItemID.FillWeight = 50.76142F;
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 124.8528F;
            this.ItemName.HeaderText = "Nombre del artículo";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemCuantity
            // 
            this.ItemCuantity.FillWeight = 74.68003F;
            this.ItemCuantity.HeaderText = "Cantidad";
            this.ItemCuantity.Name = "ItemCuantity";
            this.ItemCuantity.ReadOnly = true;
            // 
            // ItemPriceUnity
            // 
            this.ItemPriceUnity.FillWeight = 124.8528F;
            this.ItemPriceUnity.HeaderText = "Precio (unidad)";
            this.ItemPriceUnity.Name = "ItemPriceUnity";
            this.ItemPriceUnity.ReadOnly = true;
            // 
            // ItemPriceTotal
            // 
            this.ItemPriceTotal.FillWeight = 124.8528F;
            this.ItemPriceTotal.HeaderText = "Precio (total)";
            this.ItemPriceTotal.Name = "ItemPriceTotal";
            this.ItemPriceTotal.ReadOnly = true;
            // 
            // ClientName_Label
            // 
            this.ClientName_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientName_Label.Enabled = false;
            this.ClientName_Label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName_Label.Location = new System.Drawing.Point(224, 4);
            this.ClientName_Label.Name = "ClientName_Label";
            this.ClientName_Label.Size = new System.Drawing.Size(488, 65);
            this.ClientName_Label.TabIndex = 3;
            this.ClientName_Label.Text = "Cliente\r\n\"Maxwell Tavares\"";
            this.ClientName_Label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // NoOrder_Label
            // 
            this.NoOrder_Label.AutoSize = true;
            this.NoOrder_Label.Enabled = false;
            this.NoOrder_Label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOrder_Label.Location = new System.Drawing.Point(1, 19);
            this.NoOrder_Label.Name = "NoOrder_Label";
            this.NoOrder_Label.Size = new System.Drawing.Size(152, 32);
            this.NoOrder_Label.TabIndex = 4;
            this.NoOrder_Label.Text = "Orden #99";
            // 
            // Invoice_Button
            // 
            this.Invoice_Button.Animated = true;
            this.Invoice_Button.CheckedState.Parent = this.Invoice_Button;
            this.Invoice_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Invoice_Button.CustomImages.Parent = this.Invoice_Button;
            this.Invoice_Button.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Invoice_Button.ForeColor = System.Drawing.Color.White;
            this.Invoice_Button.HoverState.Parent = this.Invoice_Button;
            this.Invoice_Button.Location = new System.Drawing.Point(203, 281);
            this.Invoice_Button.Name = "Invoice_Button";
            this.Invoice_Button.ShadowDecoration.Parent = this.Invoice_Button;
            this.Invoice_Button.Size = new System.Drawing.Size(514, 67);
            this.Invoice_Button.TabIndex = 6;
            this.Invoice_Button.Text = "Finalizar pedido";
            this.Invoice_Button.Click += new System.EventHandler(this.Invoice_Button_Click);
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.BackgroundPanel;
            // 
            // FormElipse
            // 
            this.FormElipse.TargetControl = this;
            // 
            // OrderViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 353);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderViewForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrderViewForm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private Guna.UI2.WinForms.Guna2DataGridView DGV;
        private System.Windows.Forms.Label ClientName_Label;
        private System.Windows.Forms.Label NoOrder_Label;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceTotal;
        private Guna.UI2.WinForms.Guna2Button Invoice_Button;
        private Guna.UI2.WinForms.Guna2Button Cancel_Button;
    }
}