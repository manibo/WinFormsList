using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsList.Model;

namespace WinFormsList
{
    public partial class Form1 : Form
    {
        private BindingList<Person> people;
        private List<Person> otherPeople = new List<Person>();

        private BindingList<Department> departments;
        private Person selectedPerson;
        private Department selectedDept;

        public Form1()
        {
            InitializeComponent(); //инициализация формы

            people = new BindingList<Person>(); //список людей

            people.Add(new Person() { FirstName = "Иван", LastName = "Иванов", MiddleName = "Иванович", IdDep = 1 });
            people.Add(new Person() { FirstName = "Петр", LastName = "Петров", MiddleName = "Петрович", IdDep = 1 });
            people.Add(new Person() { FirstName = "Сергей", LastName = "Сергеев", MiddleName = "Сергеевич", IdDep = 2 });
            people.Add(new Person() { FirstName = "Николай", LastName = "Николаев", MiddleName = "Николаевич", IdDep = 2 });
            people.Add(new Person() { FirstName = "Александра", LastName = "Александрова", MiddleName = "Александровна", IdDep = 3 });
            people.Add(new Person() { FirstName = "Виктория", LastName = "Викторова", MiddleName = "Викторовна", IdDep = 4 });
            people.Add(new Person() { FirstName = "Максим", LastName = "Максимов", MiddleName = "Максимович", IdDep = 4 });
            people.Add(new Person() { FirstName = "Федор", LastName = "Федоров", MiddleName = "Федорович", IdDep = 5 });



            departments = new BindingList<Department>(); //список отделов

            departments.Add(new Department() { Id = 1, D_Name = "Dept1" });
            departments.Add(new Department() { Id = 2, D_Name = "Dept2" });
            departments.Add(new Department() { Id = 3, D_Name = "Dept3" });
            departments.Add(new Department() { Id = 4, D_Name = "Dept4" });
            departments.Add(new Department() { Id = 5, D_Name = "Dept5" });


            //привязка источников к элементам формы
            peopleListBox.DataSource = people;
            depGridView.DataSource = departments;
        }


        //добавление человека в список
        private void addPersonButton_Click(object sender, EventArgs e)
        {
            if (depGridView.CurrentRow == null)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show("НЕТ ДАННЫХ В DEPARTMENT", "ОШИБКА", buttons);
            }
            else
            {
                Person person = new Person();
                Type personType = person.GetType();

                foreach (Control control in peopleFormPanel.Controls)
                {
                    foreach (var pers in personType.GetProperties())
                    {
                        if (control.Name == pers.Name)
                        {
                            if (pers.Name == "IdDep")
                            {
                                pers.SetValue(person, Int32.Parse(((TextBox)control).Text));
                            }
                            else
                            {
                                pers.SetValue(person, ((TextBox)control).Text);
                            }
                        }
                    }
                }
                people.Add(person);
            }
        }

        //вынесение записей выделенного человека в боковую панель
        private void peopleListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedPerson = (Person)peopleListBox.SelectedItem;
            Type personType = selectedPerson.GetType();

            foreach (Control control in peopleFormPanel.Controls)
            {
                foreach (var pers in personType.GetProperties())
                {
                    if (control.Name == pers.Name)
                    {
                        ((TextBox)control).Text = pers.GetValue(selectedPerson).ToString();
                    }
                }
            }
        }

        //редактирование записи
        private void editPersonButton_Click(object sender, EventArgs e)
        {
            Type personType = selectedPerson.GetType();

            foreach (Control control in peopleFormPanel.Controls)
            {
                foreach (var pers in personType.GetProperties())
                {
                    if (control.Name == pers.Name)
                    {
                        if (pers.Name == "IdDep")
                        {
                            pers.SetValue(selectedPerson, Int32.Parse(((TextBox)control).Text));
                        }
                        else
                        {
                            pers.SetValue(selectedPerson, ((TextBox)control).Text);
                        }
                    }
                }
            }
            people.ResetBindings();
        }


        //удаление выделенной записи
        private void deletePersonButton_Click(object sender, EventArgs e)
        {
            people.Remove(selectedPerson);
        }

        //добавление нового отдела
        private void addDeptButton_Click(object sender, EventArgs e)
        {
            int propCounter = 0;
            Department dept = new Department();
            Type deptType = dept.GetType();

            foreach (Control control in deptsFormPanel.Controls)
            {
                Type controlType =
                    control.GetType();
                if (controlType.Name == "TextBox")
                {
                    if (deptType.GetProperties()[propCounter].PropertyType.Name == "Int32")
                    {
                        deptType.GetProperties()[propCounter++]
                            .SetValue(dept, Int32.Parse(((TextBox)control).Text));
                    }
                    else
                    {
                        deptType.GetProperties()[propCounter++]
                            .SetValue(dept, ((TextBox)control).Text);
                    }
                }
            }
            departments.Add(dept);
        }


        //фильтрация по выделенному отделу
        void depGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedDept = (Department)depGridView.CurrentRow.DataBoundItem;

            otherPeople.AddRange(people);

            people.Clear();

            foreach (var item in otherPeople.FindAll(Person => Person.IdDep == selectedDept.Id))
            {
                people.Add(item);
            }

            otherPeople.RemoveAll(Person => Person.IdDep == selectedDept.Id);


            Type selDeptType = selectedDept.GetType();

            foreach (Control deptForm in deptsFormPanel.Controls)
            {
                foreach (var prop in selDeptType.GetProperties())
                {
                    if (deptForm.Name == prop.Name)
                    {
                        ((TextBox)deptForm).Text = prop.GetValue(selectedDept).ToString();
                    }
                }
            }
        }


        //удаление выделенного отдела
        private void button1_Click(object sender, EventArgs e)
        {
            departments.Remove(selectedDept);
        }

        //сброс фильтра по отделу
        private void buttonReset_Click(object sender, EventArgs e)
        {
            foreach (var item in otherPeople)
            {
                people.Add(item);
            }
            otherPeople.Clear();
        }

        //редактирование отдела
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control deptForm in deptsFormPanel.Controls)
            {
                foreach (var prop in selectedDept.GetType().GetProperties())
                {
                    if (deptForm.Name == prop.Name)
                    {
                        try
                        {
                            prop.SetValue(selectedDept, Int32.Parse(deptForm.Text));
                        }
                        catch
                        {
                            prop.SetValue(selectedDept, deptForm.Text);
                        }                        
                    }
                }
            }
            departments.ResetBindings();
        }
    }
}
