using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestAssign_lijing;


namespace NZUnitTest
{
    [TestClass]
    public class MyClassUnitTest
    {
        [TestMethod]
        public void TestBirthday()
        {
            MyClass s = new MyClass();

            s.Birthday = "2017/09/30";
            Assert.AreEqual("2017/09/30", s.Birthday);

            //Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
        }

        [TestMethod]
        public void TestName()
        {
            MyClass s = new MyClass();

            s.Name = "Fisher";

            Assert.AreEqual("Fisher", s.Name);//Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
        }

        [TestMethod]

        public void TestEmail()
        {
            MyClass s = new MyClass();

            s.Email = "ldl@qq.com";

            Assert.AreEqual("ldl@qq.com", s.Email);//Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
        }

        [TestMethod]

        public void TestStaffID()
        {
            MyClass s = new MyClass();

            s.StaffID = 206666;

            Assert.AreEqual(206666, s.StaffID);//Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
        }


        [TestMethod]

        public void TestSalary()
        {
            MyClass s = new MyClass();

            s.Salary = 2020202;

            Assert.AreEqual(2020202, s.Salary, "Salary is fail");//Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
        }//Adding a third parameter willprovide specific informationregarding any failed tests


        [TestMethod]

        public void TestLoadMyclass()
        {
            MyClass s = new MyClass();

            Assert.AreEqual("NA", s.Birthday, "Birthday Fail");//Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
            Assert.AreEqual("NA", s.Name, "Name Fail"); //Multiple Asserts can be usedwithin a Unit Test Method
            Assert.AreEqual("NA", s.Email, "Email Fail"); //The Unit Test will pass if “all”assert statement pass
            Assert.AreEqual(0, s.Salary, "Salary  fail");
            Assert.AreEqual(0, s.StaffID, "StaffId fail");
        }


        [TestMethod]

        public void TestMyClassToStringFormat()
        {
            //ceate a  s object

            MyClass s = new MyClass();

            s.StaffID = 2017;
            s.Name = "lijing";
            s.Birthday = "1987/04/25";
            s.Email = "lj@qq.com";
            s.Salary = 100000;

            // check  object enerates the expected string 
            Assert.AreEqual("2017(lijing)1987/04/25lj@qq.comSalary:100000", s.ToString(),"Tostring format is fail");
            //Assert.AreEqual(obj1,obj2):returns True if obj1 and obj2 are the same 
        }




    }


    [TestClass]

    public class FilterTest
    {
        [TestMethod]

        public void TestFilterSortAZ()
        {
            MyClass s1 = new MyClass();
            s1.Name = "A";
            s1.Birthday = "1987";
            s1.Email = "@";
            s1.StaffID = 1;
            s1.Salary = 2;


            MyClass s2 = new MyClass();
            s2.Name = "B";
            s2.Birthday = "1987";
            s2.Email = "@";
            s2.StaffID = 0;
            s2.Salary = 10;


            MyClass s3 = new MyClass();
            s3.Name = "C";
            s3.Birthday = "1986";
            s3.Email = "124";
            s3.StaffID = 10;
            s3.Salary = 3;

            List<MyClass> slistExcepted = new List<MyClass>(); //create an expected list"slistExcepted:
            slistExcepted.Add(s1);
            slistExcepted.Add(s2);
            slistExcepted.Add(s3);


            List<MyClass> slistCom = new List<MyClass>();
            slistCom.Add(s3);
            slistCom.Add(s1);
            slistCom.Add(s2);

            Filter f = new Filter();  // use a Filter instance to search  the list for a search term 

            slistCom = f.SortAZ(slistCom); //create an out of order list "slistCom"

            CollectionAssert.AreEqual(slistExcepted, slistCom, "SortAZ is fail");//use CollectionAssert to check the SortAZ method has correctly sorted the list

        }


        [TestMethod]

