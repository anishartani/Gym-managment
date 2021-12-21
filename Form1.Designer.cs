
namespace Gym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cnx = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pann_child = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pann_child.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menu.AutoSize = true;
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(76)))));
            this.menu.Controls.Add(this.button1);
            this.menu.Controls.Add(this.btn_list);
            this.menu.Controls.Add(this.btn_add);
            this.menu.Controls.Add(this.btn_cnx);
            this.menu.Controls.Add(this.logo);
            this.menu.Location = new System.Drawing.Point(1, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(223, 561);
            this.menu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Hina Mincho", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Gym.Properties.Resources.Apps_Home_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 70);
            this.button1.TabIndex = 5;
            this.button1.Text = "       Accueil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_list
            // 
            this.btn_list.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_list.Font = new System.Drawing.Font("Hina Mincho", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_list.ForeColor = System.Drawing.Color.White;
            this.btn_list.Image = global::Gym.Properties.Resources.Apps_Contacts_icon;
            this.btn_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list.Location = new System.Drawing.Point(0, 318);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(223, 70);
            this.btn_list.TabIndex = 4;
            this.btn_list.Text = "       List";
            this.btn_list.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_add
            // 
            this.btn_add.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Hina Mincho", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Image = global::Gym.Properties.Resources.Add_icon;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(0, 248);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(223, 70);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "       Ajouter";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_cnx
            // 
            this.btn_cnx.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_cnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cnx.Font = new System.Drawing.Font("Hina Mincho", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnx.ForeColor = System.Drawing.Color.White;
            this.btn_cnx.Image = global::Gym.Properties.Resources.Admin_icon;
            this.btn_cnx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cnx.Location = new System.Drawing.Point(0, 178);
            this.btn_cnx.Name = "btn_cnx";
            this.btn_cnx.Size = new System.Drawing.Size(223, 70);
            this.btn_cnx.TabIndex = 2;
            this.btn_cnx.Text = "       Connexion";
            this.btn_cnx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cnx.UseVisualStyleBackColor = true;
            this.btn_cnx.Click += new System.EventHandler(this.btn_cnx_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(57)))));
            this.logo.Controls.Add(this.pictureBox2);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(223, 178);
            this.logo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::Gym.Properties.Resources.Gym_logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(223, 179);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pann_child
            // 
            this.pann_child.BackColor = System.Drawing.Color.DarkRed;
            this.pann_child.Controls.Add(this.pictureBox1);
            this.pann_child.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pann_child.Location = new System.Drawing.Point(0, 0);
            this.pann_child.Name = "pann_child";
            this.pann_child.Size = new System.Drawing.Size(984, 561);
            this.pann_child.TabIndex = 1;
            this.pann_child.Paint += new System.Windows.Forms.PaintEventHandler(this.pann_child_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gym.Properties.Resources.Home_page;
            this.pictureBox1.Location = new System.Drawing.Point(222, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 574);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pann_child);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accueil";
            this.menu.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pann_child.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Button btn_cnx;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btn_list;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pann_child;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

