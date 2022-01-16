
namespace PersonalPurpose
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
            this.cbxLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxLanguage
            // 
            this.cbxLanguage.FormattingEnabled = true;
            this.cbxLanguage.Items.AddRange(new object[] {
            "English",
            "Български"});
            this.cbxLanguage.Location = new System.Drawing.Point(61, 59);
            this.cbxLanguage.Name = "cbxLanguage";
            this.cbxLanguage.Size = new System.Drawing.Size(121, 21);
            this.cbxLanguage.TabIndex = 28;
            this.cbxLanguage.Text = "Language";
            this.cbxLanguage.SelectedIndexChanged += new System.EventHandler(this.cbxLanguage_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Select Language";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLanguage);
            this.Name = "Form1";
            this.Text = "Computer Aide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxLanguage;
        private System.Windows.Forms.Label label1;
    }
}

