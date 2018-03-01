namespace CatchARabbit
{
    partial class KillARabbit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KillARabbit));
            this.btnRabbit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRabbit
            // 
            this.btnRabbit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRabbit.BackgroundImage")));
            this.btnRabbit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRabbit.Location = new System.Drawing.Point(298, 154);
            this.btnRabbit.Name = "btnRabbit";
            this.btnRabbit.Size = new System.Drawing.Size(341, 184);
            this.btnRabbit.TabIndex = 0;
            this.btnRabbit.UseVisualStyleBackColor = true;
            this.btnRabbit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseDown);
            this.btnRabbit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnRabbit_MouseUp);
            // 
            // KillARabbit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 732);
            this.Controls.Add(this.btnRabbit);
            this.Name = "KillARabbit";
            this.Text = "KillARabbit";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRabbit;
    }
}