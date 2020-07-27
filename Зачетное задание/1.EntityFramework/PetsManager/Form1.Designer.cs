namespace PetsManager
{
    partial class PetsViewer
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
            this.petsListBox = new System.Windows.Forms.ListBox();
            this.textBoxname = new System.Windows.Forms.TextBox();
            this.textBoxlastname = new System.Windows.Forms.TextBox();
            this.textBoxmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFile = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CourseradioButton = new System.Windows.Forms.RadioButton();
            this.PersonradioButton = new System.Windows.Forms.RadioButton();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.labelid = new System.Windows.Forms.Label();
            this.GridView = new System.Windows.Forms.DataGridView();
            this.Хозяин = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxtypePet = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxagePet = new System.Windows.Forms.TextBox();
            this.textBoxnamePet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelPet = new System.Windows.Forms.Button();
            this.buttonAddPet = new System.Windows.Forms.Button();
            this.buttonEditPet = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.Хозяин.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // petsListBox
            // 
            this.petsListBox.FormattingEnabled = true;
            this.petsListBox.Location = new System.Drawing.Point(6, 19);
            this.petsListBox.Name = "petsListBox";
            this.petsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.petsListBox.Size = new System.Drawing.Size(188, 134);
            this.petsListBox.TabIndex = 1;
            // 
            // textBoxname
            // 
            this.textBoxname.Location = new System.Drawing.Point(57, 18);
            this.textBoxname.Name = "textBoxname";
            this.textBoxname.Size = new System.Drawing.Size(143, 20);
            this.textBoxname.TabIndex = 2;
            // 
            // textBoxlastname
            // 
            this.textBoxlastname.Location = new System.Drawing.Point(57, 44);
            this.textBoxlastname.Name = "textBoxlastname";
            this.textBoxlastname.Size = new System.Drawing.Size(143, 20);
            this.textBoxlastname.TabIndex = 3;
            // 
            // textBoxmail
            // 
            this.textBoxmail.Location = new System.Drawing.Point(57, 70);
            this.textBoxmail.Name = "textBoxmail";
            this.textBoxmail.Size = new System.Drawing.Size(143, 20);
            this.textBoxmail.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "E-mail";
            // 
            // buttonFile
            // 
            this.buttonFile.Location = new System.Drawing.Point(6, 86);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(98, 23);
            this.buttonFile.TabIndex = 10;
            this.buttonFile.Text = "Загрузить фото";
            this.buttonFile.UseVisualStyleBackColor = true;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(4, 98);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 50);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Добавить хозяина";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(6, 42);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(149, 50);
            this.buttonOut.TabIndex = 12;
            this.buttonOut.Text = "Показать данные";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(108, 98);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 22);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEditPerson_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(108, 126);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(92, 22);
            this.buttonDel.TabIndex = 14;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDelPerson_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CourseradioButton);
            this.groupBox1.Controls.Add(this.PersonradioButton);
            this.groupBox1.Controls.Add(this.buttonOut);
            this.groupBox1.Controls.Add(this.textBoxCurrent);
            this.groupBox1.Controls.Add(this.labelid);
            this.groupBox1.Location = new System.Drawing.Point(834, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 160);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор данных";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CourseradioButton
            // 
            this.CourseradioButton.AutoSize = true;
            this.CourseradioButton.Location = new System.Drawing.Point(78, 19);
            this.CourseradioButton.Name = "CourseradioButton";
            this.CourseradioButton.Size = new System.Drawing.Size(79, 17);
            this.CourseradioButton.TabIndex = 1;
            this.CourseradioButton.TabStop = true;
            this.CourseradioButton.Text = "Животные";
            this.CourseradioButton.UseVisualStyleBackColor = true;
            // 
            // PersonradioButton
            // 
            this.PersonradioButton.AutoSize = true;
            this.PersonradioButton.Location = new System.Drawing.Point(6, 19);
            this.PersonradioButton.Name = "PersonradioButton";
            this.PersonradioButton.Size = new System.Drawing.Size(68, 17);
            this.PersonradioButton.TabIndex = 0;
            this.PersonradioButton.TabStop = true;
            this.PersonradioButton.Text = "Хозяева";
            this.PersonradioButton.UseVisualStyleBackColor = true;
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Location = new System.Drawing.Point(26, 134);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(131, 20);
            this.textBoxCurrent.TabIndex = 16;
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.Location = new System.Drawing.Point(2, 137);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(18, 13);
            this.labelid.TabIndex = 17;
            this.labelid.Text = "ID";
            // 
            // GridView
            // 
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.Location = new System.Drawing.Point(0, 181);
            this.GridView.Name = "GridView";
            this.GridView.Size = new System.Drawing.Size(1009, 269);
            this.GridView.TabIndex = 18;
            this.GridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_CellClick);
            // 
            // Хозяин
            // 
            this.Хозяин.Controls.Add(this.textBoxname);
            this.Хозяин.Controls.Add(this.textBoxlastname);
            this.Хозяин.Controls.Add(this.textBoxmail);
            this.Хозяин.Controls.Add(this.label1);
            this.Хозяин.Controls.Add(this.label2);
            this.Хозяин.Controls.Add(this.label3);
            this.Хозяин.Controls.Add(this.buttonDel);
            this.Хозяин.Controls.Add(this.buttonAdd);
            this.Хозяин.Controls.Add(this.buttonEdit);
            this.Хозяин.Location = new System.Drawing.Point(12, 12);
            this.Хозяин.Name = "Хозяин";
            this.Хозяин.Size = new System.Drawing.Size(206, 163);
            this.Хозяин.TabIndex = 20;
            this.Хозяин.TabStop = false;
            this.Хозяин.Text = "Хозяин";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.petsListBox);
            this.groupBox2.Location = new System.Drawing.Point(225, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 163);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список всех животных";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxtypePet);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxagePet);
            this.groupBox3.Controls.Add(this.textBoxnamePet);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonDelPet);
            this.groupBox3.Controls.Add(this.buttonAddPet);
            this.groupBox3.Controls.Add(this.buttonEditPet);
            this.groupBox3.Controls.Add(this.buttonFile);
            this.groupBox3.Location = new System.Drawing.Point(432, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 160);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Животное";
            // 
            // textBoxtypePet
            // 
            this.textBoxtypePet.Location = new System.Drawing.Point(61, 41);
            this.textBoxtypePet.Name = "textBoxtypePet";
            this.textBoxtypePet.Size = new System.Drawing.Size(143, 20);
            this.textBoxtypePet.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Вид";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Возраст";
            // 
            // textBoxagePet
            // 
            this.textBoxagePet.Location = new System.Drawing.Point(61, 63);
            this.textBoxagePet.Name = "textBoxagePet";
            this.textBoxagePet.Size = new System.Drawing.Size(143, 20);
            this.textBoxagePet.TabIndex = 17;
            // 
            // textBoxnamePet
            // 
            this.textBoxnamePet.Location = new System.Drawing.Point(61, 16);
            this.textBoxnamePet.Name = "textBoxnamePet";
            this.textBoxnamePet.Size = new System.Drawing.Size(143, 20);
            this.textBoxnamePet.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Имя";
            // 
            // buttonDelPet
            // 
            this.buttonDelPet.Location = new System.Drawing.Point(112, 132);
            this.buttonDelPet.Name = "buttonDelPet";
            this.buttonDelPet.Size = new System.Drawing.Size(92, 22);
            this.buttonDelPet.TabIndex = 16;
            this.buttonDelPet.Text = "Удалить";
            this.buttonDelPet.UseVisualStyleBackColor = true;
            this.buttonDelPet.Click += new System.EventHandler(this.buttonDelPet_Click);
            // 
            // buttonAddPet
            // 
            this.buttonAddPet.Location = new System.Drawing.Point(6, 111);
            this.buttonAddPet.Name = "buttonAddPet";
            this.buttonAddPet.Size = new System.Drawing.Size(98, 43);
            this.buttonAddPet.TabIndex = 15;
            this.buttonAddPet.Text = "Добавить животное";
            this.buttonAddPet.UseVisualStyleBackColor = true;
            this.buttonAddPet.Click += new System.EventHandler(this.buttonAddPet_Click);
            // 
            // buttonEditPet
            // 
            this.buttonEditPet.Location = new System.Drawing.Point(112, 104);
            this.buttonEditPet.Name = "buttonEditPet";
            this.buttonEditPet.Size = new System.Drawing.Size(92, 23);
            this.buttonEditPet.TabIndex = 15;
            this.buttonEditPet.Text = "Редактировать";
            this.buttonEditPet.UseVisualStyleBackColor = true;
            this.buttonEditPet.Click += new System.EventHandler(this.buttonEditPet_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(648, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // PetsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Хозяин);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.groupBox1);
            this.Name = "PetsViewer";
            this.Text = "Pets Viewer";
            this.Load += new System.EventHandler(this.PetsViewer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.Хозяин.ResumeLayout(false);
            this.Хозяин.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox petsListBox;
        private System.Windows.Forms.TextBox textBoxname;
        private System.Windows.Forms.TextBox textBoxlastname;
        private System.Windows.Forms.TextBox textBoxmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton CourseradioButton;
        private System.Windows.Forms.RadioButton PersonradioButton;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.Label labelid;
        private System.Windows.Forms.DataGridView GridView;
        private System.Windows.Forms.GroupBox Хозяин;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDelPet;
        private System.Windows.Forms.Button buttonAddPet;
        private System.Windows.Forms.Button buttonEditPet;
        private System.Windows.Forms.TextBox textBoxtypePet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxagePet;
        private System.Windows.Forms.TextBox textBoxnamePet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

