namespace auto_comment
{
    partial class Form1
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
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_comment
            // 
            this.btn_comment.BackColor = System.Drawing.Color.Transparent;
            this.btn_comment.BackgroundImage = global::auto_comment.Properties.Resources.icons8_note_512;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comment.Location = new System.Drawing.Point(345, 96);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(207, 207);
            this.btn_comment.TabIndex = 0;
            this.btn_comment.UseVisualStyleBackColor = false;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.BackgroundImage = global::auto_comment.Properties.Resources.OpenCode;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.Location = new System.Drawing.Point(43, 96);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(207, 207);
            this.btn_open.TabIndex = 1;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2500, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Auto-Commenter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(178, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 47);
            this.label2.TabIndex = 3;
            this.label2.Text = "Auto-Comment";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = global::auto_comment.Properties.Resources.backgrondcode;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_comment);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

