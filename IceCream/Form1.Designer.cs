namespace IceCream
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rdnSmall = new System.Windows.Forms.RadioButton();
            this.rdnMedium = new System.Windows.Forms.RadioButton();
            this.rdnBig = new System.Windows.Forms.RadioButton();
            this.btnGetOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdnChocolate = new System.Windows.Forms.RadioButton();
            this.rdnStrawberry = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkNuts = new System.Windows.Forms.CheckBox();
            this.chkRaisins = new System.Windows.Forms.CheckBox();
            this.chkChocolate = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdnSmall
            // 
            this.rdnSmall.AutoSize = true;
            this.rdnSmall.Location = new System.Drawing.Point(24, 59);
            this.rdnSmall.Name = "rdnSmall";
            this.rdnSmall.Size = new System.Drawing.Size(96, 29);
            this.rdnSmall.TabIndex = 0;
            this.rdnSmall.TabStop = true;
            this.rdnSmall.Text = "Small";
            this.rdnSmall.UseVisualStyleBackColor = true;
            // 
            // rdnMedium
            // 
            this.rdnMedium.AutoSize = true;
            this.rdnMedium.Location = new System.Drawing.Point(24, 134);
            this.rdnMedium.Name = "rdnMedium";
            this.rdnMedium.Size = new System.Drawing.Size(119, 29);
            this.rdnMedium.TabIndex = 1;
            this.rdnMedium.TabStop = true;
            this.rdnMedium.Text = "Medium";
            this.rdnMedium.UseVisualStyleBackColor = true;
            // 
            // rdnBig
            // 
            this.rdnBig.AutoSize = true;
            this.rdnBig.Location = new System.Drawing.Point(24, 213);
            this.rdnBig.Name = "rdnBig";
            this.rdnBig.Size = new System.Drawing.Size(74, 29);
            this.rdnBig.TabIndex = 2;
            this.rdnBig.TabStop = true;
            this.rdnBig.Text = "Big";
            this.rdnBig.UseVisualStyleBackColor = true;
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(431, 955);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(193, 62);
            this.btnGetOrders.TabIndex = 3;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnStrawberry);
            this.groupBox1.Controls.Add(this.rdnChocolate);
            this.groupBox1.Location = new System.Drawing.Point(37, 335);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 257);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Flavor";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.rdnSmall);
            this.groupBox2.Controls.Add(this.rdnBig);
            this.groupBox2.Controls.Add(this.rdnMedium);
            this.groupBox2.Location = new System.Drawing.Point(37, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(984, 257);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Size";
            // 
            // rdnChocolate
            // 
            this.rdnChocolate.AutoSize = true;
            this.rdnChocolate.Location = new System.Drawing.Point(24, 69);
            this.rdnChocolate.Name = "rdnChocolate";
            this.rdnChocolate.Size = new System.Drawing.Size(140, 29);
            this.rdnChocolate.TabIndex = 0;
            this.rdnChocolate.TabStop = true;
            this.rdnChocolate.Text = "Chocolate";
            this.rdnChocolate.UseVisualStyleBackColor = true;
            // 
            // rdnStrawberry
            // 
            this.rdnStrawberry.AutoSize = true;
            this.rdnStrawberry.Location = new System.Drawing.Point(24, 155);
            this.rdnStrawberry.Name = "rdnStrawberry";
            this.rdnStrawberry.Size = new System.Drawing.Size(146, 29);
            this.rdnStrawberry.TabIndex = 1;
            this.rdnStrawberry.TabStop = true;
            this.rdnStrawberry.Text = "Strawberry";
            this.rdnStrawberry.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.chkChocolate);
            this.groupBox3.Controls.Add(this.chkRaisins);
            this.groupBox3.Controls.Add(this.chkNuts);
            this.groupBox3.Location = new System.Drawing.Point(37, 636);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1011, 271);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toppings";
            // 
            // chkNuts
            // 
            this.chkNuts.AutoSize = true;
            this.chkNuts.Location = new System.Drawing.Point(24, 72);
            this.chkNuts.Name = "chkNuts";
            this.chkNuts.Size = new System.Drawing.Size(88, 29);
            this.chkNuts.TabIndex = 0;
            this.chkNuts.Text = "Nuts";
            this.chkNuts.UseVisualStyleBackColor = true;
            // 
            // chkRaisins
            // 
            this.chkRaisins.AutoSize = true;
            this.chkRaisins.Location = new System.Drawing.Point(24, 118);
            this.chkRaisins.Name = "chkRaisins";
            this.chkRaisins.Size = new System.Drawing.Size(115, 29);
            this.chkRaisins.TabIndex = 1;
            this.chkRaisins.Text = "Raisins";
            this.chkRaisins.UseVisualStyleBackColor = true;
            // 
            // chkChocolate
            // 
            this.chkChocolate.AutoSize = true;
            this.chkChocolate.Location = new System.Drawing.Point(24, 168);
            this.chkChocolate.Name = "chkChocolate";
            this.chkChocolate.Size = new System.Drawing.Size(141, 29);
            this.chkChocolate.TabIndex = 2;
            this.chkChocolate.Text = "Chocolate";
            this.chkChocolate.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Big"});
            this.comboBox1.Location = new System.Drawing.Point(530, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(410, 33);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Items.AddRange(new object[] {
            "Nuts",
            "Raisins",
            "Chocolate"});
            this.listBox1.Location = new System.Drawing.Point(530, 56);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(410, 179);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 1264);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGetOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ice Cream Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdnSmall;
        private System.Windows.Forms.RadioButton rdnMedium;
        private System.Windows.Forms.RadioButton rdnBig;
        private System.Windows.Forms.Button btnGetOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnStrawberry;
        private System.Windows.Forms.RadioButton rdnChocolate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox chkChocolate;
        private System.Windows.Forms.CheckBox chkRaisins;
        private System.Windows.Forms.CheckBox chkNuts;
    }
}

