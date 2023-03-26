using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace List_T_Lec4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] firstnames = { "Will", "Hannah", "Anne" };
        string[] lastnames = { "Cram", "Angel", "Nguyen" };
        int[] grades = { 57, 101, 110 };

        List<string> firstNamesList = new List<string> { "Will", "Hannah", "Anne" };
        List<string> lastNamesList;
        List<int> gradesList;


        string[] newFirstNames;

        public MainWindow()
        {

            InitializeComponent();
            lastNamesList = lastnames.ToList();
            gradesList = grades.ToList();

        }// Main.ToLoWindow

        public void DisplayFromList()
        {

            runDisplay.Text = "";

            for (int i = 0; i < firstNamesList.Count; i++)
            {

                FormatString(i);
            }

        }

        public void FormatString(int i)
        {

            runDisplay.Text += $"{firstNamesList[i]} {lastNamesList[i]} - {gradesList[i]}";
        }



        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            int grade = int.Parse(TxtGrade.Text);

            //to add list

            firstNamesList.Add(fName);
            lastNamesList.Add(lName);
            gradesList.Add(grade);

            DisplayFromList();


        }// btnAddStudent_click

        public void AnnoyingLargerArrayExample()
        {

            runDisplay.Text = firstnames.Length + "\n";

            newFirstNames = new string[firstnames.Length + 3];

            for (int i = 0; i < firstnames.Length; i++)
            {

                newFirstNames[i] = firstnames[i];
            }

            firstnames = newFirstNames;

            runDisplay.Text += firstnames.Length + "";
        }

        public void DisplayStudent()
        {
            runDisplay.Text = "";
            for (int i = 0; i < firstnames.Length; i++)
            {

                //First Name last Name - Grade
                runDisplay.Text += $"{firstnames[i]} {lastnames[i]} - {grades[i]}\n";
            }

        }


    }//Class




}// namespace
