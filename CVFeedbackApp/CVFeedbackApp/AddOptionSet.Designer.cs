namespace CVFeedbackApp
{
    partial class AddOptionSet
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
            this.OptionSetTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveOtionCategory = new System.Windows.Forms.Button();
            this.EditPreviousOptions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptionSetTitle
            // 
            this.OptionSetTitle.Location = new System.Drawing.Point(77, 84);
            this.OptionSetTitle.Name = "OptionSetTitle";
            this.OptionSetTitle.Size = new System.Drawing.Size(206, 20);
            this.OptionSetTitle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Introduce a title of a section you want to comment on";
            // 
            // SaveOtionCategory
            // 
            this.SaveOtionCategory.Location = new System.Drawing.Point(77, 236);
            this.SaveOtionCategory.Name = "SaveOtionCategory";
            this.SaveOtionCategory.Size = new System.Drawing.Size(89, 23);
            this.SaveOtionCategory.TabIndex = 2;
            this.SaveOtionCategory.Text = "Next >>";
            this.SaveOtionCategory.UseVisualStyleBackColor = true;
            this.SaveOtionCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveOptionCategory_MouseClick);
            // 
            // EditPreviousOptions
            // 
            this.EditPreviousOptions.Location = new System.Drawing.Point(247, 236);
            this.EditPreviousOptions.Name = "EditPreviousOptions";
            this.EditPreviousOptions.Size = new System.Drawing.Size(75, 23);
            this.EditPreviousOptions.TabIndex = 3;
            this.EditPreviousOptions.Text = "<< Previous";
            this.EditPreviousOptions.UseVisualStyleBackColor = true;
            this.EditPreviousOptions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditPreviousOptions_MouseClick);
            // 
            // AddOptionSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 303);
            this.Controls.Add(this.EditPreviousOptions);
            this.Controls.Add(this.SaveOtionCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptionSetTitle);
            this.Name = "AddOptionSet";
            this.Text = "AddOptionSet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OptionSetTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveOtionCategory;
        private System.Windows.Forms.Button EditPreviousOptions;
    }
}