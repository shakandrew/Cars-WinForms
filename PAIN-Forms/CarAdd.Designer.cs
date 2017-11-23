namespace PAIN_Forms
{
    partial class CarAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarAdd));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.typeTextBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrandTextBox = new System.Windows.Forms.TextBox();
            this.ProdYearTextBox = new System.Windows.Forms.TextBox();
            this.MaxVelocityTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chooser = new PAIN_Forms.CarTypeChooser();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.typeTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BrandTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ProdYearTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaxVelocityTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooser, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.91065F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.25688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.96649F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(358, 324);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // typeTextBox
            // 
            this.typeTextBox.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.typeTextBox, 2);
            this.typeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typeTextBox.Location = new System.Drawing.Point(91, 255);
            this.typeTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeTextBox.Name = "typeTextBox";
            this.typeTextBox.Size = new System.Drawing.Size(174, 26);
            this.typeTextBox.TabIndex = 12;
            this.typeTextBox.Text = "Personal";
            this.typeTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(2, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Production year";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(2, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Maximal velocity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // BrandTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BrandTextBox, 2);
            this.BrandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandTextBox.Location = new System.Drawing.Point(91, 40);
            this.BrandTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.BrandTextBox.Name = "BrandTextBox";
            this.BrandTextBox.Size = new System.Drawing.Size(174, 20);
            this.BrandTextBox.TabIndex = 4;
            this.BrandTextBox.Validated += new System.EventHandler(this.BrandTextBox_Validated);
            // 
            // ProdYearTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ProdYearTextBox, 2);
            this.ProdYearTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProdYearTextBox.Location = new System.Drawing.Point(91, 78);
            this.ProdYearTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ProdYearTextBox.Name = "ProdYearTextBox";
            this.ProdYearTextBox.Size = new System.Drawing.Size(174, 20);
            this.ProdYearTextBox.TabIndex = 5;
            this.ProdYearTextBox.Validated += new System.EventHandler(this.ProdYearTextBox_Validated);
            // 
            // MaxVelocityTextBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.MaxVelocityTextBox, 2);
            this.MaxVelocityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaxVelocityTextBox.Location = new System.Drawing.Point(91, 116);
            this.MaxVelocityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.MaxVelocityTextBox.Name = "MaxVelocityTextBox";
            this.MaxVelocityTextBox.Size = new System.Drawing.Size(174, 20);
            this.MaxVelocityTextBox.TabIndex = 6;
            this.MaxVelocityTextBox.Validated += new System.EventHandler(this.MaxVelocityTextBox_Validated);
            // 
            // button1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(104, 289);
            this.button1.Margin = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 2);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(91, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Visible = false;
            // 
            // chooser
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.chooser, 2);
            this.chooser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chooser.imageIndex = 0;
            this.chooser.Location = new System.Drawing.Point(91, 154);
            this.chooser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooser.Name = "chooser";
            this.chooser.Size = new System.Drawing.Size(174, 99);
            this.chooser.TabIndex = 13;
            this.chooser.typeChanged += new PAIN_Forms.CarTypeChangedHandler(this.choosed_typeChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // CarAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 324);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CarAdd";
            this.Text = "New";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BrandTextBox;
        private System.Windows.Forms.TextBox ProdYearTextBox;
        private System.Windows.Forms.TextBox MaxVelocityTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label typeTextBox;
        private CarTypeChooser chooser;
    }
}