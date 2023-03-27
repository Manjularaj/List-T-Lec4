using Microsoft.VisualBasic;
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
        string[] firstnames = { "Will", "Hannah", "Anne", "Will" };
        string[] lastnames = { "Cram", "Angel", "Nguyen", "Cram" };
        int[] grades = { 57, 101, 110, 57 };

        List<string> firstNamesList = new List<string> { "Will", "Hannah", "Anne", "will" };
        List<string> lastNamesList;
        List<int> gradesList;


        string[] newFirstNames;

        public MainWindow()
        {

            InitializeComponent();
            lastNamesList = lastnames.ToList();
            gradesList = grades.ToList();

            DisplayFromList();

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

            //string fName = firstNamesList[i];
            //string lName = lastNamesList[i];
            //string grade = gradesList[i];

            runDisplay.Text += $"{i} - {firstNamesList[i]} {lastNamesList[i]} - {gradesList[i]} \n";
        }



        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
           
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fName = txtFirstName.Text;
            string lName = txtLastName.Text;
            int grade = int.Parse(txtGrade.Text);
            int index = int.Parse(txtInsertAt.Text);

            //to add list

            firstNamesList.Insert(index, fName);
            lastNamesList.Insert(index,lName);
            gradesList.Insert(index,grade);

            DisplayFromList();

        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {

            string fName = txtRemoveStudent.Text;

            //bool wasRemoved = firstNamesList.Remove(fName);
            
            while(firstNamesList.Contains(fName))
            {

                firstNamesList.Remove(fName);
            }
           

            //if (wasRemoved)
            //{
            //    MessageBox.Show(fName + "was removed from the list");

            //}
            //else
            //{
            //    MessageBox.Show("that name waa not on list");

            //}

            runDisplay.Text = "";
            foreach(string name in firstNamesList)
            {
                runDisplay.Text += name + "\n";


            }
        }

        private void btnRemoveAt_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(txtRemoveAt.Text);


            if(index < firstNamesList.Count)
            {
                firstNamesList.RemoveAt(index);
                lastNamesList.RemoveAt(index);
                gradesList.RemoveAt(index);

            }


            DisplayFromList();
        }

        
    }//Class




}// namespace
