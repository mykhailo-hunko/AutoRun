namespace AutoRun
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_start_scopus = new System.Windows.Forms.Button();
            this.button_start_scholar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_start_scopus
            // 
            this.button_start_scopus.Location = new System.Drawing.Point(71, 106);
            this.button_start_scopus.Name = "button_start_scopus";
            this.button_start_scopus.Size = new System.Drawing.Size(160, 79);
            this.button_start_scopus.TabIndex = 0;
            this.button_start_scopus.Text = "Run Now (Scopus)";
            this.button_start_scopus.UseVisualStyleBackColor = true;
            this.button_start_scopus.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_start_scholar
            // 
            this.button_start_scholar.Location = new System.Drawing.Point(324, 106);
            this.button_start_scholar.Name = "button_start_scholar";
            this.button_start_scholar.Size = new System.Drawing.Size(168, 79);
            this.button_start_scholar.TabIndex = 1;
            this.button_start_scholar.Text = "Run Now (Google Scholar)";
            this.button_start_scholar.UseVisualStyleBackColor = true;
            this.button_start_scholar.Click += new System.EventHandler(this.button_start_scholar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 291);
            this.Controls.Add(this.button_start_scholar);
            this.Controls.Add(this.button_start_scopus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_start_scopus;
        private System.Windows.Forms.Button button_start_scholar;
    }
}

