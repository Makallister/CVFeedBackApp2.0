namespace CVFeedbackApp
{
    partial class SetOptionsForm
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
            this.OptionTitleTextBox = new System.Windows.Forms.TextBox();
            this.OptionMessageTextBox = new System.Windows.Forms.RichTextBox();
            this.AddOptiontoSet = new System.Windows.Forms.Button();
            this.NewOptionSet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FinishTemplate = new System.Windows.Forms.Button();
            this.EditPreviousOptionSetTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OptionTitleTextBox
            // 
            this.OptionTitleTextBox.Location = new System.Drawing.Point(57, 112);
            this.OptionTitleTextBox.Name = "OptionTitleTextBox";
            this.OptionTitleTextBox.Size = new System.Drawing.Size(242, 20);
            this.OptionTitleTextBox.TabIndex = 0;
            // 
            // OptionMessageTextBox
            // 
            this.OptionMessageTextBox.Location = new System.Drawing.Point(57, 171);
            this.OptionMessageTextBox.Name = "OptionMessageTextBox";
            this.OptionMessageTextBox.Size = new System.Drawing.Size(864, 169);
            this.OptionMessageTextBox.TabIndex = 1;
            this.OptionMessageTextBox.Text = "";
            // 
            // AddOptiontoSet
            // 
            this.AddOptiontoSet.Location = new System.Drawing.Point(60, 366);
            this.AddOptiontoSet.Name = "AddOptiontoSet";
            this.AddOptiontoSet.Size = new System.Drawing.Size(205, 23);
            this.AddOptiontoSet.TabIndex = 2;
            this.AddOptiontoSet.Text = "Save and add other option";
            this.AddOptiontoSet.UseVisualStyleBackColor = true;
            this.AddOptiontoSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AddOptiontoSet_MouseClick);
            // 
            // NewOptionSet
            // 
            this.NewOptionSet.Location = new System.Drawing.Point(325, 366);
            this.NewOptionSet.Name = "NewOptionSet";
            this.NewOptionSet.Size = new System.Drawing.Size(191, 23);
            this.NewOptionSet.TabIndex = 3;
            this.NewOptionSet.Text = "Save and add other option set";
            this.NewOptionSet.UseVisualStyleBackColor = true;
            this.NewOptionSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NewOptionSet_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(57, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Section Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Option Title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Message";
            // 
            // FinishTemplate
            // 
            this.FinishTemplate.Location = new System.Drawing.Point(577, 366);
            this.FinishTemplate.Name = "FinishTemplate";
            this.FinishTemplate.Size = new System.Drawing.Size(153, 23);
            this.FinishTemplate.TabIndex = 9;
            this.FinishTemplate.Text = "Save and Finish";
            this.FinishTemplate.UseVisualStyleBackColor = true;
            this.FinishTemplate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FinishTemplate_MouseClick);
            // 
            // EditPreviousOptionSetTitle
            // 
            this.EditPreviousOptionSetTitle.Location = new System.Drawing.Point(801, 366);
            this.EditPreviousOptionSetTitle.Name = "EditPreviousOptionSetTitle";
            this.EditPreviousOptionSetTitle.Size = new System.Drawing.Size(120, 23);
            this.EditPreviousOptionSetTitle.TabIndex = 10;
            this.EditPreviousOptionSetTitle.Text = "<< Previous";
            this.EditPreviousOptionSetTitle.UseVisualStyleBackColor = true;
            this.EditPreviousOptionSetTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EditPreviousOptionSetTitle_MouseClick);
            // 
            // SetOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 401);
            this.Controls.Add(this.EditPreviousOptionSetTitle);
            this.Controls.Add(this.FinishTemplate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.NewOptionSet);
            this.Controls.Add(this.AddOptiontoSet);
            this.Controls.Add(this.OptionMessageTextBox);
            this.Controls.Add(this.OptionTitleTextBox);
            this.Name = "SetOptionsForm";
            this.Text = "SetOptionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OptionTitleTextBox;
        private System.Windows.Forms.RichTextBox OptionMessageTextBox;
        private System.Windows.Forms.Button AddOptiontoSet;
        private System.Windows.Forms.Button NewOptionSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button FinishTemplate;
        private System.Windows.Forms.Button EditPreviousOptionSetTitle;
    }
}