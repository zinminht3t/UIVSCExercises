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
            this.SuspendLayout();
            // 
            // rdnSmall
            // 
            this.rdnSmall.AutoSize = true;
            this.rdnSmall.Location = new System.Drawing.Point(31, 37);
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
            this.rdnMedium.Location = new System.Drawing.Point(31, 96);
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
            this.rdnBig.Location = new System.Drawing.Point(31, 152);
            this.rdnBig.Name = "rdnBig";
            this.rdnBig.Size = new System.Drawing.Size(74, 29);
            this.rdnBig.TabIndex = 2;
            this.rdnBig.TabStop = true;
            this.rdnBig.Text = "Big";
            this.rdnBig.UseVisualStyleBackColor = true;
            // 
            // btnGetOrders
            // 
            this.btnGetOrders.Location = new System.Drawing.Point(148, 637);
            this.btnGetOrders.Name = "btnGetOrders";
            this.btnGetOrders.Size = new System.Drawing.Size(193, 62);
            this.btnGetOrders.TabIndex = 3;
            this.btnGetOrders.Text = "Get Orders";
            this.btnGetOrders.UseVisualStyleBackColor = true;
            this.btnGetOrders.Click += new System.EventHandler(this.btnGetOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 763);
            this.Controls.Add(this.btnGetOrders);
            this.Controls.Add(this.rdnBig);
            this.Controls.Add(this.rdnMedium);
            this.Controls.Add(this.rdnSmall);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ice Cream Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdnSmall;
        private System.Windows.Forms.RadioButton rdnMedium;
        private System.Windows.Forms.RadioButton rdnBig;
        private System.Windows.Forms.Button btnGetOrders;
    }
}

