namespace ImageQuantization
{
    partial class TextDecryption
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTextEncryption = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(102, 474);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 100);
            this.button1.TabIndex = 25;
            this.button1.Text = "Decrypt";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(970, 742);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Secret Message";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(599, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(899, 727);
            this.richTextBox1.TabIndex = 23;
            this.richTextBox1.Text = "";
            // 
            // btnTextEncryption
            // 
            this.btnTextEncryption.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnTextEncryption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnTextEncryption.Location = new System.Drawing.Point(102, 181);
            this.btnTextEncryption.Name = "btnTextEncryption";
            this.btnTextEncryption.Size = new System.Drawing.Size(400, 100);
            this.btnTextEncryption.TabIndex = 22;
            this.btnTextEncryption.Text = "Select File";
            this.btnTextEncryption.UseVisualStyleBackColor = false;
            this.btnTextEncryption.Click += new System.EventHandler(this.btnTextEncryption_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TextDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1510, 775);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnTextEncryption);
            this.Name = "TextDecryption";
            this.Text = "TextDecryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTextEncryption;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}