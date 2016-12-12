namespace CVFeedbackApp
{
    partial class EditTemplateForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.ReturnToMenu = new System.Windows.Forms.Button();
            this.LoadTemplate = new System.Windows.Forms.Button();
            this.SaveHeaderAndFooter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FooterTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeaderTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, -15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(172, 49);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(100, 20);
            this.TitleTextBox.TabIndex = 10;
            // 
            // ReturnToMenu
            // 
            this.ReturnToMenu.Location = new System.Drawing.Point(508, 530);
            this.ReturnToMenu.Name = "ReturnToMenu";
            this.ReturnToMenu.Size = new System.Drawing.Size(75, 23);
            this.ReturnToMenu.TabIndex = 17;
            this.ReturnToMenu.Text = "Return";
            this.ReturnToMenu.UseVisualStyleBackColor = true;
            this.ReturnToMenu.Click += new System.EventHandler(this.ReturnToMenu_Click);
            // 
            // LoadTemplate
            // 
            this.LoadTemplate.Location = new System.Drawing.Point(246, 530);
            this.LoadTemplate.Name = "LoadTemplate";
            this.LoadTemplate.Size = new System.Drawing.Size(105, 23);
            this.LoadTemplate.TabIndex = 16;
            this.LoadTemplate.Text = "Load";
            this.LoadTemplate.UseVisualStyleBackColor = true;
            this.LoadTemplate.Click += new System.EventHandler(this.LoadTemplate_Click);
            // 
            // SaveHeaderAndFooter
            // 
            this.SaveHeaderAndFooter.Location = new System.Drawing.Point(40, 530);
            this.SaveHeaderAndFooter.Name = "SaveHeaderAndFooter";
            this.SaveHeaderAndFooter.Size = new System.Drawing.Size(89, 23);
            this.SaveHeaderAndFooter.TabIndex = 15;
            this.SaveHeaderAndFooter.Text = "Save Edit";
            this.SaveHeaderAndFooter.UseVisualStyleBackColor = true;
            this.SaveHeaderAndFooter.Click += new System.EventHandler(this.SaveHeaderAndFooter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Footer";
            // 
            // FooterTextBox
            // 
            this.FooterTextBox.Location = new System.Drawing.Point(40, 309);
            this.FooterTextBox.Name = "FooterTextBox";
            this.FooterTextBox.Size = new System.Drawing.Size(538, 176);
            this.FooterTextBox.TabIndex = 13;
            this.FooterTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Header";
            // 
            // HeaderTextBox
            // 
            this.HeaderTextBox.Location = new System.Drawing.Point(40, 106);
            this.HeaderTextBox.Name = "HeaderTextBox";
            this.HeaderTextBox.Size = new System.Drawing.Size(541, 169);
            this.HeaderTextBox.TabIndex = 12;
            this.HeaderTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Title";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(40, 49);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.IDTextBox.TabIndex = 20;
            // 
            // EditTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.ReturnToMenu);
            this.Controls.Add(this.LoadTemplate);
            this.Controls.Add(this.SaveHeaderAndFooter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FooterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeaderTextBox);
            this.Name = "EditTemplateForm";
            this.Text = "EditTemplateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Button ReturnToMenu;
        private System.Windows.Forms.Button LoadTemplate;
        private System.Windows.Forms.Button SaveHeaderAndFooter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox FooterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox HeaderTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IDTextBox;
    }
}