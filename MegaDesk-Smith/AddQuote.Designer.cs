namespace MegaDesk_Smith
{
    partial class AddQuote
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
            this.button1 = new System.Windows.Forms.Button();
            this.custName = new System.Windows.Forms.TextBox();
            this.create_quote = new System.Windows.Forms.Button();
            this.materialSelect = new System.Windows.Forms.ComboBox();
            this.rushSelect = new System.Windows.Forms.ComboBox();
            this.deskQuoteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deskQuoteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.widthSelect = new System.Windows.Forms.NumericUpDown();
            this.heightSelect = new System.Windows.Forms.NumericUpDown();
            this.drawersSelect = new System.Windows.Forms.NumericUpDown();
            this.nameLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.rushLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.heightLabel = new System.Windows.Forms.Label();
            this.drawersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // custName
            // 
            this.custName.Location = new System.Drawing.Point(160, 58);
            this.custName.Name = "custName";
            this.custName.Size = new System.Drawing.Size(208, 20);
            this.custName.TabIndex = 1;
            // 
            // create_quote
            // 
            this.create_quote.Location = new System.Drawing.Point(268, 415);
            this.create_quote.Name = "create_quote";
            this.create_quote.Size = new System.Drawing.Size(100, 23);
            this.create_quote.TabIndex = 2;
            this.create_quote.Text = "Create Quote";
            this.create_quote.UseVisualStyleBackColor = true;
            this.create_quote.Click += new System.EventHandler(this.create_quote_Click);
            // 
            // materialSelect
            // 
            this.materialSelect.FormattingEnabled = true;
            this.materialSelect.Location = new System.Drawing.Point(160, 85);
            this.materialSelect.Name = "materialSelect";
            this.materialSelect.Size = new System.Drawing.Size(208, 21);
            this.materialSelect.TabIndex = 3;
            // 
            // rushSelect
            // 
            this.rushSelect.FormattingEnabled = true;
            this.rushSelect.Location = new System.Drawing.Point(160, 113);
            this.rushSelect.Name = "rushSelect";
            this.rushSelect.Size = new System.Drawing.Size(208, 21);
            this.rushSelect.TabIndex = 4;
            // 
            // deskQuoteBindingSource
            // 
            this.deskQuoteBindingSource.DataSource = typeof(MegaDesk_Smith.DeskQuote);
            // 
            // deskQuoteBindingSource1
            // 
            this.deskQuoteBindingSource1.DataSource = typeof(MegaDesk_Smith.DeskQuote);
            // 
            // widthSelect
            // 
            this.widthSelect.Location = new System.Drawing.Point(160, 140);
            this.widthSelect.Name = "widthSelect";
            this.widthSelect.Size = new System.Drawing.Size(208, 20);
            this.widthSelect.TabIndex = 5;
            // 
            // heightSelect
            // 
            this.heightSelect.Location = new System.Drawing.Point(160, 166);
            this.heightSelect.Name = "heightSelect";
            this.heightSelect.Size = new System.Drawing.Size(208, 20);
            this.heightSelect.TabIndex = 6;
            // 
            // drawersSelect
            // 
            this.drawersSelect.Location = new System.Drawing.Point(160, 192);
            this.drawersSelect.Name = "drawersSelect";
            this.drawersSelect.Size = new System.Drawing.Size(208, 20);
            this.drawersSelect.TabIndex = 7;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(55, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 13);
            this.nameLabel.TabIndex = 8;
            this.nameLabel.Text = "Customer Name";
            this.nameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(55, 93);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(44, 13);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material";
            // 
            // rushLabel
            // 
            this.rushLabel.AutoSize = true;
            this.rushLabel.Location = new System.Drawing.Point(55, 121);
            this.rushLabel.Name = "rushLabel";
            this.rushLabel.Size = new System.Drawing.Size(32, 13);
            this.rushLabel.TabIndex = 10;
            this.rushLabel.Text = "Rush";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(55, 147);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(35, 13);
            this.widthLabel.TabIndex = 11;
            this.widthLabel.Text = "Width";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(55, 173);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(38, 13);
            this.heightLabel.TabIndex = 12;
            this.heightLabel.Text = "Height";
            // 
            // drawersLabel
            // 
            this.drawersLabel.AutoSize = true;
            this.drawersLabel.Location = new System.Drawing.Point(55, 199);
            this.drawersLabel.Name = "drawersLabel";
            this.drawersLabel.Size = new System.Drawing.Size(46, 13);
            this.drawersLabel.TabIndex = 13;
            this.drawersLabel.Text = "Drawers";
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.drawersLabel);
            this.Controls.Add(this.heightLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.rushLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.drawersSelect);
            this.Controls.Add(this.heightSelect);
            this.Controls.Add(this.widthSelect);
            this.Controls.Add(this.rushSelect);
            this.Controls.Add(this.materialSelect);
            this.Controls.Add(this.create_quote);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.button1);
            this.Name = "AddQuote";
            this.Text = "New Quote";
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deskQuoteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawersSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox custName;
        private System.Windows.Forms.Button create_quote;
        private System.Windows.Forms.ComboBox materialSelect;
        private System.Windows.Forms.ComboBox rushSelect;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource;
        private System.Windows.Forms.BindingSource deskQuoteBindingSource1;
        private System.Windows.Forms.NumericUpDown widthSelect;
        private System.Windows.Forms.NumericUpDown heightSelect;
        private System.Windows.Forms.NumericUpDown drawersSelect;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label rushLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label drawersLabel;
    }
}