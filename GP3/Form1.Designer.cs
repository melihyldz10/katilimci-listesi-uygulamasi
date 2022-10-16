
namespace GP3
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.list = new Guna.UI.WinForms.GunaButton();
            this.git = new Guna.UI.WinForms.GunaButton();
            this.tamG = new Guna.UI.WinForms.GunaButton();
            this.tamGel = new Guna.UI.WinForms.GunaButton();
            this.gel = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaGradientPanel1.SuspendLayout();
            this.gunaGradientPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Orhan Kemal.",
            "Aziz Nesin. ",
            "Kemal Tahir.",
            "Melih Cevdet Anday.",
            "Faruk Nafiz Çamlıbel.",
            "Nazım Hikmet Ran.",
            "Nurullah Ataç ",
            "Orhan Veli Kanık.",
            "Edgar Allan Poe.",
            "Tolstoy ",
            "Lewis Carroll",
            "Mark Twain",
            "Oscar Wilde",
            "Arthur Conan Doyle",
            "Jack London"});
            this.listBox1.Location = new System.Drawing.Point(41, 116);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(250, 340);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(86, 116);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(250, 340);
            this.listBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ögrenci Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(108, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "katılımcı listesi";
            // 
            // list
            // 
            this.list.AnimationHoverSpeed = 0.07F;
            this.list.AnimationSpeed = 0.03F;
            this.list.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.list.BorderColor = System.Drawing.Color.Black;
            this.list.DialogResult = System.Windows.Forms.DialogResult.None;
            this.list.FocusedColor = System.Drawing.Color.Empty;
            this.list.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.list.ForeColor = System.Drawing.Color.White;
            this.list.Image = ((System.Drawing.Image)(resources.GetObject("list.Image")));
            this.list.ImageSize = new System.Drawing.Size(20, 20);
            this.list.Location = new System.Drawing.Point(137, 472);
            this.list.Name = "list";
            this.list.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.list.OnHoverBorderColor = System.Drawing.Color.Black;
            this.list.OnHoverForeColor = System.Drawing.Color.White;
            this.list.OnHoverImage = null;
            this.list.OnPressedColor = System.Drawing.Color.Black;
            this.list.Size = new System.Drawing.Size(190, 41);
            this.list.TabIndex = 14;
            this.list.Text = "Katılımcıları Listele";
            this.list.Click += new System.EventHandler(this.list_Click);
            // 
            // git
            // 
            this.git.AnimationHoverSpeed = 0.07F;
            this.git.AnimationSpeed = 0.03F;
            this.git.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.git.BorderColor = System.Drawing.Color.Black;
            this.git.DialogResult = System.Windows.Forms.DialogResult.None;
            this.git.FocusedColor = System.Drawing.Color.Empty;
            this.git.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.git.ForeColor = System.Drawing.Color.White;
            this.git.Image = null;
            this.git.ImageSize = new System.Drawing.Size(20, 20);
            this.git.Location = new System.Drawing.Point(312, 116);
            this.git.Name = "git";
            this.git.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.git.OnHoverBorderColor = System.Drawing.Color.Black;
            this.git.OnHoverForeColor = System.Drawing.Color.White;
            this.git.OnHoverImage = null;
            this.git.OnPressedColor = System.Drawing.Color.Black;
            this.git.Size = new System.Drawing.Size(55, 30);
            this.git.TabIndex = 15;
            this.git.Text = ">";
            this.git.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.git.Click += new System.EventHandler(this.git_Click);
            // 
            // tamG
            // 
            this.tamG.AnimationHoverSpeed = 0.07F;
            this.tamG.AnimationSpeed = 0.03F;
            this.tamG.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tamG.BorderColor = System.Drawing.Color.Black;
            this.tamG.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tamG.FocusedColor = System.Drawing.Color.Empty;
            this.tamG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tamG.ForeColor = System.Drawing.Color.White;
            this.tamG.Image = null;
            this.tamG.ImageSize = new System.Drawing.Size(20, 20);
            this.tamG.Location = new System.Drawing.Point(312, 161);
            this.tamG.Name = "tamG";
            this.tamG.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.tamG.OnHoverBorderColor = System.Drawing.Color.Black;
            this.tamG.OnHoverForeColor = System.Drawing.Color.White;
            this.tamG.OnHoverImage = null;
            this.tamG.OnPressedColor = System.Drawing.Color.Black;
            this.tamG.Size = new System.Drawing.Size(55, 30);
            this.tamG.TabIndex = 16;
            this.tamG.Text = ">>";
            this.tamG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tamG.Click += new System.EventHandler(this.tamG_Click);
            // 
            // tamGel
            // 
            this.tamGel.AnimationHoverSpeed = 0.07F;
            this.tamGel.AnimationSpeed = 0.03F;
            this.tamGel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tamGel.BorderColor = System.Drawing.Color.Black;
            this.tamGel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.tamGel.FocusedColor = System.Drawing.Color.Empty;
            this.tamGel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tamGel.ForeColor = System.Drawing.Color.White;
            this.tamGel.Image = null;
            this.tamGel.ImageSize = new System.Drawing.Size(20, 20);
            this.tamGel.Location = new System.Drawing.Point(11, 161);
            this.tamGel.Name = "tamGel";
            this.tamGel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.tamGel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.tamGel.OnHoverForeColor = System.Drawing.Color.White;
            this.tamGel.OnHoverImage = null;
            this.tamGel.OnPressedColor = System.Drawing.Color.Black;
            this.tamGel.Size = new System.Drawing.Size(55, 30);
            this.tamGel.TabIndex = 17;
            this.tamGel.Text = "<<";
            this.tamGel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tamGel.Click += new System.EventHandler(this.tamGel_Click);
            // 
            // gel
            // 
            this.gel.AnimationHoverSpeed = 0.07F;
            this.gel.AnimationSpeed = 0.03F;
            this.gel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gel.BorderColor = System.Drawing.Color.Black;
            this.gel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gel.FocusedColor = System.Drawing.Color.Empty;
            this.gel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gel.ForeColor = System.Drawing.Color.White;
            this.gel.Image = null;
            this.gel.ImageSize = new System.Drawing.Size(20, 20);
            this.gel.Location = new System.Drawing.Point(11, 116);
            this.gel.Name = "gel";
            this.gel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(64)))), ((int)(((byte)(60)))));
            this.gel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gel.OnHoverForeColor = System.Drawing.Color.White;
            this.gel.OnHoverImage = null;
            this.gel.OnPressedColor = System.Drawing.Color.Black;
            this.gel.Size = new System.Drawing.Size(55, 30);
            this.gel.TabIndex = 18;
            this.gel.Text = "<";
            this.gel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gel.Click += new System.EventHandler(this.gel_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.list);
            this.gunaGradientPanel1.Controls.Add(this.gel);
            this.gunaGradientPanel1.Controls.Add(this.listBox2);
            this.gunaGradientPanel1.Controls.Add(this.tamGel);
            this.gunaGradientPanel1.Controls.Add(this.label2);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(235)))), ((int)(((byte)(18)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.MediumSpringGreen;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.DarkSlateGray;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(372, -2);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(370, 554);
            this.gunaGradientPanel1.TabIndex = 20;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.listBox1);
            this.gunaGradientPanel2.Controls.Add(this.label1);
            this.gunaGradientPanel2.Controls.Add(this.tamG);
            this.gunaGradientPanel2.Controls.Add(this.git);
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.MediumSpringGreen;
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.DarkSlateGray;
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(235)))), ((int)(((byte)(18)))));
            this.gunaGradientPanel2.Location = new System.Drawing.Point(-10, -2);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(387, 554);
            this.gunaGradientPanel2.TabIndex = 21;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 551);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Name = "Form1";
            this.Text = "Anasayfa";
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.gunaGradientPanel2.ResumeLayout(false);
            this.gunaGradientPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton list;
        private Guna.UI.WinForms.GunaButton git;
        private Guna.UI.WinForms.GunaButton tamG;
        private Guna.UI.WinForms.GunaButton tamGel;
        private Guna.UI.WinForms.GunaButton gel;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
    }
}

