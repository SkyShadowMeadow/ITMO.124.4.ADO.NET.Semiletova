using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SchoolDataSet.PersonRow GetSelectedRow()
        {
            int SelectedPersonID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["PersonID"].Value.ToString());
            SchoolDataSet.PersonRow SelectedRow =
            schoolDataSet1.Person.FindByPersonID(SelectedPersonID);
            return SelectedRow;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = schoolDataSet1.Person;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void UpdateRowVersionDisplay()
        {
            try
            {
                CurrentDRVTextBox.Text = GetSelectedRow()[dataGridView1.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                CurrentDRVTextBox.Text = ex.Message;
            }
            try
            {
                OriginalDRVTextBox.Text = GetSelectedRow()[dataGridView1.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                OriginalDRVTextBox.Text = ex.Message;
            }

            RowStateTextBox.Text = GetSelectedRow().RowState.ToString();
        }
        private void FillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(schoolDataSet1.Person);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            SchoolDataSet.PersonRow NewRow = (SchoolDataSet.PersonRow)schoolDataSet1.Person.NewRow();
            NewRow.LastName = textBox1.Text.ToString();
            NewRow.FirstName = textBox2.Text.ToString();
            //NewRow.PersonID = Convert.ToInt32(textBox3.Text);
            NewRow.HireDate = Convert.ToDateTime(textBox4.Text);
            NewRow.EnrollmentDate = Convert.ToDateTime(textBox5.Text);
            try
            {
                schoolDataSet1.Person.Rows.Add(NewRow);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }

        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }

        private void UpdateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[dataGridView1.CurrentCell.OwningColumn.Name] = CellValueTextBox.Text;
            UpdateRowVersionDisplay();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CellValueTextBox.Text = dataGridView1.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();
        }

        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();
        }

        private void RejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();
        }
    }
}
