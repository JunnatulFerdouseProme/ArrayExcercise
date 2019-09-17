namespace ArrayExcercise
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.arraytextbox = new System.Windows.Forms.TextBox();
            this.itemrichtextbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(76, 109);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "ShowButton";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Element";
            // 
            // arraytextbox
            // 
            this.arraytextbox.Location = new System.Drawing.Point(76, 32);
            this.arraytextbox.Name = "arraytextbox";
            this.arraytextbox.Size = new System.Drawing.Size(100, 20);
            this.arraytextbox.TabIndex = 2;
         
            // 
            // itemrichtextbox
            // 
            this.itemrichtextbox.Location = new System.Drawing.Point(259, 36);
            this.itemrichtextbox.Name = "itemrichtextbox";
            this.itemrichtextbox.Size = new System.Drawing.Size(255, 263);
            this.itemrichtextbox.TabIndex = 3;
            this.itemrichtextbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemrichtextbox);
            this.Controls.Add(this.arraytextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox arraytextbox;
        private System.Windows.Forms.RichTextBox itemrichtextbox;
    }
}

