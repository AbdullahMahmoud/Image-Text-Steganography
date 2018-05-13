namespace ImageQuantization
{
    partial class TextHiding
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
            this.btntextDecryption = new System.Windows.Forms.Button();
            this.btnTextEncryption = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntextDecryption
            // 
            this.btntextDecryption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btntextDecryption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btntextDecryption.Location = new System.Drawing.Point(730, 346);
            this.btntextDecryption.Name = "btntextDecryption";
            this.btntextDecryption.Size = new System.Drawing.Size(400, 100);
            this.btntextDecryption.TabIndex = 6;
            this.btntextDecryption.Text = "Text Decryption ";
            this.btntextDecryption.UseVisualStyleBackColor = false;
            this.btntextDecryption.Click += new System.EventHandler(this.btntextDecryption_Click);
            // 
            // btnTextEncryption
            // 
            this.btnTextEncryption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTextEncryption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTextEncryption.Location = new System.Drawing.Point(112, 346);
            this.btnTextEncryption.Name = "btnTextEncryption";
            this.btnTextEncryption.Size = new System.Drawing.Size(400, 100);
            this.btnTextEncryption.TabIndex = 5;
            this.btnTextEncryption.Text = "Text Encryption";
            this.btnTextEncryption.UseVisualStyleBackColor = false;
            this.btnTextEncryption.Click += new System.EventHandler(this.btnTextEncryption_Click);
            // 
            // TextHiding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 792);
            this.Controls.Add(this.btntextDecryption);
            this.Controls.Add(this.btnTextEncryption);
            this.Name = "TextHiding";
            this.Text = "TextHiding";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntextDecryption;
        private System.Windows.Forms.Button btnTextEncryption;
    }
}