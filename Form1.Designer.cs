namespace Runes_Importer_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_get_runes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_get_runes
            // 
            this.btn_get_runes.Location = new System.Drawing.Point(439, 201);
            this.btn_get_runes.Name = "btn_get_runes";
            this.btn_get_runes.Size = new System.Drawing.Size(94, 29);
            this.btn_get_runes.TabIndex = 0;
            this.btn_get_runes.Text = "button1";
            this.btn_get_runes.UseVisualStyleBackColor = true;
            this.btn_get_runes.Click += new System.EventHandler(this.btn_get_runes_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_get_runes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_get_runes;
    }
}