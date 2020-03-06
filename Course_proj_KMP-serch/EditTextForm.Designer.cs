namespace Course_proj_KMP_serch
{
    partial class EditTextForm
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
            this.richTextBoxEditText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxEditText
            // 
            this.richTextBoxEditText.Location = new System.Drawing.Point(-1, 0);
            this.richTextBoxEditText.Name = "richTextBoxEditText";
            this.richTextBoxEditText.Size = new System.Drawing.Size(666, 397);
            this.richTextBoxEditText.TabIndex = 0;
            this.richTextBoxEditText.Text = "";
            // 
            // EditTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 397);
            this.Controls.Add(this.richTextBoxEditText);
            this.Name = "EditTextForm";
            this.Text = "EditTextForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditTextForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxEditText;
    }
}