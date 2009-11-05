﻿namespace Sample
{
	partial class OrderMaint2
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
			System.Windows.Forms.Label cardHolderLabel;
			System.Windows.Forms.Label cardTypeLabel;
			System.Windows.Forms.Label creditCardLabel;
			System.Windows.Forms.Label expDateLabel;
			System.Windows.Forms.Label orderIDLabel;
			System.Windows.Forms.Label orderNumberLabel;
			System.Windows.Forms.Label userNameLabel;
			System.Windows.Forms.Label textLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMaint2));
			this.cardHolderTextBox = new System.Windows.Forms.TextBox();
			this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cardTypeTextBox = new System.Windows.Forms.TextBox();
			this.creditCardTextBox = new System.Windows.Forms.TextBox();
			this.expDateTextBox = new System.Windows.Forms.TextBox();
			this.orderIDLabel1 = new System.Windows.Forms.Label();
			this.orderNumberTextBox = new System.Windows.Forms.TextBox();
			this.userNameTextBox = new System.Windows.Forms.TextBox();
			this.textTextBox = new System.Windows.Forms.TextBox();
			this.orderDetailListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.orderDetailListDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolSave = new System.Windows.Forms.ToolStripButton();
			this.toolSaveNew = new System.Windows.Forms.ToolStripButton();
			this.toolSaveClose = new System.Windows.Forms.ToolStripButton();
			this.toolCancel = new System.Windows.Forms.ToolStripButton();
			this.toolClose = new System.Windows.Forms.ToolStripButton();
			cardHolderLabel = new System.Windows.Forms.Label();
			cardTypeLabel = new System.Windows.Forms.Label();
			creditCardLabel = new System.Windows.Forms.Label();
			expDateLabel = new System.Windows.Forms.Label();
			orderIDLabel = new System.Windows.Forms.Label();
			orderNumberLabel = new System.Windows.Forms.Label();
			userNameLabel = new System.Windows.Forms.Label();
			textLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailListDataGridView)).BeginInit();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// cardHolderLabel
			// 
			cardHolderLabel.AutoSize = true;
			cardHolderLabel.Location = new System.Drawing.Point(36, 59);
			cardHolderLabel.Name = "cardHolderLabel";
			cardHolderLabel.Size = new System.Drawing.Size(66, 13);
			cardHolderLabel.TabIndex = 1;
			cardHolderLabel.Text = "Card Holder:";
			// 
			// cardTypeLabel
			// 
			cardTypeLabel.AutoSize = true;
			cardTypeLabel.Location = new System.Drawing.Point(36, 85);
			cardTypeLabel.Name = "cardTypeLabel";
			cardTypeLabel.Size = new System.Drawing.Size(59, 13);
			cardTypeLabel.TabIndex = 3;
			cardTypeLabel.Text = "Card Type:";
			// 
			// creditCardLabel
			// 
			creditCardLabel.AutoSize = true;
			creditCardLabel.Location = new System.Drawing.Point(36, 111);
			creditCardLabel.Name = "creditCardLabel";
			creditCardLabel.Size = new System.Drawing.Size(62, 13);
			creditCardLabel.TabIndex = 5;
			creditCardLabel.Text = "Credit Card:";
			// 
			// expDateLabel
			// 
			expDateLabel.AutoSize = true;
			expDateLabel.Location = new System.Drawing.Point(36, 137);
			expDateLabel.Name = "expDateLabel";
			expDateLabel.Size = new System.Drawing.Size(54, 13);
			expDateLabel.TabIndex = 7;
			expDateLabel.Text = "Exp Date:";
			// 
			// orderIDLabel
			// 
			orderIDLabel.AutoSize = true;
			orderIDLabel.Location = new System.Drawing.Point(36, 157);
			orderIDLabel.Name = "orderIDLabel";
			orderIDLabel.Size = new System.Drawing.Size(50, 13);
			orderIDLabel.TabIndex = 9;
			orderIDLabel.Text = "Order ID:";
			// 
			// orderNumberLabel
			// 
			orderNumberLabel.AutoSize = true;
			orderNumberLabel.Location = new System.Drawing.Point(36, 186);
			orderNumberLabel.Name = "orderNumberLabel";
			orderNumberLabel.Size = new System.Drawing.Size(76, 13);
			orderNumberLabel.TabIndex = 11;
			orderNumberLabel.Text = "Order Number:";
			// 
			// userNameLabel
			// 
			userNameLabel.AutoSize = true;
			userNameLabel.Location = new System.Drawing.Point(36, 212);
			userNameLabel.Name = "userNameLabel";
			userNameLabel.Size = new System.Drawing.Size(63, 13);
			userNameLabel.TabIndex = 13;
			userNameLabel.Text = "User Name:";
			// 
			// textLabel
			// 
			textLabel.AutoSize = true;
			textLabel.Location = new System.Drawing.Point(37, 238);
			textLabel.Name = "textLabel";
			textLabel.Size = new System.Drawing.Size(62, 13);
			textLabel.TabIndex = 15;
			textLabel.Text = "Order Date:";
			// 
			// cardHolderTextBox
			// 
			this.cardHolderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CardHolder", true));
			this.cardHolderTextBox.Location = new System.Drawing.Point(118, 56);
			this.cardHolderTextBox.Name = "cardHolderTextBox";
			this.cardHolderTextBox.Size = new System.Drawing.Size(292, 20);
			this.cardHolderTextBox.TabIndex = 2;
			// 
			// orderBindingSource
			// 
			this.orderBindingSource.DataSource = typeof(CslaStore.Business.Order);
			// 
			// cardTypeTextBox
			// 
			this.cardTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CardType", true));
			this.cardTypeTextBox.Location = new System.Drawing.Point(118, 82);
			this.cardTypeTextBox.Name = "cardTypeTextBox";
			this.cardTypeTextBox.Size = new System.Drawing.Size(292, 20);
			this.cardTypeTextBox.TabIndex = 4;
			// 
			// creditCardTextBox
			// 
			this.creditCardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "CreditCard", true));
			this.creditCardTextBox.Location = new System.Drawing.Point(118, 108);
			this.creditCardTextBox.Name = "creditCardTextBox";
			this.creditCardTextBox.Size = new System.Drawing.Size(292, 20);
			this.creditCardTextBox.TabIndex = 6;
			// 
			// expDateTextBox
			// 
			this.expDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ExpDate", true));
			this.expDateTextBox.Location = new System.Drawing.Point(118, 134);
			this.expDateTextBox.Name = "expDateTextBox";
			this.expDateTextBox.Size = new System.Drawing.Size(178, 20);
			this.expDateTextBox.TabIndex = 8;
			// 
			// orderIDLabel1
			// 
			this.orderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderID", true));
			this.orderIDLabel1.Location = new System.Drawing.Point(118, 157);
			this.orderIDLabel1.Name = "orderIDLabel1";
			this.orderIDLabel1.Size = new System.Drawing.Size(100, 23);
			this.orderIDLabel1.TabIndex = 10;
			this.orderIDLabel1.Text = "label1";
			// 
			// orderNumberTextBox
			// 
			this.orderNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderNumber", true));
			this.orderNumberTextBox.Location = new System.Drawing.Point(118, 183);
			this.orderNumberTextBox.Name = "orderNumberTextBox";
			this.orderNumberTextBox.Size = new System.Drawing.Size(178, 20);
			this.orderNumberTextBox.TabIndex = 12;
			// 
			// userNameTextBox
			// 
			this.userNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "UserName", true));
			this.userNameTextBox.Location = new System.Drawing.Point(118, 209);
			this.userNameTextBox.Name = "userNameTextBox";
			this.userNameTextBox.Size = new System.Drawing.Size(292, 20);
			this.userNameTextBox.TabIndex = 14;
			// 
			// textTextBox
			// 
			this.textTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "OrderDate.Text", true));
			this.textTextBox.Location = new System.Drawing.Point(118, 235);
			this.textTextBox.Name = "textTextBox";
			this.textTextBox.Size = new System.Drawing.Size(178, 20);
			this.textTextBox.TabIndex = 16;
			// 
			// orderDetailListBindingSource
			// 
			this.orderDetailListBindingSource.DataMember = "OrderDetailList";
			this.orderDetailListBindingSource.DataSource = this.orderBindingSource;
			// 
			// orderDetailListDataGridView
			// 
			this.orderDetailListDataGridView.AutoGenerateColumns = false;
			this.orderDetailListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.orderDetailListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.orderDetailListDataGridView.DataSource = this.orderDetailListBindingSource;
			this.orderDetailListDataGridView.Location = new System.Drawing.Point(76, 284);
			this.orderDetailListDataGridView.Name = "orderDetailListDataGridView";
			this.orderDetailListDataGridView.Size = new System.Drawing.Size(589, 220);
			this.orderDetailListDataGridView.TabIndex = 16;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderDetailID";
			this.dataGridViewTextBoxColumn1.HeaderText = "OrderDetailID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "OrderID";
			this.dataGridViewTextBoxColumn2.HeaderText = "OrderID";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
			this.dataGridViewTextBoxColumn3.HeaderText = "ProductID";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "PurchaseUnitPrice";
			this.dataGridViewTextBoxColumn4.HeaderText = "PurchaseUnitPrice";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Quantity";
			this.dataGridViewTextBoxColumn5.HeaderText = "Quantity";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSave,
            this.toolSaveNew,
            this.toolSaveClose,
            this.toolCancel,
            this.toolClose});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(791, 25);
			this.toolStrip1.TabIndex = 22;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolSave
			// 
			this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
			this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSave.Name = "toolSave";
			this.toolSave.Size = new System.Drawing.Size(23, 22);
			this.toolSave.Text = "Save";
			this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
			// 
			// toolSaveNew
			// 
			this.toolSaveNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolSaveNew.Image = ((System.Drawing.Image)(resources.GetObject("toolSaveNew.Image")));
			this.toolSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSaveNew.Name = "toolSaveNew";
			this.toolSaveNew.Size = new System.Drawing.Size(23, 22);
			this.toolSaveNew.Text = "Save/New";
			this.toolSaveNew.Click += new System.EventHandler(this.toolSaveNew_Click);
			// 
			// toolSaveClose
			// 
			this.toolSaveClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolSaveClose.Image = ((System.Drawing.Image)(resources.GetObject("toolSaveClose.Image")));
			this.toolSaveClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSaveClose.Name = "toolSaveClose";
			this.toolSaveClose.Size = new System.Drawing.Size(23, 22);
			this.toolSaveClose.Text = "Save/Close";
			this.toolSaveClose.Click += new System.EventHandler(this.toolSaveClose_Click);
			// 
			// toolCancel
			// 
			this.toolCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolCancel.Image")));
			this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolCancel.Name = "toolCancel";
			this.toolCancel.Size = new System.Drawing.Size(23, 22);
			this.toolCancel.Text = "Cancel";
			this.toolCancel.Click += new System.EventHandler(this.toolCancel_Click);
			// 
			// toolClose
			// 
			this.toolClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolClose.Image = ((System.Drawing.Image)(resources.GetObject("toolClose.Image")));
			this.toolClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolClose.Name = "toolClose";
			this.toolClose.Size = new System.Drawing.Size(23, 22);
			this.toolClose.Text = "Close";
			this.toolClose.Click += new System.EventHandler(this.toolClose_Click);
			// 
			// OrderMaint2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(791, 571);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.orderDetailListDataGridView);
			this.Controls.Add(textLabel);
			this.Controls.Add(this.textTextBox);
			this.Controls.Add(cardHolderLabel);
			this.Controls.Add(this.cardHolderTextBox);
			this.Controls.Add(cardTypeLabel);
			this.Controls.Add(this.cardTypeTextBox);
			this.Controls.Add(creditCardLabel);
			this.Controls.Add(this.creditCardTextBox);
			this.Controls.Add(expDateLabel);
			this.Controls.Add(this.expDateTextBox);
			this.Controls.Add(orderIDLabel);
			this.Controls.Add(this.orderIDLabel1);
			this.Controls.Add(orderNumberLabel);
			this.Controls.Add(this.orderNumberTextBox);
			this.Controls.Add(userNameLabel);
			this.Controls.Add(this.userNameTextBox);
			this.Name = "OrderMaint2";
			this.Text = "OrderMaint";
			((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.orderDetailListDataGridView)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource orderBindingSource;
		private System.Windows.Forms.TextBox cardHolderTextBox;
		private System.Windows.Forms.TextBox cardTypeTextBox;
		private System.Windows.Forms.TextBox creditCardTextBox;
		private System.Windows.Forms.TextBox expDateTextBox;
		private System.Windows.Forms.Label orderIDLabel1;
		private System.Windows.Forms.TextBox orderNumberTextBox;
		private System.Windows.Forms.TextBox userNameTextBox;
		private System.Windows.Forms.TextBox textTextBox;
		private System.Windows.Forms.BindingSource orderDetailListBindingSource;
		private System.Windows.Forms.DataGridView orderDetailListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolSave;
		private System.Windows.Forms.ToolStripButton toolSaveNew;
		private System.Windows.Forms.ToolStripButton toolSaveClose;
		private System.Windows.Forms.ToolStripButton toolCancel;
		private System.Windows.Forms.ToolStripButton toolClose;
	}
}