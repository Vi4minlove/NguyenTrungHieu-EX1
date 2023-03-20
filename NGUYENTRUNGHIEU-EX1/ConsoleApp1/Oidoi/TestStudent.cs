using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Oidoi
{
    internal class TestStudent
    {

        //private List<Student> ListStudent = null;
        //public TestStudent()
        //{
        //    ListStudent = new List<Student>();
        //}
        List<Student> ListStudent = new List<Student>();
        //nhập thông tin sinh viên mới
        public void Nhap()
        {

            Student st = new Student();
            Console.Write("ID: ");
            st.Id = System.Int32.Parse(Console.ReadLine());
            Console.Write("Name: ");
            st.Name = Console.ReadLine();
            Console.Write("Gender: ");
            st.Gender = Console.ReadLine();
            Console.Write("Age: ");
            st.Age = System.Int32.Parse(Console.ReadLine());
            Console.Write("Date of birth: ");
            st.DateOfBirth = System.DateTime.Parse(Console.ReadLine());
            Console.Write("Class: ");
            st.Class = Console.ReadLine();
            Console.Write("Mark1: ");
            st.Mark1 = System.Int32.Parse(Console.ReadLine());
            Console.Write("Mark2: ");
            st.Mark2 = System.Int32.Parse(Console.ReadLine());
            Console.Write("Mark3: ");
            st.Mark3 = System.Int32.Parse(Console.ReadLine());
            Average(st);
            ListStudent.Add(st);
        }
        //tìm kiếm theo tên keyword
        public List<Student> FindByName (String keyword)
        {
            List<Student> searchResult = new List<Student>();
            if(ListStudent != null && ListStudent.Count>0)
            {
                foreach(Student st in ListStudent)
                {
                    if (st.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(st);
                    }
                }
            }
            return searchResult;
        }
        //Cập nhật theo ID
        public void UpdateStudent(int ID)
        {
            //tìm kiếm id có ms sửa,không thì đi
            Student st = FindByID(ID);
            if(st != null)
            {
                Console.Write("Name: ");
                string name = Convert.ToString(Console.ReadLine());
                if (name != null && name.Length > 0)
                {
                    st.Name = name;
                }
                Console.Write("Gender: ");
                string gen = Convert.ToString(Console.ReadLine());
                if (gen != null && gen.Length > 0)
                {
                    st.Gender = gen;
                }
                Console.Write("Age: ");
                string age = Convert.ToString(Console.ReadLine());
                if (age != null && age.Length > 0)
                {
                    st.Age = Convert.ToInt32(age);
                }
                Console.Write("DateOfBirth: ");
                string dob = Convert.ToString(Console.ReadLine());
                if (dob != null && dob.Length > 0)
                {
                    st.DateOfBirth = Convert.ToDateTime(dob);
                }
                Console.Write("Mark1: ");
                string m1 = Convert.ToString(Console.ReadLine());
                if (m1 != null && m1.Length > 0)
                {
                    st.Mark1 = Convert.ToDouble(m1);
                }
                Console.Write("Mark2: ");
                string m2 = Convert.ToString(Console.ReadLine());
                if (m2 != null && m2.Length > 0)
                {
                    st.Mark2 = Convert.ToDouble(m2);
                }
                Console.Write("Mark3: ");
                string m3 = Convert.ToString(Console.ReadLine());
                if (m3 != null && m3.Length > 0)
                {
                    st.Mark3 = Convert.ToDouble(m3);
                }

                Average(st);
            }
            else
            {
                Console.WriteLine($"None: {ID}");
            }

        }
        //Tìm kiếm theo ID - xóa
        public Student FindByID(int ID)
        {
            Student searchResult = null;
            if (ListStudent != null && ListStudent.Count > 0)
            {
                foreach (Student st in ListStudent)
                {
                    if (st.Id == ID)
                    {
                        searchResult = st;
                    }
                }
            }
            return searchResult;
        }
        //xóa 
        public bool DeleteById(int ID)
        {
            bool IsDel = false;
            Student st = FindByID(ID);
            if(st != null)
            {
                IsDel = ListStudent.Remove(st);
            }
            return IsDel;
        }
        //tính điểm tb - sắp xếp
        private void Average(Student st)
        {
            double Average = (st.Mark1 + st.Mark2 + st.Mark3)/ 3;
            st.Average = Math.Round(Average, 2, MidpointRounding.AwayFromZero);
        }
        //sắp xếp tăng dần
        public void SortByAverage()
        {
            ListStudent.Sort(delegate (Student st1, Student st2)
            {
                return st1.Average.CompareTo(st2.Average);
            });
        }
        //Show all
        public void ShowStudent(List<Student> ListST)
        {
            Console.WriteLine("{0, -5} {1, -15} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 5} {8, 5}","Id", "Name", "Gender", "Age", "Date of Birth", "Class", "Mark1", "Mark2", "Mark3");
            if (ListST != null && ListST.Count > 0)
            {
                foreach (Student st in ListST)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                                      st.Id, st.Name, st.Gender, st.Age, st.DateOfBirth, st.Class, st.Mark1, st.Mark2, st.Mark3);
                }
            }
            Console.WriteLine();
        }
    }
}
