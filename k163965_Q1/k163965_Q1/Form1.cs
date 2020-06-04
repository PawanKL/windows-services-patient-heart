using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.Configuration;
using PatientsClassLibrray;

namespace k163965_Q1
{
    public partial class Form1 : Form
    {
        public string path = ConfigurationManager.AppSettings["Path"];
        public string filePath;
        private Patient p;
        private bool isPatientInfo;
        public Form1()
        {
            InitializeComponent();
        }
        private void setFilePath(string date)
        {
            filePath = path + "PatientDetails_" + date + ".xml";
        }
        private void addData(Patient p)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            var rootNode = xDoc.GetElementsByTagName("Patients")[0];
            var nav = rootNode.CreateNavigator();
            var emptyNamepsaces = new XmlSerializerNamespaces(new[] {
            XmlQualifiedName.Empty});

            using (var writer = nav.AppendChild())
            {
                var serializer = new XmlSerializer(p.GetType());
                writer.WriteWhitespace("");
                serializer.Serialize(writer, p, emptyNamepsaces);
                writer.Close();
            }
            xDoc.Save(filePath);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bpmTimePicker.Format = DateTimePickerFormat.Time;
            bpmTimePicker.ShowUpDown = true;
            genderList.SelectedIndex = 0;
            Console.WriteLine("Form Loaded....!!!");
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            
            string username = userText.Text.ToString();
            string dob = dobPicker.Value.ToString("dd/MM/yyy");
            string gender = genderList.SelectedItem.ToString();
            string email = emailText.Text.ToString();
            p = new Patient()
            {
                name = username,
                DOB = dob,
                gender = gender,
                email = email
            };
            isPatientInfo = true;

        }

        private void genderList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bpmButton_Click(object sender, EventArgs e)
        {
            if (isPatientInfo)
            {
                if((bpmDatePicker.Value > DateTime.Now) || (bpmTimePicker.Value > DateTime.Now))
                {
                    string message = "Invalid Date, Cannot Enter for future date..";
                    string title = "Invalid Date";
                    MessageBox.Show(message, title);
                }
                else
                {
                    string bpm_time = bpmTimePicker.Value.ToString("HH:mm:ss");
                    string bpm_date = bpmDatePicker.Value.ToString("yyyy_MM_dd");
                    int bpm = Convert.ToInt32(bpmValue.Value);
                    int confidence = Convert.ToInt32(confidenceValue.Value);
                    p.bpm = bpm;
                    p.time = bpm_time;
                    p.confidence = confidence;
                    setFilePath(bpm_date);
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("yes exists");
                        addData(p);
                    }
                    else
                    {
                        Patient[] patList = { p };
                        Patients pat = new Patients() { Patient = patList };
                        //Console.WriteLine("username: {0}, DOB: {1}, Gender: {2}, Email: {3}, BPM: {4}, Confidence: {5}," +
                        //    " Time: {6}", p1.name, p1.DOB, p1.gender, p1.email, p1.bpm, p1.confidence, p1.time);

                        XmlSerializer ser = new XmlSerializer(typeof(Patients));
                        XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                        ns.Add("", "");
                        TextWriter writer = new StreamWriter(filePath);
                        ser.Serialize(writer, pat, ns);
                        writer.Close();
                    }
                }
               
            }
            else
            {
                string message = "Enter Patient's Personal Information First";
                string title = "Missing Patient Information";
                MessageBox.Show(message, title);
            }
            
        }

        
    }
}
