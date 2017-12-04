namespace Animium
{
    partial class chrome
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
            this.pContainer = new System.Windows.Forms.Panel();
            this.textUrl = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.Location = new System.Drawing.Point(12, 63);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(621, 341);
            this.pContainer.TabIndex = 9;
            this.pContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pContainer_Paint);
            // 
            // textUrl
            // 
            this.textUrl.Location = new System.Drawing.Point(12, 19);
            this.textUrl.Name = "textUrl";
            this.textUrl.Size = new System.Drawing.Size(501, 20);
            this.textUrl.TabIndex = 11;
            this.textUrl.ModifiedChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textUrl.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(537, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(96, 33);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Watch";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.button5_Click);
            // 
            // chrome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 416);
            this.Controls.Add(this.textUrl);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.pContainer);
            this.Name = "chrome";
            this.Text = "aform2watch";
            this.Load += new System.EventHandler(this.aform2watch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pContainer;
        private System.Windows.Forms.Button btnGo;
        public System.Windows.Forms.TextBox textUrl;
    }
}