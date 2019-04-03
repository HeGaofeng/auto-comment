namespace auto_comment
{
    partial class auto_comment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(auto_comment));
            this.btn_comment = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_twitter = new System.Windows.Forms.Button();
            this.btn_options = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_comment
            // 
            this.btn_comment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_comment.BackColor = System.Drawing.Color.Transparent;
            this.btn_comment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_comment.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_comment.FlatAppearance.BorderSize = 0;
            this.btn_comment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comment.Location = new System.Drawing.Point(544, 173);
            this.btn_comment.Name = "btn_comment";
            this.btn_comment.Size = new System.Drawing.Size(239, 212);
            this.btn_comment.TabIndex = 0;
            this.btn_comment.UseVisualStyleBackColor = false;
            this.btn_comment.Click += new System.EventHandler(this.btn_comment_Click);
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.BackColor = System.Drawing.Color.Transparent;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_open.FlatAppearance.BorderSize = 0;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.Location = new System.Drawing.Point(164, 188);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(258, 197);
            this.btn_open.TabIndex = 1;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_twitter
            // 
            this.btn_twitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_twitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_twitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_twitter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_twitter.FlatAppearance.BorderSize = 0;
            this.btn_twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_twitter.Location = new System.Drawing.Point(24, 385);
            this.btn_twitter.Name = "btn_twitter";
            this.btn_twitter.Size = new System.Drawing.Size(131, 104);
            this.btn_twitter.TabIndex = 4;
            this.btn_twitter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btn_twitter.UseVisualStyleBackColor = false;
            this.btn_twitter.Click += new System.EventHandler(this.btn_twitter_Click);
            // 
            // btn_options
            // 
            this.btn_options.BackColor = System.Drawing.Color.Transparent;
            this.btn_options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btn_options.FlatAppearance.BorderSize = 0;
            this.btn_options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_options.Location = new System.Drawing.Point(766, 420);
            this.btn_options.Name = "btn_options";
            this.btn_options.Size = new System.Drawing.Size(166, 69);
            this.btn_options.TabIndex = 5;
            this.btn_options.UseVisualStyleBackColor = false;
            this.btn_options.Click += new System.EventHandler(this.btn_options_Click);

            // 
            // auto_comment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImage = global::auto_comment.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.btn_options);
            this.Controls.Add(this.btn_twitter);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_comment);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(960, 540);
            this.Name = "auto_comment";
            this.Text = "Auto-Comment";
            this.ResumeLayout(false);
            this.MaximizeBox = false;
            // Set the MinimizeBox to false to remove the minimize box.
            this.MinimizeBox = false;

        }

        #endregion

        private System.Windows.Forms.Button btn_comment;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_twitter;
        private System.Windows.Forms.Button btn_options;
    }
}

