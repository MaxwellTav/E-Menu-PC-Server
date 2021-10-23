
namespace E_Menu_PC_Server
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FormElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoToOrder = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Background_Panel = new System.Windows.Forms.Panel();
            this.NoOrder_Label = new System.Windows.Forms.Label();
            this.FormDrag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.VoidUpdate = new System.Windows.Forms.Timer(this.components);
            this.Waiting_Picture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.NewOrder_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Witing_Panel = new System.Windows.Forms.Panel();
            this.Waiting_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.Background_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Waiting_Picture)).BeginInit();
            this.Witing_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormElipse
            // 
            this.FormElipse.TargetControl = this;
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.DGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle28;
            this.DGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.BackgroundColor = System.Drawing.Color.White;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
            this.DGV.ColumnHeadersHeight = 50;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ClientName,
            this.GoToOrder});
            this.DGV.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle30;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.DGV.Location = new System.Drawing.Point(1, 60);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 40;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(799, 388);
            this.DGV.TabIndex = 0;
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
            this.DGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGV.ThemeStyle.HeaderStyle.Height = 50;
            this.DGV.ThemeStyle.ReadOnly = true;
            this.DGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGV.ThemeStyle.RowsStyle.Height = 22;
            this.DGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.DGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            this.DGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_RowsAdded);
            this.DGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DGV_RowsRemoved);
            // 
            // ItemID
            // 
            this.ItemID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemID.FillWeight = 500F;
            this.ItemID.HeaderText = "No. Orden";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ClientName
            // 
            this.ClientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClientName.FillWeight = 500F;
            this.ClientName.HeaderText = "Nombre del cliente";
            this.ClientName.Name = "ClientName";
            this.ClientName.ReadOnly = true;
            // 
            // GoToOrder
            // 
            this.GoToOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GoToOrder.FillWeight = 500F;
            this.GoToOrder.HeaderText = "Ver la orden";
            this.GoToOrder.Name = "GoToOrder";
            this.GoToOrder.ReadOnly = true;
            this.GoToOrder.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GoToOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Background_Panel
            // 
            this.Background_Panel.Controls.Add(this.NoOrder_Label);
            this.Background_Panel.Controls.Add(this.NewOrder_Button);
            this.Background_Panel.Controls.Add(this.Exit_Button);
            this.Background_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Background_Panel.Location = new System.Drawing.Point(0, 0);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.Size = new System.Drawing.Size(800, 61);
            this.Background_Panel.TabIndex = 1;
            // 
            // NoOrder_Label
            // 
            this.NoOrder_Label.AutoSize = true;
            this.NoOrder_Label.Enabled = false;
            this.NoOrder_Label.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.NoOrder_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.NoOrder_Label.Location = new System.Drawing.Point(12, 9);
            this.NoOrder_Label.Name = "NoOrder_Label";
            this.NoOrder_Label.Size = new System.Drawing.Size(169, 37);
            this.NoOrder_Label.TabIndex = 5;
            this.NoOrder_Label.Text = "En espera: 0";
            // 
            // FormDrag
            // 
            this.FormDrag.TargetControl = this.Background_Panel;
            // 
            // VoidUpdate
            // 
            this.VoidUpdate.Interval = 10000;
            // 
            // Waiting_Picture
            // 
            this.Waiting_Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Waiting_Picture.BackColor = System.Drawing.Color.White;
            this.Waiting_Picture.Image = global::E_Menu_PC_Server.Properties.Resources.WaitingGif1;
            this.Waiting_Picture.Location = new System.Drawing.Point(11, 7);
            this.Waiting_Picture.Name = "Waiting_Picture";
            this.Waiting_Picture.ShadowDecoration.Parent = this.Waiting_Picture;
            this.Waiting_Picture.Size = new System.Drawing.Size(319, 191);
            this.Waiting_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Waiting_Picture.TabIndex = 2;
            this.Waiting_Picture.TabStop = false;
            // 
            // NewOrder_Button
            // 
            this.NewOrder_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NewOrder_Button.Animated = true;
            this.NewOrder_Button.AutoRoundedCorners = true;
            this.NewOrder_Button.BorderRadius = 23;
            this.NewOrder_Button.CheckedState.Parent = this.NewOrder_Button;
            this.NewOrder_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewOrder_Button.CustomImages.Parent = this.NewOrder_Button;
            this.NewOrder_Button.FillColor = System.Drawing.Color.Gray;
            this.NewOrder_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewOrder_Button.ForeColor = System.Drawing.Color.White;
            this.NewOrder_Button.HoverState.Parent = this.NewOrder_Button;
            this.NewOrder_Button.Image = global::E_Menu_PC_Server.Properties.Resources.NewOrder;
            this.NewOrder_Button.Location = new System.Drawing.Point(588, 6);
            this.NewOrder_Button.Name = "NewOrder_Button";
            this.NewOrder_Button.ShadowDecoration.Parent = this.NewOrder_Button;
            this.NewOrder_Button.Size = new System.Drawing.Size(123, 48);
            this.NewOrder_Button.TabIndex = 0;
            this.NewOrder_Button.Text = "Nueva orden";
            this.NewOrder_Button.Click += new System.EventHandler(this.NewOrder_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exit_Button.Animated = true;
            this.Exit_Button.AutoRoundedCorners = true;
            this.Exit_Button.BorderRadius = 23;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Image = global::E_Menu_PC_Server.Properties.Resources.Exit;
            this.Exit_Button.Location = new System.Drawing.Point(714, 6);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(83, 48);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Text = "Salir";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Witing_Panel
            // 
            this.Witing_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Witing_Panel.BackColor = System.Drawing.Color.White;
            this.Witing_Panel.Controls.Add(this.Waiting_Label);
            this.Witing_Panel.Controls.Add(this.Waiting_Picture);
            this.Witing_Panel.Location = new System.Drawing.Point(218, 110);
            this.Witing_Panel.Name = "Witing_Panel";
            this.Witing_Panel.Size = new System.Drawing.Size(338, 232);
            this.Witing_Panel.TabIndex = 3;
            // 
            // Waiting_Label
            // 
            this.Waiting_Label.AutoSize = true;
            this.Waiting_Label.Enabled = false;
            this.Waiting_Label.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Waiting_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Waiting_Label.Location = new System.Drawing.Point(28, 195);
            this.Waiting_Label.Name = "Waiting_Label";
            this.Waiting_Label.Size = new System.Drawing.Size(282, 37);
            this.Waiting_Label.TabIndex = 6;
            this.Waiting_Label.Text = "Esperando ordenes...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Witing_Panel);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.Background_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Index";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.Background_Panel.ResumeLayout(false);
            this.Background_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Waiting_Picture)).EndInit();
            this.Witing_Panel.ResumeLayout(false);
            this.Witing_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse FormElipse;
        private Guna.UI2.WinForms.Guna2DataGridView DGV;
        private System.Windows.Forms.Panel Background_Panel;
        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        private Guna.UI2.WinForms.Guna2DragControl FormDrag;
        private System.Windows.Forms.Label NoOrder_Label;
        private Guna.UI2.WinForms.Guna2Button NewOrder_Button;
        private System.Windows.Forms.Timer VoidUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewButtonColumn GoToOrder;
        private Guna.UI2.WinForms.Guna2PictureBox Waiting_Picture;
        private System.Windows.Forms.Panel Witing_Panel;
        private System.Windows.Forms.Label Waiting_Label;
    }
}

