namespace DataBinding101
{
    partial class Form1
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label strengthLabel;
            System.Windows.Forms.Label intelligenceLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.characterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.characterBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.strengthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.intelligenceTextBox = new System.Windows.Forms.TextBox();
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.characterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            strengthLabel = new System.Windows.Forms.Label();
            intelligenceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingNavigator)).BeginInit();
            this.characterBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(32, 57);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize = true;
            strengthLabel.Location = new System.Drawing.Point(20, 93);
            strengthLabel.Name = "strengthLabel";
            strengthLabel.Size = new System.Drawing.Size(50, 13);
            strengthLabel.TabIndex = 3;
            strengthLabel.Text = "Strength:";
            // 
            // intelligenceLabel
            // 
            intelligenceLabel.AutoSize = true;
            intelligenceLabel.Location = new System.Drawing.Point(6, 122);
            intelligenceLabel.Name = "intelligenceLabel";
            intelligenceLabel.Size = new System.Drawing.Size(64, 13);
            intelligenceLabel.TabIndex = 5;
            intelligenceLabel.Text = "Intelligence:";
            // 
            // characterBindingNavigator
            // 
            this.characterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.characterBindingNavigator.BindingSource = this.characterBindingSource;
            this.characterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.characterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.characterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.characterBindingNavigatorSaveItem});
            this.characterBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.characterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.characterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.characterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.characterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.characterBindingNavigator.Name = "characterBindingNavigator";
            this.characterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.characterBindingNavigator.Size = new System.Drawing.Size(627, 25);
            this.characterBindingNavigator.TabIndex = 0;
            this.characterBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // characterBindingNavigatorSaveItem
            // 
            this.characterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.characterBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("characterBindingNavigatorSaveItem.Image")));
            this.characterBindingNavigatorSaveItem.Name = "characterBindingNavigatorSaveItem";
            this.characterBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.characterBindingNavigatorSaveItem.Text = "Save Data";
            this.characterBindingNavigatorSaveItem.Click += new System.EventHandler(this.characterBindingNavigatorSaveItem_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(76, 54);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(242, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // strengthNumericUpDown
            // 
            this.strengthNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.characterBindingSource, "Strength", true));
            this.strengthNumericUpDown.Location = new System.Drawing.Point(76, 93);
            this.strengthNumericUpDown.Name = "strengthNumericUpDown";
            this.strengthNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.strengthNumericUpDown.TabIndex = 4;
            // 
            // intelligenceTextBox
            // 
            this.intelligenceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.characterBindingSource, "Intelligence", true));
            this.intelligenceTextBox.Location = new System.Drawing.Point(76, 119);
            this.intelligenceTextBox.Name = "intelligenceTextBox";
            this.intelligenceTextBox.Size = new System.Drawing.Size(126, 20);
            this.intelligenceTextBox.TabIndex = 6;
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataMember = "Equipment";
            this.equipmentBindingSource.DataSource = this.characterBindingSource;
            // 
            // equipmentDataGridView
            // 
            this.equipmentDataGridView.AutoGenerateColumns = false;
            this.equipmentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.equipmentDataGridView.DataSource = this.equipmentBindingSource;
            this.equipmentDataGridView.Location = new System.Drawing.Point(52, 178);
            this.equipmentDataGridView.Name = "equipmentDataGridView";
            this.equipmentDataGridView.Size = new System.Drawing.Size(374, 249);
            this.equipmentDataGridView.TabIndex = 7;
            this.equipmentDataGridView.Enter += new System.EventHandler(this.CheckForCharacterId);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "EquipmentId";
            this.dataGridViewTextBoxColumn1.HeaderText = "EquipmentId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Owner";
            this.dataGridViewTextBoxColumn3.HeaderText = "Owner";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // characterBindingSource
            // 
            this.characterBindingSource.DataSource = typeof(DataBinding101.Models.Character);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 480);
            this.Controls.Add(this.equipmentDataGridView);
            this.Controls.Add(intelligenceLabel);
            this.Controls.Add(this.intelligenceTextBox);
            this.Controls.Add(strengthLabel);
            this.Controls.Add(this.strengthNumericUpDown);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.characterBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingNavigator)).EndInit();
            this.characterBindingNavigator.ResumeLayout(false);
            this.characterBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strengthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource characterBindingSource;
        private System.Windows.Forms.BindingNavigator characterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton characterBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.NumericUpDown strengthNumericUpDown;
        private System.Windows.Forms.TextBox intelligenceTextBox;
        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.DataGridView equipmentDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

