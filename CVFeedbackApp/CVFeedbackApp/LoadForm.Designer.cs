namespace CVFeedbackApp
{
    partial class LoadForm
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
            this.GTNameListBox = new System.Windows.Forms.ListBox();
            this.LoadSelectedTemplate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GTNameListBox
            // 
            this.GTNameListBox.FormattingEnabled = true;
            this.GTNameListBox.Location = new System.Drawing.Point(59, 30);
            this.GTNameListBox.Name = "GTNameListBox";
            this.GTNameListBox.Size = new System.Drawing.Size(205, 329);
            this.GTNameListBox.TabIndex = 0;
            // 
            // LoadSelectedTemplate
            // 
            this.LoadSelectedTemplate.Location = new System.Drawing.Point(299, 336);
            this.LoadSelectedTemplate.Name = "LoadSelectedTemplate";
            this.LoadSelectedTemplate.Size = new System.Drawing.Size(75, 23);
            this.LoadSelectedTemplate.TabIndex = 1;
            this.LoadSelectedTemplate.Text = "Load";
            this.LoadSelectedTemplate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select one of the following";
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadSelectedTemplate);
            this.Controls.Add(this.GTNameListBox);
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox GTNameListBox;
        private System.Windows.Forms.Button LoadSelectedTemplate;
        private System.Windows.Forms.Label label1;
    }
}