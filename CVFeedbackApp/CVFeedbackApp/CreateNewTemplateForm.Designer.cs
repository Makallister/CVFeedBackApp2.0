namespace CVFeedbackApp
{
    partial class CreateNewTemplateForm
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
            this.HeaderTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FooterTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveHeaderAndFooter = new System.Windows.Forms.Button();
            this.LoadTemplate = new System.Windows.Forms.Button();
            this.PreviewCurrentTemplate = new System.Windows.Forms.Button();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeaderTextBox
            // 
            this.HeaderTextBox.Location = new System.Drawing.Point(35, 109);
            this.HeaderTextBox.Name = "HeaderTextBox";
            this.HeaderTextBox.Size = new System.Drawing.Size(541, 169);
            this.HeaderTextBox.TabIndex = 0;
            this.HeaderTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Header";
            // 
            // FooterTextBox
            // 
            this.FooterTextBox.Location = new System.Drawing.Point(35, 312);
            this.FooterTextBox.Name = "FooterTextBox";
            this.FooterTextBox.Size = new System.Drawing.Size(538, 176);
            this.FooterTextBox.TabIndex = 2;
            this.FooterTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Footer";
            // 
            // SaveHeaderAndFooter
            // 
            this.SaveHeaderAndFooter.Location = new System.Drawing.Point(38, 578);
            this.SaveHeaderAndFooter.Name = "SaveHeaderAndFooter";
            this.SaveHeaderAndFooter.Size = new System.Drawing.Size(89, 23);
            this.SaveHeaderAndFooter.TabIndex = 4;
            this.SaveHeaderAndFooter.Text = "Next >>";
            this.SaveHeaderAndFooter.UseVisualStyleBackColor = true;
            this.SaveHeaderAndFooter.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveHeaderAndFooter_MouseClick);
            // 
            // LoadTemplate
            // 
            this.LoadTemplate.Location = new System.Drawing.Point(244, 578);
            this.LoadTemplate.Name = "LoadTemplate";
            this.LoadTemplate.Size = new System.Drawing.Size(105, 23);
            this.LoadTemplate.TabIndex = 5;
            this.LoadTemplate.Text = "Load";
            this.LoadTemplate.UseVisualStyleBackColor = true;
            this.LoadTemplate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoadTemplate_MouseClick);
            // 
            // PreviewCurrentTemplate
            // 
            this.PreviewCurrentTemplate.Location = new System.Drawing.Point(506, 578);
            this.PreviewCurrentTemplate.Name = "PreviewCurrentTemplate";
            this.PreviewCurrentTemplate.Size = new System.Drawing.Size(75, 23);
            this.PreviewCurrentTemplate.TabIndex = 7;
            this.PreviewCurrentTemplate.Text = "Preview";
            this.PreviewCurrentTemplate.UseVisualStyleBackColor = true;
            this.PreviewCurrentTemplate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PreviewCurrentTemplate_MouseClick);
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(35, 52);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Title";
            // 
            // CreateNewTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 639);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.PreviewCurrentTemplate);
            this.Controls.Add(this.LoadTemplate);
            this.Controls.Add(this.SaveHeaderAndFooter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FooterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeaderTextBox);
            this.Name = "CreateNewTemplateForm";
            this.Text = "CreateNewTemplateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox HeaderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox FooterTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveHeaderAndFooter;
        private System.Windows.Forms.Button LoadTemplate;
        private System.Windows.Forms.Button PreviewCurrentTemplate;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label label3;
    }
}