namespace Survey_2._0
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.exitbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.savebtn = new System.Windows.Forms.Button();
            this.loadbtn = new System.Windows.Forms.Button();
            this.survey = new System.Windows.Forms.GroupBox();
            this.ismail = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.changebtn = new System.Windows.Forms.Button();
            this.birthdate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.phonearea = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.surnamearea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.namearea = new System.Windows.Forms.TextBox();
            this.userlist = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.survey.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.SteelBlue;
            this.header.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.header.Location = new System.Drawing.Point(-5, -3);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(810, 24);
            this.header.TabIndex = 2;
            this.header.Click += new System.EventHandler(this.header_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.exitbtn.Image = global::Survey_2._0.Properties.Resources.icons8_xbox_x_80;
            this.exitbtn.ImageActive = null;
            this.exitbtn.Location = new System.Drawing.Point(769, 0);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(31, 17);
            this.exitbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exitbtn.TabIndex = 3;
            this.exitbtn.TabStop = false;
            this.exitbtn.Zoom = 10;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.savebtn);
            this.bunifuGradientPanel1.Controls.Add(this.loadbtn);
            this.bunifuGradientPanel1.Controls.Add(this.survey);
            this.bunifuGradientPanel1.Controls.Add(this.userlist);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.SteelBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-2, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(807, 439);
            this.bunifuGradientPanel1.TabIndex = 3;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.ForeColor = System.Drawing.Color.SkyBlue;
            this.savebtn.Location = new System.Drawing.Point(673, 400);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(118, 26);
            this.savebtn.TabIndex = 3;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click_1);
            // 
            // loadbtn
            // 
            this.loadbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.loadbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadbtn.ForeColor = System.Drawing.Color.SkyBlue;
            this.loadbtn.Location = new System.Drawing.Point(541, 400);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(118, 26);
            this.loadbtn.TabIndex = 2;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = false;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click_1);
            // 
            // survey
            // 
            this.survey.BackColor = System.Drawing.Color.SkyBlue;
            this.survey.Controls.Add(this.ismail);
            this.survey.Controls.Add(this.addbtn);
            this.survey.Controls.Add(this.changebtn);
            this.survey.Controls.Add(this.birthdate);
            this.survey.Controls.Add(this.label5);
            this.survey.Controls.Add(this.phonearea);
            this.survey.Controls.Add(this.label4);
            this.survey.Controls.Add(this.emailarea);
            this.survey.Controls.Add(this.label3);
            this.survey.Controls.Add(this.label2);
            this.survey.Controls.Add(this.surnamearea);
            this.survey.Controls.Add(this.label1);
            this.survey.Controls.Add(this.namearea);
            this.survey.Location = new System.Drawing.Point(14, 15);
            this.survey.Name = "survey";
            this.survey.Size = new System.Drawing.Size(521, 411);
            this.survey.TabIndex = 0;
            this.survey.TabStop = false;
            this.survey.Text = "Survey";
            // 
            // ismail
            // 
            this.ismail.AutoSize = true;
            this.ismail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ismail.Location = new System.Drawing.Point(149, 125);
            this.ismail.Name = "ismail";
            this.ismail.Size = new System.Drawing.Size(74, 13);
            this.ismail.TabIndex = 11;
            this.ismail.Text = "email is invalid";
            this.ismail.Visible = false;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbtn.ForeColor = System.Drawing.Color.SkyBlue;
            this.addbtn.Location = new System.Drawing.Point(376, 344);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(110, 26);
            this.addbtn.TabIndex = 10;
            this.addbtn.Text = "Add";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // changebtn
            // 
            this.changebtn.BackColor = System.Drawing.Color.SteelBlue;
            this.changebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changebtn.ForeColor = System.Drawing.Color.SkyBlue;
            this.changebtn.Location = new System.Drawing.Point(245, 344);
            this.changebtn.Name = "changebtn";
            this.changebtn.Size = new System.Drawing.Size(110, 26);
            this.changebtn.TabIndex = 4;
            this.changebtn.Text = "Change";
            this.changebtn.UseVisualStyleBackColor = false;
            this.changebtn.Click += new System.EventHandler(this.changebtn_Click);
            // 
            // birthdate
            // 
            this.birthdate.BackColor = System.Drawing.Color.SteelBlue;
            this.birthdate.BorderRadius = 0;
            this.birthdate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.birthdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.birthdate.FormatCustom = null;
            this.birthdate.Location = new System.Drawing.Point(151, 231);
            this.birthdate.Name = "birthdate";
            this.birthdate.Size = new System.Drawing.Size(256, 24);
            this.birthdate.TabIndex = 9;
            this.birthdate.Value = new System.DateTime(1800, 2, 12, 10, 26, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(44, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Birthdate";
            // 
            // phonearea
            // 
            this.phonearea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phonearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phonearea.Location = new System.Drawing.Point(152, 188);
            this.phonearea.Mask = "(999) 000-0000";
            this.phonearea.Name = "phonearea";
            this.phonearea.Size = new System.Drawing.Size(254, 24);
            this.phonearea.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(65, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Phone";
            // 
            // emailarea
            // 
            this.emailarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailarea.Location = new System.Drawing.Point(152, 141);
            this.emailarea.Name = "emailarea";
            this.emailarea.Size = new System.Drawing.Size(255, 24);
            this.emailarea.TabIndex = 5;
            this.emailarea.TextChanged += new System.EventHandler(this.emailarea_TextChanged);
            this.emailarea.MouseLeave += new System.EventHandler(this.emailarea_MouseLeave);
            this.emailarea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.emailarea_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(74, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(42, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // surnamearea
            // 
            this.surnamearea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnamearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnamearea.Location = new System.Drawing.Point(151, 89);
            this.surnamearea.Name = "surnamearea";
            this.surnamearea.Size = new System.Drawing.Size(255, 24);
            this.surnamearea.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(71, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // namearea
            // 
            this.namearea.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namearea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namearea.Location = new System.Drawing.Point(152, 41);
            this.namearea.Name = "namearea";
            this.namearea.Size = new System.Drawing.Size(254, 24);
            this.namearea.TabIndex = 0;
            // 
            // userlist
            // 
            this.userlist.BackColor = System.Drawing.Color.SkyBlue;
            this.userlist.FormattingEnabled = true;
            this.userlist.Location = new System.Drawing.Point(541, 15);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(249, 381);
            this.userlist.TabIndex = 1;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.userlist_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.header);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Survey 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.exitbtn)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.survey.ResumeLayout(false);
            this.survey.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox survey;
        private System.Windows.Forms.ListBox userlist;
        private System.Windows.Forms.Label header;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton exitbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.MaskedTextBox phonearea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox surnamearea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namearea;
        private Bunifu.Framework.UI.BunifuDatepicker birthdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button changebtn;
        private System.Windows.Forms.Label ismail;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

