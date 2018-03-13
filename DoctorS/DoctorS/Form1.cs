using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoctorS
{
    public partial class Form1 : Form
    {
        List<Doctor> doctos = new List<Doctor>();
        public Form1()
        {
            InitializeComponent();
            string text = lblName.Text;
            string textSurname = lblSurname.Text;

        }
          //doctor class
        public class Doctor
        {
            public string name { get; set; }
            public string surName { get; set; }
            public DateTime startTime { get; set; }
            public DateTime endTime { get; set; }
            public List<int> weekDays =new List<int>();
        }
      //when clicked at "ADD"
        private void button1_Click(object sender, EventArgs e)
        {
            Doctor added = new Doctor();
            added.name = textBox1.Text;
            added.surName = textBox3.Text;
            added.startTime = dateTimePicker1.Value;
            added.endTime = dateTimePicker2.Value;
            //for adding cheked elements to wwekdays list
            foreach (var item in checkedListBox1.CheckedItems)
            {
                added.weekDays.Add(int.Parse(item.ToString()));
            }
            doctos.Add(added);
            textBox1.Text = "";
            textBox3.Text = "";
           

        }
        //search doctor when clicked at search button
        private void button1_Click_1(object sender, EventArgs e)
        {
           
            foreach (Doctor item in doctos)
            {          
                foreach(var weekdays in item.weekDays)
                {
                    var search = dateTimePicker3.Value;
                    var startTime = item.startTime;
                    var endTime = item.endTime;

                    if (weekdays == Convert.ToInt32(cmbSearch.SelectedItem)&& (search>=startTime)&&( search<endTime))
                    {
                        MessageBox.Show("Hekim :" + item.name + item.surName);
                    }
                    
                }
                
            }
        }
    }
}