        public void TestFilterSortNum()
        {
            MyClass s1 = new MyClass();
            s1.Salary = 7;
            s1.Name = "kobe";
            s1.StaffID = 2019;
            s1.Email = "qq";
            s1.Birthday = "3";

            MyClass s2 = new MyClass();
            s2.Salary = 6;
            s2.Name = "allen";
            s2.StaffID = 2011;
            s2.Email = "163";
            s2.Birthday = "2";

            MyClass s3 = new MyClass();
            s3.Salary = 8;
            s3.Name = "kobe";
            s3.StaffID = 1996;
            s3.Email = "gmail";
            s3.Birthday = "1996";

            MyClass s4 = new MyClass();
            s4.Salary = 9;
            s4.Name = "allen3";
            s4.StaffID = 1996;
            s4.Email = "yahoo";
            s4.Birthday = "1996";


            List<MyClass> SlistExcepted = new List<MyClass>();

            SlistExcepted.Add(s2);
            SlistExcepted.Add(s1);
            SlistExcepted.Add(s3);
            SlistExcepted.Add(s4);

            List<MyClass> slist = new List<MyClass>();

            slist.Add(s3);
            slist.Add(s2);
            slist.Add(s4);
            slist.Add(s1);

            Filter f = new Filter();

            slist = f.SortNum(slist);

            CollectionAssert.AreEqual(SlistExcepted, slist, "SortNum is fail");
        }

        [TestMethod]

        public void TestFilterSearch()
        {
            //Create five staffswith unique names
            MyClass s1 = new MyClass();
            s1.Name = "Kobe";

            MyClass s2 = new MyClass();
            s2.Name = "allen";

            MyClass s3 = new MyClass();
            s3.Name = "Jack";

            MyClass s4 = new MyClass();
            s4.Name = "YaoMing";

            MyClass s5 = new MyClass();
            s5.Name = "James";

            List<MyClass> nlistExcepted = new List<MyClass>();
            //add to a  MyClass List nlistExcepted 
            nlistExcepted.Add(s1);
            nlistExcepted.Add(s2);
            nlistExcepted.Add(s3);
            nlistExcepted.Add(s4);
            nlistExcepted.Add(s5);

            Filter f = new Filter();

            List<MyClass> searchResults = new List<MyClass>();

            searchResults = f.Search(nlistExcepted, "k");
            //Use a Filter instance to searchthe list for a search term. And Save the search results in a new list
            //Use CollectionAssert to check the search results contain the correct characters 
            CollectionAssert.Contains(searchResults, s3);
            CollectionAssert.Contains(searchResults, s1);
            CollectionAssert.DoesNotContain(searchResults, s5);
            CollectionAssert.DoesNotContain(searchResults, s2);
            CollectionAssert.DoesNotContain(searchResults, s4);

        }

    }




    [TestClass]
    public class FMUnitTest
    {
       
        [TestMethod]
        public void TestLoadMyClass()
        {


            MyClass s1 = new MyClass();
            s1.StaffID = 201902204;
            s1.Name = "Jason";
            s1.Birthday = "1987/04/25";
            s1.Email = "jeffersonlee@163.com";
            s1.Salary = 200000;

            MyClass s2 = new MyClass();
            s2.Name = "Fred";
            s2.StaffID = 201902406;
            s2.Email = "jk@gmail.com";
            s2.Birthday = "1986/02/23";
            s2.Salary = 160000;

            MyClass s3 = new MyClass();
            s3.Name = "Apple";
            s3.StaffID = 201901623;
            s3.Email = "apple@163.com";
            s3.Birthday = "1989/12/26";
            s3.Salary = 230000;

            MyClass s4 = new MyClass();
            s4.Name = "Fisher";
            s4.StaffID = 201709307;
            s4.Email = "fs@gamil.com";
            s4.Birthday = "1987/04/25";
            s4.Salary = 230000;

            List<MyClass> staffListExcepted = new List<MyClass>();

            staffListExcepted.Add(s1);
            staffListExcepted.Add(s2);
            staffListExcepted.Add(s3);
            staffListExcepted.Add(s4);
          

            // use a Filter instance to search the list for a search term 

            List<MyClass> Load = new List<MyClass>();
            FileManager f = new FileManager();
            Load = f.LoadMyClass();
            //  i wanna compare one by one from the two list .staffListExcepted is the excepted list ,Load is the out list.
            for (int i=0;i<=5;i++)  
            { 
               Assert.AreEqual(staffListExcepted[i],Load[i],"LoadMyClass mehod in FM is fail");
            }

        }


        [TestMethod]

        public void TestSaveMyClass()
        {

          
            MyClass s1 = new MyClass();
                s1.StaffID = 201902204;
                s1.Name = "lason";
                s1.Birthday = "1987/04/25";
                s1.Email = "jeffersonlee@163.com";
                s1.Salary = 200000;

                List<MyClass> listExcepted = new List<MyClass>();

                listExcepted.Add(s1);

            FileManager f = new FileManager();


            bool j = f.SaveMyClass(listExcepted);


            Assert.IsTrue(j);


        }
    }
}
