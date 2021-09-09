using System;
using System.Collections.Generic;
using System.Text;
using PDC6_MOD3_ACT01.Model;
using Xamarin.Forms;
using System.ComponentModel;

namespace PDC6_MOD3_ACT01.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged

    {
        public student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }   
     
        public int StudentIdEntry { get; set; }
        public int StudentIdDisplay { get; set; }
        public string NameEntry { get; set; }
        public string NameDisplay { get; set; }
        public string StudentCodeEntry { get; set; }
        public string StudentCodeDisplay { get; set; }
      

        public string StudentTitleEntry { get; set; }
        public string StudentTitleDisplay { get; set; }

        public string StudentUnitEntry { get; set; }
        public string StudentUnitDisplay { get; set; }
        public DateTime DateEntry { get; set; }
        public DateTime DateDisplay { get; set; }
        public Command ClearEntry { get; set; }
        public StudentViewModel()
        {
            //StudentSet = new student
            //{
            //    Subjectcode = "TestCodddddd",
            //    SubjectTitle = "TestTitle",
            //    Unit = 0
            //};
            SubmitEntry = new Command(() =>
            {
                StudentSet = new student
                {
                    Subjectcode = StudentCodeEntry,
                };
                NameDisplay = NameEntry;
                StudentCodeDisplay = StudentCodeEntry;
                StudentIdDisplay = StudentIdEntry;
                DateDisplay = DateEntry;
                StudentCodeDisplay = StudentCodeEntry;
                StudentTitleDisplay = StudentTitleEntry;
                StudentUnitDisplay = StudentUnitEntry;
                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentCodeEntry)); 

                OnPropertyChanged(nameof(NameDisplay));
                OnPropertyChanged(nameof(NameEntry));  

                OnPropertyChanged(nameof(StudentIdDisplay));
                OnPropertyChanged(nameof(StudentIdEntry));

                OnPropertyChanged(nameof(DateDisplay));
                OnPropertyChanged(nameof(DateEntry));

                OnPropertyChanged(nameof(StudentTitleDisplay));
                OnPropertyChanged(nameof(StudentTitleEntry));


                OnPropertyChanged(nameof(StudentUnitDisplay));
                OnPropertyChanged(nameof(StudentTitleEntry));
            });
            ClearEntry = new Command(() =>
            {
                NameEntry = "";
                StudentIdEntry = 0;
                Convert.ToString(DateEntry);
                StudentCodeDisplay = "";
                StudentTitleDisplay = "";
                StudentUnitDisplay = "";
                StudentCodeEntry = "";
                StudentTitleEntry = "";
                StudentTitleEntry = "";

                OnPropertyChanged(nameof(NameDisplay));
                OnPropertyChanged(nameof(NameEntry));

                OnPropertyChanged(nameof(StudentIdDisplay));
                OnPropertyChanged(nameof(StudentIdEntry));

                OnPropertyChanged(nameof(DateDisplay));
                OnPropertyChanged(nameof(DateEntry));

                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentCodeEntry));

                OnPropertyChanged(nameof(StudentTitleDisplay));
                OnPropertyChanged(nameof(StudentTitleEntry));


                OnPropertyChanged(nameof(StudentUnitDisplay));
                OnPropertyChanged(nameof(StudentTitleEntry));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));

        }
    }
}
