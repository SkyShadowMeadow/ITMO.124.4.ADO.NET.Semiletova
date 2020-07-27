using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using CodeFirst;
using static CodeFirst.Model;
using System.IO;

namespace PetsManager
{
    public partial class PetsViewer : Form
    {
        SampleContext context = new SampleContext();
        byte[] Ph;

        private void Output() 
        { 
            if (this.PersonradioButton.Checked == true) 
                GridView.DataSource = context.Persons.ToList(); 
            else if (this.CourseradioButton.Checked == true) 
                GridView.DataSource = context.Pets.ToList();
        }
        public PetsViewer()
        {
            InitializeComponent();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<SampleContext>());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
     

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try 
            {
                Person person = new Person
                {
                    FirstName = this.textBoxname.Text,
                    Email = this.textBoxmail.Text,
                    LastName = this.textBoxlastname.Text,
                    Pets = petsListBox.SelectedItems.OfType<Pet>().ToList()
                }; 
                context.Persons.Add(person); 
                context.SaveChanges();
                Output();

                textBoxname.Text = String.Empty;
                textBoxlastname.Text = String.Empty;
                textBoxmail.Text = String.Empty; 
                
            } 
            catch (Exception ex) 
            { 
                MessageBox.Show("Ошибка: " + ex.ToString()); 
            }        
        }

        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            try
            {
                Pet pet = new Pet
                {
                    PetName = this.textBoxnamePet.Text,
                    Type = this.textBoxtypePet.Text,
                    Age = Int32.Parse(this.textBoxagePet.Text),
                    Photo = Ph,
                    
                };
                context.Pets.Add(pet);
                context.SaveChanges();
                Output();
                reloadPets();

                textBoxname.Text = String.Empty;
                textBoxlastname.Text = String.Empty;
                textBoxmail.Text = String.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.ToString());
            }
        }
    

        private void buttonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog(); if (diag.ShowDialog() == DialogResult.OK)
            {
                Image bm = new Bitmap(diag.OpenFile());
                ImageConverter converter = new ImageConverter(); Ph = (byte[])converter.ConvertTo(bm, typeof(byte[]));
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            Output();
        }

        private void GridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if (GridView.CurrentRow == null) return; 
            var person = GridView.CurrentRow.DataBoundItem as Person; 
            if (person != null)
            {
                labelid.Text = Convert.ToString(person.PersonId);
                textBoxCurrent.Text = person.ToString();
                textBoxname.Text = person.FirstName;
                textBoxlastname.Text = person.LastName; 
                textBoxmail.Text = person.Email;
            } else
            {
                var pet = GridView.CurrentRow.DataBoundItem as Pet;
                if (pet != null)
                {
                    labelid.Text = Convert.ToString(pet.PetId);
                    textBoxCurrent.Text = pet.ToString();
                    textBoxnamePet.Text = Convert.ToString(pet.PetName);
                    textBoxagePet.Text = Convert.ToString(pet.Age);
                    textBoxtypePet.Text = Convert.ToString(pet.Type);
                    pictureBox1.Image = ByteToImage(pet.Photo);
                }
            }

        }

        private void buttonEditPerson_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text);
            var person = context.Persons.Find(id); 
            if (person == null) return;
            person.FirstName = this.textBoxname.Text; 
            person.LastName = this.textBoxlastname.Text; 
            person.Email = this.textBoxmail.Text; 
            context.Entry(person).State = EntityState.Modified;
            context.SaveChanges(); 
            Output();
        }

        private void buttonDelPerson_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text);
            var person = context.Persons.Find(id);
            context.Entry(person).State = EntityState.Deleted; 
            context.SaveChanges(); 
            Output();
        }

        private void buttonEditPet_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text);
            var pet = context.Pets.Find(id);
            if (pet == null) return;
            pet.PetName = this.textBoxnamePet.Text;
            pet.Type = this.textBoxtypePet.Text;
            pet.Age = Int32.Parse(this.textBoxagePet.Text);
            pet.Photo = this.Ph;
            context.Entry(pet).State = EntityState.Modified;
            context.SaveChanges();
            Output();
            reloadPets();
        }

        private void buttonDelPet_Click(object sender, EventArgs e)
        {
            if (labelid.Text == String.Empty) return;
            var id = Convert.ToInt32(labelid.Text);
            var pet = context.Pets.Find(id);
            context.Entry(pet).State = EntityState.Deleted;
            context.SaveChanges();
            Output();
            reloadPets();
        }

        private void PetsViewer_Load(object sender, EventArgs e)
        {
            reloadPets();
        }

        private void reloadPets()
        {
            petsListBox.DataSource = context.Pets.ToList();                 
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            if (blob != null)
            {
                MemoryStream mStream = new MemoryStream();
                byte[] pData = blob;
                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                Bitmap bm = new Bitmap(mStream, false);
                mStream.Dispose();
                return bm;
            }
            else
            {
                return null;
            }
        }
    }
 }

