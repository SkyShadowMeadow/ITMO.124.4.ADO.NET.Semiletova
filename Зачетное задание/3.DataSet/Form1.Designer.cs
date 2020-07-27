namespace DataSet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FillTableButton = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.schoolDataSet1 = new DataSet.SchoolDataSet();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.UpdateValueButton = new System.Windows.Forms.Button();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.RejectChangesButton = new System.Windows.Forms.Button();
            this.CellValueTextBox = new System.Windows.Forms.TextBox();
            this.CurrentDRVTextBox = new System.Windows.Forms.TextBox();
            this.OriginalDRVTextBox = new System.Windows.Forms.TextBox();
            this.RowStateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(564, 247);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FillTableButton
            // 
            this.FillTableButton.Location = new System.Drawing.Point(3, 265);
            this.FillTableButton.Name = "FillTableButton";
            this.FillTableButton.Size = new System.Drawing.Size(109, 27);
            this.FillTableButton.TabIndex = 1;
            this.FillTableButton.Text = "Fill Table";
            this.FillTableButton.UseVisualStyleBackColor = true;
            this.FillTableButton.Click += new System.EventHandler(this.FillTableButton_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM Person";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 0, "LastName"),
            new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 0, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 0, "HireDate"),
            new System.Data.SqlClient.SqlParameter("@EnrollmentDate", System.Data.SqlDbType.DateTime, 0, "EnrollmentDate")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@LastName", System.Data.SqlDbType.NVarChar, 0, "LastName"),
            new System.Data.SqlClient.SqlParameter("@FirstName", System.Data.SqlDbType.NVarChar, 0, "FirstName"),
            new System.Data.SqlClient.SqlParameter("@HireDate", System.Data.SqlDbType.DateTime, 0, "HireDate"),
            new System.Data.SqlClient.SqlParameter("@EnrollmentDate", System.Data.SqlDbType.DateTime, 0, "EnrollmentDate"),
            new System.Data.SqlClient.SqlParameter("@Original_PersonID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PersonID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HireDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EnrollmentDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EnrollmentDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EnrollmentDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EnrollmentDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@PersonID", System.Data.SqlDbType.Int, 4, "PersonID")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_PersonID", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "PersonID", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_LastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "LastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_FirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "FirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_HireDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_HireDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "HireDate", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_EnrollmentDate", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "EnrollmentDate", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_EnrollmentDate", System.Data.SqlDbType.DateTime, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "EnrollmentDate", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Person", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("PersonID", "PersonID"),
                        new System.Data.Common.DataColumnMapping("LastName", "LastName"),
                        new System.Data.Common.DataColumnMapping("FirstName", "FirstName"),
                        new System.Data.Common.DataColumnMapping("HireDate", "HireDate"),
                        new System.Data.Common.DataColumnMapping("EnrollmentDate", "EnrollmentDate")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=School;Integrated Security=Tru" +
    "e";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // schoolDataSet1
            // 
            this.schoolDataSet1.DataSetName = "SchoolDataSet";
            this.schoolDataSet1.EnforceConstraints = false;
            this.schoolDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(573, 145);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(141, 25);
            this.AddRowButton.TabIndex = 2;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(573, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(573, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(573, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(573, 90);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(573, 116);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 20);
            this.textBox5.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(720, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(720, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Person ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(720, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Hire Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(720, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Enrollment Date";
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(116, 265);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(109, 27);
            this.DeleteRowButton.TabIndex = 13;
            this.DeleteRowButton.Text = "Delete Row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // UpdateValueButton
            // 
            this.UpdateValueButton.Location = new System.Drawing.Point(230, 265);
            this.UpdateValueButton.Name = "UpdateValueButton";
            this.UpdateValueButton.Size = new System.Drawing.Size(109, 27);
            this.UpdateValueButton.TabIndex = 14;
            this.UpdateValueButton.Text = "Update Value ";
            this.UpdateValueButton.UseVisualStyleBackColor = true;
            this.UpdateValueButton.Click += new System.EventHandler(this.UpdateValueButton_Click);
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Location = new System.Drawing.Point(345, 265);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(109, 27);
            this.AcceptChangesButton.TabIndex = 15;
            this.AcceptChangesButton.Text = "Accept Changes";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            this.AcceptChangesButton.Click += new System.EventHandler(this.AcceptChangesButton_Click);
            // 
            // RejectChangesButton
            // 
            this.RejectChangesButton.Location = new System.Drawing.Point(458, 265);
            this.RejectChangesButton.Name = "RejectChangesButton";
            this.RejectChangesButton.Size = new System.Drawing.Size(109, 27);
            this.RejectChangesButton.TabIndex = 16;
            this.RejectChangesButton.Text = "Reject Changes";
            this.RejectChangesButton.UseVisualStyleBackColor = true;
            this.RejectChangesButton.Click += new System.EventHandler(this.RejectChangesButton_Click);
            // 
            // CellValueTextBox
            // 
            this.CellValueTextBox.Location = new System.Drawing.Point(573, 193);
            this.CellValueTextBox.Name = "CellValueTextBox";
            this.CellValueTextBox.Size = new System.Drawing.Size(141, 20);
            this.CellValueTextBox.TabIndex = 17;
            // 
            // CurrentDRVTextBox
            // 
            this.CurrentDRVTextBox.Location = new System.Drawing.Point(573, 245);
            this.CurrentDRVTextBox.Name = "CurrentDRVTextBox";
            this.CurrentDRVTextBox.Size = new System.Drawing.Size(141, 20);
            this.CurrentDRVTextBox.TabIndex = 18;
            // 
            // OriginalDRVTextBox
            // 
            this.OriginalDRVTextBox.Location = new System.Drawing.Point(573, 219);
            this.OriginalDRVTextBox.Name = "OriginalDRVTextBox";
            this.OriginalDRVTextBox.Size = new System.Drawing.Size(141, 20);
            this.OriginalDRVTextBox.TabIndex = 19;
            // 
            // RowStateTextBox
            // 
            this.RowStateTextBox.Location = new System.Drawing.Point(573, 271);
            this.RowStateTextBox.Name = "RowStateTextBox";
            this.RowStateTextBox.Size = new System.Drawing.Size(141, 20);
            this.RowStateTextBox.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 408);
            this.Controls.Add(this.RowStateTextBox);
            this.Controls.Add(this.OriginalDRVTextBox);
            this.Controls.Add(this.CurrentDRVTextBox);
            this.Controls.Add(this.CellValueTextBox);
            this.Controls.Add(this.RejectChangesButton);
            this.Controls.Add(this.AcceptChangesButton);
            this.Controls.Add(this.UpdateValueButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.FillTableButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Tutors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schoolDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button FillTableButton;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private SchoolDataSet schoolDataSet1;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button UpdateValueButton;
        private System.Windows.Forms.Button AcceptChangesButton;
        private System.Windows.Forms.Button RejectChangesButton;
        private System.Windows.Forms.TextBox CellValueTextBox;
        private System.Windows.Forms.TextBox CurrentDRVTextBox;
        private System.Windows.Forms.TextBox OriginalDRVTextBox;
        private System.Windows.Forms.TextBox RowStateTextBox;
    }
}

