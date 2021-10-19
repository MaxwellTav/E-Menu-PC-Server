
namespace E_Menu_PC_Server.Forms
{
    partial class NewOrder
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
            this.Form_Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Form_Drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.Background_Panel = new Guna.UI2.WinForms.Guna2Panel();
            this.MoneySign_Label = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PriceUnity_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cuantity_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ItenName_Combo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemCuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceUnity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPriceTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EliminarProduto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AddItem_Button = new Guna.UI2.WinForms.Guna2Button();
            this.MakeOrder_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.ClientName_Textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NoOrder_Label = new System.Windows.Forms.Label();
            this.Background_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Elipse
            // 
            this.Form_Elipse.TargetControl = this;
            // 
            // Form_Drag
            // 
            this.Form_Drag.TargetControl = this.Background_Panel;
            // 
            // Background_Panel
            // 
            this.Background_Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Background_Panel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Background_Panel.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.Background_Panel.BorderThickness = 3;
            this.Background_Panel.Controls.Add(this.MoneySign_Label);
            this.Background_Panel.Controls.Add(this.label3);
            this.Background_Panel.Controls.Add(this.PriceUnity_Textbox);
            this.Background_Panel.Controls.Add(this.label2);
            this.Background_Panel.Controls.Add(this.Cuantity_Textbox);
            this.Background_Panel.Controls.Add(this.ItenName_Combo);
            this.Background_Panel.Controls.Add(this.label1);
            this.Background_Panel.Controls.Add(this.DGV);
            this.Background_Panel.Controls.Add(this.AddItem_Button);
            this.Background_Panel.Controls.Add(this.MakeOrder_Button);
            this.Background_Panel.Controls.Add(this.Exit_Button);
            this.Background_Panel.Controls.Add(this.Separator1);
            this.Background_Panel.Controls.Add(this.ClientName_Textbox);
            this.Background_Panel.Controls.Add(this.NoOrder_Label);
            this.Background_Panel.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.Background_Panel.Location = new System.Drawing.Point(2, 1);
            this.Background_Panel.Name = "Background_Panel";
            this.Background_Panel.ShadowDecoration.Parent = this.Background_Panel;
            this.Background_Panel.Size = new System.Drawing.Size(713, 525);
            this.Background_Panel.TabIndex = 0;
            // 
            // MoneySign_Label
            // 
            this.MoneySign_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MoneySign_Label.Enabled = false;
            this.MoneySign_Label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoneySign_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MoneySign_Label.Location = new System.Drawing.Point(400, 122);
            this.MoneySign_Label.Name = "MoneySign_Label";
            this.MoneySign_Label.Size = new System.Drawing.Size(11, 19);
            this.MoneySign_Label.TabIndex = 16;
            this.MoneySign_Label.Text = "$";
            this.MoneySign_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(398, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Precio (U)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceUnity_Textbox
            // 
            this.PriceUnity_Textbox.Animated = true;
            this.PriceUnity_Textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceUnity_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceUnity_Textbox.DefaultText = "100";
            this.PriceUnity_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceUnity_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceUnity_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceUnity_Textbox.DisabledState.Parent = this.PriceUnity_Textbox;
            this.PriceUnity_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceUnity_Textbox.Enabled = false;
            this.PriceUnity_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.PriceUnity_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceUnity_Textbox.FocusedState.Parent = this.PriceUnity_Textbox;
            this.PriceUnity_Textbox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceUnity_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PriceUnity_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceUnity_Textbox.HoverState.Parent = this.PriceUnity_Textbox;
            this.PriceUnity_Textbox.Location = new System.Drawing.Point(401, 116);
            this.PriceUnity_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceUnity_Textbox.Name = "PriceUnity_Textbox";
            this.PriceUnity_Textbox.PasswordChar = '\0';
            this.PriceUnity_Textbox.PlaceholderText = "Precio unidad";
            this.PriceUnity_Textbox.SelectedText = "";
            this.PriceUnity_Textbox.SelectionStart = 3;
            this.PriceUnity_Textbox.ShadowDecoration.Parent = this.PriceUnity_Textbox;
            this.PriceUnity_Textbox.Size = new System.Drawing.Size(86, 34);
            this.PriceUnity_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PriceUnity_Textbox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(306, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cuantity_Textbox
            // 
            this.Cuantity_Textbox.Animated = true;
            this.Cuantity_Textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cuantity_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Cuantity_Textbox.DefaultText = "1";
            this.Cuantity_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Cuantity_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Cuantity_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cuantity_Textbox.DisabledState.Parent = this.Cuantity_Textbox;
            this.Cuantity_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Cuantity_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.Cuantity_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cuantity_Textbox.FocusedState.Parent = this.Cuantity_Textbox;
            this.Cuantity_Textbox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cuantity_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cuantity_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Cuantity_Textbox.HoverState.Parent = this.Cuantity_Textbox;
            this.Cuantity_Textbox.Location = new System.Drawing.Point(309, 116);
            this.Cuantity_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cuantity_Textbox.Name = "Cuantity_Textbox";
            this.Cuantity_Textbox.PasswordChar = '\0';
            this.Cuantity_Textbox.PlaceholderText = "Cantidad";
            this.Cuantity_Textbox.SelectedText = "";
            this.Cuantity_Textbox.SelectionStart = 1;
            this.Cuantity_Textbox.ShadowDecoration.Parent = this.Cuantity_Textbox;
            this.Cuantity_Textbox.Size = new System.Drawing.Size(86, 34);
            this.Cuantity_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Cuantity_Textbox.TabIndex = 10;
            // 
            // ItenName_Combo
            // 
            this.ItenName_Combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItenName_Combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItenName_Combo.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItenName_Combo.FormattingEnabled = true;
            this.ItenName_Combo.Location = new System.Drawing.Point(10, 116);
            this.ItenName_Combo.Name = "ItenName_Combo";
            this.ItenName_Combo.Size = new System.Drawing.Size(292, 34);
            this.ItenName_Combo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(10, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del artículo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ItemPriceTotal,
            this.EliminarProduto});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGV.EnableHeadersVisualStyles = false;
            this.DGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.DGV.Location = new System.Drawing.Point(3, 156);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidth = 40;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.Size = new System.Drawing.Size(707, 312);
            this.DGV.TabIndex = 11;
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
            this.DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellContentClick);
            this.DGV.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.EventoAnadido);
            this.DGV.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.EventoEliminar);
            // 
            // ItemID
            // 
            this.ItemID.FillWeight = 29.00668F;
            this.ItemID.HeaderText = "ID";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.FillWeight = 139.1334F;
            this.ItemName.HeaderText = "Artículo";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemCuantity
            // 
            this.ItemCuantity.FillWeight = 91.37053F;
            this.ItemCuantity.HeaderText = "Cantidad";
            this.ItemCuantity.Name = "ItemCuantity";
            this.ItemCuantity.ReadOnly = true;
            // 
            // ItemPriceUnity
            // 
            this.ItemPriceUnity.FillWeight = 150.1342F;
            this.ItemPriceUnity.HeaderText = "Precio (U)";
            this.ItemPriceUnity.Name = "ItemPriceUnity";
            this.ItemPriceUnity.ReadOnly = true;
            // 
            // ItemPriceTotal
            // 
            this.ItemPriceTotal.FillWeight = 101.4698F;
            this.ItemPriceTotal.HeaderText = "Precio (T)";
            this.ItemPriceTotal.Name = "ItemPriceTotal";
            this.ItemPriceTotal.ReadOnly = true;
            // 
            // EliminarProduto
            // 
            this.EliminarProduto.FillWeight = 88.88521F;
            this.EliminarProduto.HeaderText = "Eliminar";
            this.EliminarProduto.Name = "EliminarProduto";
            this.EliminarProduto.ReadOnly = true;
            this.EliminarProduto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.EliminarProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddItem_Button.Animated = true;
            this.AddItem_Button.AutoRoundedCorners = true;
            this.AddItem_Button.BorderRadius = 24;
            this.AddItem_Button.CheckedState.Parent = this.AddItem_Button;
            this.AddItem_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddItem_Button.CustomImages.Parent = this.AddItem_Button;
            this.AddItem_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.AddItem_Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_Button.ForeColor = System.Drawing.Color.White;
            this.AddItem_Button.HoverState.Parent = this.AddItem_Button;
            this.AddItem_Button.Image = global::E_Menu_PC_Server.Properties.Resources.NewOrder;
            this.AddItem_Button.Location = new System.Drawing.Point(494, 100);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.ShadowDecoration.Parent = this.AddItem_Button;
            this.AddItem_Button.Size = new System.Drawing.Size(211, 50);
            this.AddItem_Button.TabIndex = 8;
            this.AddItem_Button.Text = "Agregar artículo";
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // MakeOrder_Button
            // 
            this.MakeOrder_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.MakeOrder_Button.Animated = true;
            this.MakeOrder_Button.AutoRoundedCorners = true;
            this.MakeOrder_Button.BorderRadius = 20;
            this.MakeOrder_Button.CheckedState.Parent = this.MakeOrder_Button;
            this.MakeOrder_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MakeOrder_Button.CustomImages.Parent = this.MakeOrder_Button;
            this.MakeOrder_Button.Enabled = false;
            this.MakeOrder_Button.FillColor = System.Drawing.Color.ForestGreen;
            this.MakeOrder_Button.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeOrder_Button.ForeColor = System.Drawing.Color.White;
            this.MakeOrder_Button.HoverState.Parent = this.MakeOrder_Button;
            this.MakeOrder_Button.Image = global::E_Menu_PC_Server.Properties.Resources.NewOrder;
            this.MakeOrder_Button.Location = new System.Drawing.Point(7, 474);
            this.MakeOrder_Button.Name = "MakeOrder_Button";
            this.MakeOrder_Button.ShadowDecoration.Parent = this.MakeOrder_Button;
            this.MakeOrder_Button.Size = new System.Drawing.Size(700, 42);
            this.MakeOrder_Button.TabIndex = 8;
            this.MakeOrder_Button.Text = "Crear esta orden";
            this.MakeOrder_Button.Click += new System.EventHandler(this.MakeOrder_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Button.Animated = true;
            this.Exit_Button.AutoRoundedCorners = true;
            this.Exit_Button.BorderRadius = 17;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Image = global::E_Menu_PC_Server.Properties.Resources.Exit;
            this.Exit_Button.Location = new System.Drawing.Point(610, 11);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(95, 36);
            this.Exit_Button.TabIndex = 1;
            this.Exit_Button.Text = "Cancelar";
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Separator1
            // 
            this.Separator1.Enabled = false;
            this.Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.Separator1.Location = new System.Drawing.Point(5, 90);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(600, 10);
            this.Separator1.TabIndex = 7;
            // 
            // ClientName_Textbox
            // 
            this.ClientName_Textbox.Animated = true;
            this.ClientName_Textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientName_Textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientName_Textbox.DefaultText = "";
            this.ClientName_Textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientName_Textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientName_Textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientName_Textbox.DisabledState.Parent = this.ClientName_Textbox;
            this.ClientName_Textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientName_Textbox.FillColor = System.Drawing.SystemColors.Control;
            this.ClientName_Textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientName_Textbox.FocusedState.Parent = this.ClientName_Textbox;
            this.ClientName_Textbox.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientName_Textbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientName_Textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientName_Textbox.HoverState.Parent = this.ClientName_Textbox;
            this.ClientName_Textbox.Location = new System.Drawing.Point(192, 55);
            this.ClientName_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClientName_Textbox.Name = "ClientName_Textbox";
            this.ClientName_Textbox.PasswordChar = '\0';
            this.ClientName_Textbox.PlaceholderText = "Nombre del cliente";
            this.ClientName_Textbox.SelectedText = "";
            this.ClientName_Textbox.ShadowDecoration.Parent = this.ClientName_Textbox;
            this.ClientName_Textbox.Size = new System.Drawing.Size(330, 31);
            this.ClientName_Textbox.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ClientName_Textbox.TabIndex = 6;
            // 
            // NoOrder_Label
            // 
            this.NoOrder_Label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NoOrder_Label.Enabled = false;
            this.NoOrder_Label.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoOrder_Label.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NoOrder_Label.Location = new System.Drawing.Point(170, 13);
            this.NoOrder_Label.Name = "NoOrder_Label";
            this.NoOrder_Label.Size = new System.Drawing.Size(374, 32);
            this.NoOrder_Label.TabIndex = 5;
            this.NoOrder_Label.Text = "Orden #99";
            this.NoOrder_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 529);
            this.Controls.Add(this.Background_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewOrder";
            this.Load += new System.EventHandler(this.NewOrder_Load);
            this.Background_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Form_Elipse;
        private Guna.UI2.WinForms.Guna2DragControl Form_Drag;
        private Guna.UI2.WinForms.Guna2Panel Background_Panel;
        private System.Windows.Forms.Label NoOrder_Label;
        private Guna.UI2.WinForms.Guna2TextBox ClientName_Textbox;
        private Guna.UI2.WinForms.Guna2Separator Separator1;
        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        private Guna.UI2.WinForms.Guna2Button MakeOrder_Button;
        private Guna.UI2.WinForms.Guna2TextBox Cuantity_Textbox;
        private System.Windows.Forms.ComboBox ItenName_Combo;
        private Guna.UI2.WinForms.Guna2DataGridView DGV;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button AddItem_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemCuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceUnity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPriceTotal;
        private System.Windows.Forms.DataGridViewButtonColumn EliminarProduto;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox PriceUnity_Textbox;
        private System.Windows.Forms.Label MoneySign_Label;
    }
}