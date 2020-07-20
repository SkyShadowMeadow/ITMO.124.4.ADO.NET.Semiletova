using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace CreatingDataTable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private DataSet dataSet;
        private BindingSource bindingSource1;
        private BindingSource bindingSource2;

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
        private void MakeDataTables() 
        {
            MakeParentTable(); 
            MakeChildTable();
            MakeDataRelation(); 
            BindToDataGrid(); 
        }

        private void MakeParentTable()
        {
            DataTable table = new DataTable("ParentTable");
            DataColumn column; DataRow row;

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "id"; 
            column.ReadOnly = true; 
            column.Unique = true;
            table.Columns.Add(column);

            column = new DataColumn(); 
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ParentItem";
            column.AutoIncrement = false; 
            column.Caption = "ParentItem"; 
            column.ReadOnly = false; 
            column.Unique = false;
            table.Columns.Add(column);

            table.Columns.Add("Total", typeof(Double)); 
            table.Columns.Add("SalesTax", typeof(Double), "Total * 0.13");

            DataColumn[] PrimaryKeyColumns = new DataColumn[1]; 
            PrimaryKeyColumns[0] = table.Columns["id"]; 
            table.PrimaryKey = PrimaryKeyColumns;

            dataSet = new DataSet(); 
            dataSet.Tables.Add(table);

            for (int i = 0; i <= 2; i++) 
            {
                row = table.NewRow(); 
                row["id"] = i; row["ParentItem"] = "ParentItem " + i; row["Total"] = 2 * i + 0.5; 
                table.Rows.Add(row); 
            }
        }

        private void MakeChildTable()
        {
            DataTable table = new DataTable("childTable");
            DataColumn column; DataRow row;
            column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32"); 
            column.ColumnName = "ChildID"; 
            column.AutoIncrement = true; 
            column.Caption = "ID"; 
            column.ReadOnly = true; 
            column.Unique = true;
            table.Columns.Add(column);
            
            column = new DataColumn(); 
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "ChildItem"; 
            column.AutoIncrement = false; 
            column.Caption = "ChildItem"; 
            column.ReadOnly = false; 
            column.Unique = false; 
            table.Columns.Add(column);
            
            column = new DataColumn(); 
            column.DataType = System.Type.GetType("System.Int32"); 
            column.ColumnName = "ParentID"; column.AutoIncrement = false; 
            column.Caption = "ParentID"; 
            column.ReadOnly = false; 
            column.Unique = false; 
            table.Columns.Add(column);
            
            dataSet.Tables.Add(table);
            for (int i = 0; i <= 4; i++) 
            { 
                row = table.NewRow(); 
                row["childID"] = i; 
                row["ChildItem"] = "Item " + i;
                row["ParentID"] = 0; 
                table.Rows.Add(row); 
            }
            for (int i = 0; i <= 4; i++) 
            { 
                row = table.NewRow(); 
                row["childID"] = i + 5; 
                row["ChildItem"] = "Item " + i; 
                row["ParentID"] = 1; 
                table.Rows.Add(row);
            }
            for (int i = 0; i <= 4; i++)
            {
                row = table.NewRow(); row["childID"] = i + 10;
                row["ChildItem"] = "Item " + i; row["ParentID"] = 2; 
                table.Rows.Add(row);
            }
        }
        private void MakeDataRelation()
        { // DataRelation requires two DataColumn 
          // (parent and child) and a name. 
            DataColumn parentColumn = dataSet.Tables["ParentTable"].Columns["id"]; 
            DataColumn childColumn = dataSet.Tables["ChildTable"].Columns["ParentID"];
            DataRelation relation = new DataRelation("parent2Child", parentColumn, childColumn); 
            dataSet.Tables["ChildTable"].ParentRelations.Add(relation);
        }

        private void BindToDataGrid()
        {
            bindingSource1 = new BindingSource(); 
            bindingSource2 = new BindingSource();
            bindingSource1.DataSource = dataSet.Tables["ParentTable"]; 
            bindingSource2.DataSource = dataSet.Tables["childTable"];
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Заполнить дочернюю таблицу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 38);
            this.button2.TabIndex = 2;
            this.button2.Text = "Заполнить основную таблицу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 288);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(542, 150);
            this.dataGridView2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private DataGridView dataGridView2;
    }
}

