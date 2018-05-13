namespace ImageQuantization
{
    partial class MainForm
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
            this.btntexthiding = new System.Windows.Forms.Button();
            this.btnImageViewer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntexthiding
            // 
            this.btntexthiding.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btntexthiding.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btntexthiding.Location = new System.Drawing.Point(703, 239);
            this.btntexthiding.Name = "btntexthiding";
            this.btntexthiding.Size = new System.Drawing.Size(400, 100);
            this.btntexthiding.TabIndex = 4;
            this.btntexthiding.Text = "Text Hiding Application";
            this.btntexthiding.UseVisualStyleBackColor = false;
            this.btntexthiding.Click += new System.EventHandler(this.btntexthiding_Click);
            // 
            // btnImageViewer
            // 
            this.btnImageViewer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnImageViewer.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnImageViewer.Location = new System.Drawing.Point(85, 239);
            this.btnImageViewer.Name = "btnImageViewer";
            this.btnImageViewer.Size = new System.Drawing.Size(400, 100);
            this.btnImageViewer.TabIndex = 3;
            this.btnImageViewer.Text = "Image Viewer ";
            this.btnImageViewer.UseVisualStyleBackColor = false;
            this.btnImageViewer.Click += new System.EventHandler(this.btnImageViewer_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 615);
            this.Controls.Add(this.btntexthiding);
            this.Controls.Add(this.btnImageViewer);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Image Quantization...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntexthiding;
        private System.Windows.Forms.Button btnImageViewer;

    }
}

