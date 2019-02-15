using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

namespace auto_comment
{
    public partial class Form1 : Form
    {
        static string text = ""; //text received from the user
        ComboBox Options_DropDown = new ComboBox(); //pravim novo drop down menu
        Button Saved_Option = new Button();
        int picked_option = 0;
        string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();

            //Everything below is used for the options menu
            // \/\/\/\/\/\/
            //
            //Build a list
            var dataSource = new List<Options_Items>();
            dataSource.Add(new Options_Items() { Commentmethod = "Please select an option." });                 //0
            dataSource.Add(new Options_Items() { Commentmethod = "Override selected file." });                  //1
            dataSource.Add(new Options_Items() { Commentmethod = "Create a copy of the selected file." });      //2
            dataSource.Add(new Options_Items() { Commentmethod = "Copy the commented version to clipboard." }); //3

            //Setup data binding
            Options_DropDown.DataSource = dataSource;
            Options_DropDown.DisplayMember = "Commentmethod";

            // make it readonly
            Options_DropDown.DropDownStyle = ComboBoxStyle.DropDownList;

            Options_DropDown.SetBounds(345, 290, 207, 23);

            Saved_Option.Click += new System.EventHandler(this.btn_Save_Preferences_Click);

            Saved_Option.Name = "btn_Save_Preferences";
            Saved_Option.Text = "Save";
            Saved_Option.SetBounds(345, 316, 75, 23);
            Controls.Add(Options_DropDown); //dobavqme drop down menuto kum prozoreca
            Controls.Add(Saved_Option);

            Options_DropDown.Visible = false;
            Saved_Option.Visible = false;
            //
            // /\/\/\/\/\/\/\/\
            //Everything above is used for the options menu
        }

        private void btn_twitter_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://twitter.com/FLasersights"); //slagame linka koito iskame da otvorim tuk
            Process.Start(sInfo); //otvara goreposochenia link s default browsera (tozi koito potrebitelq e izbral kato default za negovia comp)
            //ivailo ti shiban idiot, ti si napravil tazi funcia i ako a pipnesh otnovo i ta se schupi shete ubia, big gay faggot
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            //ot tuk nadolu vsichko e copy pasta taka che nz kolko e dobro
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            var fileContent = string.Empty;
            filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt| C# Files (*.cs)|*.cs";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                    if (fileContent != null)
                    {
                        text = fileContent;
                    }
                }
            }
            DialogResult file_selected = MessageBox.Show("File Selected");
        }

        private void btn_comment_Click(object sender, EventArgs e) //boji pederas smotan kak moja da sburkash funkcia ot 5 reda i da breaknesh cqlata programa wtf ebi se
        {
            text = String_Creator.GetCommentedVersion(text);
            if (picked_option == 0)
            {
                string Warning_Message = "Please choose an option from the \"Options\" Menu in the bottom right corner.";
                MessageBox.Show(Warning_Message);
            }
            else if (picked_option == 1) //Overwrite selected file.
            {
                //to do
            }
            else if (picked_option == 2) //Create a copy of the selected file.
            {
                string[] splited_path = filePath.Split('.');
                string path = @splited_path[0] + "_commented" + '.' + splited_path[1];
                File.Create(path).Dispose();
                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.WriteLine(text);
                    tw.Close();
                    tw.Dispose();
                }
            }
            else if (picked_option == 3) //Copy the commented version to clipboard.
            {
                Clipboard.SetText(text);
            }
            MessageBox.Show(text);
        }

        private void btn_options_Click(object sender, EventArgs e)
        {
            Options_DropDown.Visible = true;
            Saved_Option.Visible = true;
        }

        private void btn_Save_Preferences_Click(object sender, EventArgs e)
        {
            if (Options_DropDown.SelectedIndex != 0)
            {
                picked_option = Options_DropDown.SelectedIndex;
                Options_DropDown.Visible = false;
                Saved_Option.Visible = false;
            }
            else
            {
                string Warning_Message = "Please choose an option";
                MessageBox.Show(Warning_Message);
            }
        }
    }
}