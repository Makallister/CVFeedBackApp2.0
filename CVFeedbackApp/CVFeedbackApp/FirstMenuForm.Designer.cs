namespace CVFeedbackApp
{
    partial class FirstMenuForm
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
            this.NewTemplateButton = new System.Windows.Forms.Button();
            this.EditTemplateButton = new System.Windows.Forms.Button();
            this.MakeReplyButton = new System.Windows.Forms.Button();
            this.DBButton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewTemplateButton
            // 
            this.NewTemplateButton.Location = new System.Drawing.Point(91, 145);
            this.NewTemplateButton.Name = "NewTemplateButton";
            this.NewTemplateButton.Size = new System.Drawing.Size(99, 42);
            this.NewTemplateButton.TabIndex = 0;
            this.NewTemplateButton.Text = "Create New Template";
            this.NewTemplateButton.UseVisualStyleBackColor = true;
            this.NewTemplateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewTemplateButton_MouseClick);
            // 
            // EditTemplateButton
            // 
            this.EditTemplateButton.Location = new System.Drawing.Point(251, 144);
            this.EditTemplateButton.Name = "EditTemplateButton";
            this.EditTemplateButton.Size = new System.Drawing.Size(89, 43);
            this.EditTemplateButton.TabIndex = 1;
            this.EditTemplateButton.Text = "Edit Existing Template";
            this.EditTemplateButton.UseVisualStyleBackColor = true;
            this.EditTemplateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditButton_MouseClick);
            // 
            // MakeReplyButton
            // 
            this.MakeReplyButton.Location = new System.Drawing.Point(401, 144);
            this.MakeReplyButton.Name = "MakeReplyButton";
            this.MakeReplyButton.Size = new System.Drawing.Size(112, 43);
            this.MakeReplyButton.TabIndex = 2;
            this.MakeReplyButton.Text = "Make Reply";
            this.MakeReplyButton.UseVisualStyleBackColor = true;
            this.MakeReplyButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MakeReplyButton_MouseClick);
            // 
            // DBButton1
            // 
            this.DBButton1.Location = new System.Drawing.Point(258, 257);
            this.DBButton1.Name = "DBButton1";
            this.DBButton1.Size = new System.Drawing.Size(75, 23);
            this.DBButton1.TabIndex = 3;
            this.DBButton1.Text = "View DB";
            this.DBButton1.UseVisualStyleBackColor = true;
            this.DBButton1.Click += new System.EventHandler(this.DBButton1_Click);
            // 
            // FirstMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 319);
            this.Controls.Add(this.DBButton1);
            this.Controls.Add(this.MakeReplyButton);
            this.Controls.Add(this.EditTemplateButton);
            this.Controls.Add(this.NewTemplateButton);
            this.Name = "FirstMenuForm";
            this.Text = "Reply Helper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTemplateButton;
        private System.Windows.Forms.Button EditTemplateButton;
        private System.Windows.Forms.Button MakeReplyButton;
        private System.Windows.Forms.Button DBButton1;
    }
}

