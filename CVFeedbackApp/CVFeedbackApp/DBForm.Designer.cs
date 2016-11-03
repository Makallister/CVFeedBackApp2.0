namespace CVFeedbackApp
{
    partial class DBForm
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
            this.components = new System.ComponentModel.Container();
            this.DBdgv = new System.Windows.Forms.DataGridView();
            this.templateDBDataSet = new CVFeedbackApp.TemplateDBDataSet();
            this.templateDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DBdgv
            // 
            this.DBdgv.AutoGenerateColumns = false;
            this.DBdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBdgv.DataSource = this.templateDBDataSetBindingSource;
            this.DBdgv.Location = new System.Drawing.Point(12, 12);
            this.DBdgv.Name = "DBdgv";
            this.DBdgv.Size = new System.Drawing.Size(521, 450);
            this.DBdgv.TabIndex = 0;
            // 
            // templateDBDataSet
            // 
            this.templateDBDataSet.DataSetName = "TemplateDBDataSet";
            this.templateDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // templateDBDataSetBindingSource
            // 
            this.templateDBDataSetBindingSource.DataSource = this.templateDBDataSet;
            this.templateDBDataSetBindingSource.Position = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DBForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 474);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DBdgv);
            this.Name = "DBForm";
            this.Text = "DBForm";
            ((System.ComponentModel.ISupportInitialize)(this.DBdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.templateDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DBdgv;
        private System.Windows.Forms.BindingSource templateDBDataSetBindingSource;
        private TemplateDBDataSet templateDBDataSet;
        private System.Windows.Forms.Button button1;
    }
}