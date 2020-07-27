namespace Reader
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.подключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отключениеОтБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ассинхронноеПодключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ассионхронноеПодключениеКБДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПодключенийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.courseName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tutorNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКБДToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // подключениеКБДToolStripMenuItem
            // 
            this.подключениеКБДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отключениеОтБДToolStripMenuItem,
            this.ассинхронноеПодключениеКБДToolStripMenuItem,
            this.ассионхронноеПодключениеКБДToolStripMenuItem,
            this.списокПодключенийToolStripMenuItem});
            this.подключениеКБДToolStripMenuItem.Name = "подключениеКБДToolStripMenuItem";
            this.подключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.подключениеКБДToolStripMenuItem.Text = "Работа с БД";
            this.подключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.подключениеКБДToolStripMenuItem_Click);
            // 
            // отключениеОтБДToolStripMenuItem
            // 
            this.отключениеОтБДToolStripMenuItem.Name = "отключениеОтБДToolStripMenuItem";
            this.отключениеОтБДToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.отключениеОтБДToolStripMenuItem.Text = "Подключение к БД";
            this.отключениеОтБДToolStripMenuItem.Click += new System.EventHandler(this.отключениеОтБДToolStripMenuItem_Click);
            // 
            // ассинхронноеПодключениеКБДToolStripMenuItem
            // 
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Name = "ассинхронноеПодключениеКБДToolStripMenuItem";
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Text = "Отключение от БД";
            this.ассинхронноеПодключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.ассинхронноеПодключениеКБДToolStripMenuItem_Click);
            // 
            // ассионхронноеПодключениеКБДToolStripMenuItem
            // 
            this.ассионхронноеПодключениеКБДToolStripMenuItem.Name = "ассионхронноеПодключениеКБДToolStripMenuItem";
            this.ассионхронноеПодключениеКБДToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.ассионхронноеПодключениеКБДToolStripMenuItem.Text = "Ассионхронное подключение к БД";
            this.ассионхронноеПодключениеКБДToolStripMenuItem.Click += new System.EventHandler(this.ассионхронноеПодключениеКБДToolStripMenuItem_Click);
            // 
            // списокПодключенийToolStripMenuItem
            // 
            this.списокПодключенийToolStripMenuItem.Name = "списокПодключенийToolStripMenuItem";
            this.списокПодключенийToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.списокПодключенийToolStripMenuItem.Text = "Список подключений";
            this.списокПодключенийToolStripMenuItem.Click += new System.EventHandler(this.списокПодключенийToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Посчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Количество преподавателей";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 320);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 64;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Дата зачисления";
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Идентификатор";
            this.columnHeader4.Width = 97;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Список преподавателей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(145, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Найти";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // courseName
            // 
            this.courseName.Location = new System.Drawing.Point(102, 22);
            this.courseName.Name = "courseName";
            this.courseName.Size = new System.Drawing.Size(118, 20);
            this.courseName.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tutorNameLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.courseName);
            this.groupBox1.Location = new System.Drawing.Point(438, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск преподавателя по названию курса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Название курса";
            // 
            // tutorNameLabel
            // 
            this.tutorNameLabel.AutoSize = true;
            this.tutorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tutorNameLabel.Location = new System.Drawing.Point(7, 48);
            this.tutorNameLabel.Name = "tutorNameLabel";
            this.tutorNameLabel.Size = new System.Drawing.Size(134, 13);
            this.tutorNameLabel.TabIndex = 8;
            this.tutorNameLabel.Text = "Имя преподавателя: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 412);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Данные преподавателей";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem подключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отключениеОтБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ассинхронноеПодключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ассионхронноеПодключениеКБДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПодключенийToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox courseName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tutorNameLabel;
    }
}

