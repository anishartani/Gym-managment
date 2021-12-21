
namespace Gym
{
    partial class Connexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.cnx_lab = new System.Windows.Forms.Label();
            this.user_lab = new System.Windows.Forms.Label();
            this.pass_lab = new System.Windows.Forms.Label();
            this.user_text = new System.Windows.Forms.TextBox();
            this.user_pass = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cnx_backg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnx_backg)).BeginInit();
            this.SuspendLayout();
            // 
            // cnx_lab
            // 
            this.cnx_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cnx_lab.AutoSize = true;
            this.cnx_lab.Font = new System.Drawing.Font("Hina Mincho", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cnx_lab.ForeColor = System.Drawing.Color.White;
            this.cnx_lab.Location = new System.Drawing.Point(748, 42);
            this.cnx_lab.Name = "cnx_lab";
            this.cnx_lab.Size = new System.Drawing.Size(170, 51);
            this.cnx_lab.TabIndex = 1;
            this.cnx_lab.Text = "Connexion";
            // 
            // user_lab
            // 
            this.user_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.user_lab.AutoSize = true;
            this.user_lab.Font = new System.Drawing.Font("Hina Mincho", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_lab.ForeColor = System.Drawing.Color.White;
            this.user_lab.Location = new System.Drawing.Point(748, 154);
            this.user_lab.Name = "user_lab";
            this.user_lab.Size = new System.Drawing.Size(170, 51);
            this.user_lab.TabIndex = 1;
            this.user_lab.Text = "Utilisateur";
            // 
            // pass_lab
            // 
            this.pass_lab.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pass_lab.AutoSize = true;
            this.pass_lab.Font = new System.Drawing.Font("Hina Mincho", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_lab.ForeColor = System.Drawing.Color.White;
            this.pass_lab.Location = new System.Drawing.Point(731, 307);
            this.pass_lab.Name = "pass_lab";
            this.pass_lab.Size = new System.Drawing.Size(207, 51);
            this.pass_lab.TabIndex = 1;
            this.pass_lab.Text = "Mot de passe";
            // 
            // user_text
            // 
            this.user_text.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.user_text.Font = new System.Drawing.Font("Hina Mincho", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_text.ForeColor = System.Drawing.SystemColors.WindowText;
            this.user_text.Location = new System.Drawing.Point(699, 235);
            this.user_text.MaxLength = 15;
            this.user_text.Name = "user_text";
            this.user_text.Size = new System.Drawing.Size(263, 61);
            this.user_text.TabIndex = 1;
            this.user_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // user_pass
            // 
            this.user_pass.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.user_pass.Font = new System.Drawing.Font("Hina Mincho", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_pass.Location = new System.Drawing.Point(699, 385);
            this.user_pass.MaxLength = 15;
            this.user_pass.Name = "user_pass";
            this.user_pass.Size = new System.Drawing.Size(263, 47);
            this.user_pass.TabIndex = 2;
            this.user_pass.UseSystemPasswordChar = true;
            this.user_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_pass_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.arrow_back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Hina Mincho", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Gym.Properties.Resources.desk_icon;
            this.button1.Location = new System.Drawing.Point(699, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(263, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connexion";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cnx_backg
            // 
            this.cnx_backg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cnx_backg.Image = global::Gym.Properties.Resources.Login_page;
            this.cnx_backg.Location = new System.Drawing.Point(0, 0);
            this.cnx_backg.Name = "cnx_backg";
            this.cnx_backg.Size = new System.Drawing.Size(984, 561);
            this.cnx_backg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cnx_backg.TabIndex = 0;
            this.cnx_backg.TabStop = false;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_pass);
            this.Controls.Add(this.user_text);
            this.Controls.Add(this.pass_lab);
            this.Controls.Add(this.user_lab);
            this.Controls.Add(this.cnx_lab);
            this.Controls.Add(this.cnx_backg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "cnx";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cnx_backg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cnx_backg;
        private System.Windows.Forms.Label cnx_lab;
        private System.Windows.Forms.Label user_lab;
        private System.Windows.Forms.Label pass_lab;
        private System.Windows.Forms.TextBox user_text;
        private System.Windows.Forms.TextBox user_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}