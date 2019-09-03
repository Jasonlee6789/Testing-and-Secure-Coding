using System;
using System.Collections.Generic;
using System.IO;// Remember  this  place to add 这是后加上去的 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestAssign_lijing
{
    public class FileManager
    {
        public List<MyClass> LoadMyClass()  
            // Access Modifier"public" means  when can call it  from  other classes(e.g. in Form1.cs on the Load click  event )
            // Return type :List<MyClass> means  it  will return a list of MyClass objects (e.g. What  has been read from  the txt. file
            // Method Name :LoadMyClass(), descriptive and has no parameters (e.g. nothing inside  the brackets)
        {
            try
            {
                List<MyClass> staffList = new List<MyClass>(); //对象初始化语句

                // Declare and instantiate a  new list of  MyClass objects ,name it to  "staffList"
                // the object type is  the " List<MyClass>  "
                // new List<MyClass>();  calling the List<> constructor .
                //I will populate this currently  empty list with creature MyClass objects which will create based on the data in  a text file .


                StreamReader sr = new StreamReader("MyClass.txt"); //对象初始化语句

                //declare and instantiate a new StreamReader object called sr to read from  the MyClass.txt. file 
                //StreamReader is  the object type.  "sr" is the  name of the StreamOeader
                //new streamReader("Myclass.txt"); calling the StreamReader constructor:passing in a string literal which is name"MyClass.txt" of the file to read from 
                // I will use the StreamReader to read the MyClass.txt data from file line by line 

                while (!sr.EndOfStream)  // While not at the end of the file read a new line .
                    // "While" is a syntax for a while loop ."(!sr.EndOfStream)" is the while loop condition ."!" this means not
                    //"sr" is the Streamraeder object . ".EndOfStream" (Bollean property that vecomes True when the end of file is reached.
                    //While(!) not at the (sr)StreamReader(.EndofStream)e nd of file>keep going 
                    
                {
                    string temp = sr.ReadLine(); // Read a line of MyClass data from the file and store in a temp string varilable 
                    // it is achieved by calling the StreamReader(sr) .ReadLine() method 

                    string[] values = temp.Split(',');
                    //Split the MyClass string into separate parts store in a string array variable
                    //Achieved by calling the string spilt method that converts a single string into a string array by spiltting the string at every specified character(determined by rhe parameter

                    MyClass s = new MyClass();
                    //Declare and instantiate a new MyClass object.Achieved by calling the default MyClass constructor
                    //Accordingly,it will have default values set for StaffID,name,Birthday,Email,Salary

                    s.StaffID = int.Parse(values[0]); 
                    s.Name = values[1]; // set the Name propertuy of the MyClass object "s." to creat name value read from file.
                    //Achieved by  using the string array index[1] .Sets the public property Name.
                    s.Birthday =values[2];
                    s.Email = values[3];
                    s.Salary = int.Parse( values[4]); // set the Salary property of the MyClass object "s." to creat salary value read from file 
                    //Achieved by using  the string array index[4] .Set the publidc property Salary.
                    //As Salary is an interger property and the value is currently in a string array (i.e. it's a string) we need to use int.Parse to convert from string to int.

                    staffList.Add(s);
                  //Add the new MyClass object (which has been populated with values from the file) to the staffList 
                  //Achieved by calling the creaturelist Add method and passing the MyClass object s in a as a parameter 
                }
                //Return to the top and check the condition :If the end of file has not been reach ,read the next line,spilt it two values,creature a new MyClassobject
                //set the properties,add it to the list .If the end of the file has been reached ,move on  from the loop

                sr.Dispose();
                //Close the StreamReader and release the MyClass.txt file .Achieved by calling the Streamreader Dispose method.
            
                return staffList;
                //Return  the populated list of MyClass objects that have been read from file
                //Achieved by returning the staffList object which was created  at the start of the method (orginally empty) and then populated by the code in the loop
            }
            catch(Exception)
            //Add  the Try Catch Block code.the code could possibly throw exceptions,
            //e.g.(int.Parse if the text file is out of order,or an extra enter. FileIO read/write permission. File not founds)
            {
                return null;
            }
        }

        public bool SaveMyClass(List<MyClass> staffs)
        //Access Modifier:public means when can call it from other classes(e.g. in Form1 on the sace click event)
        //Return type:bool means it will return a true if save is successful or false if there is an error 
        // methoid name :SaveMyClass parameter: List<MyClass> staffs , an object to save .And the save  name is staffs .

        {
            try // Try to run the following code 
            {
                StreamWriter sw = new StreamWriter("MyClass.txt");
                // Declare and instantiate a new StreamWriter object called sw to write  to a file 
                //StreamWriter is the object type ."sw" is the name of the StreamWriter object
                //new StreamWriter(fileName):calling the StreamWriter constructor , passing in a string (method parameter) which is name of the file to write to 
                //I will use  the streamWriter to write the MyClass data to the specified file 
                //If the file doesn't exist it will be created.
                foreach (MyClass x in staffs) 
                {
                    sw.WriteLine(x.StaffID + "," + x.Name + "," + x.Birthday + "," + x.Email + "," + x.Salary);
                    //sw.WriteLine: write a header and specific MyClass object data  to file(x.StaffID + "," + x.Name + "," + x.Birthday + "," + x.Email + "," + x.Salary)
                    //Achieved by calling the StreamWriter(sw.) WriteLine() method which takes a string as a parameter, the supplied string is written to a new line in the file .
                    //MyClass properties  are concatennated into the strings because the foreach method 
                }

                sw.Dispose();// close the SttreamWriter, this free up the newly created file,achieved by calling the dispose method.
                return true; // return true , save operation successsful .Achieved by return a true boolean value
            }
            catch(Exception) // Catch any exceptions 
            {// in this case ,if an exception is thrown something has gone wrong with the save operation, therefore we will return false
                return false;
            }
        }


        // add a method to save the lbxMyClass to Binary File
        public bool saveToBinary(List<MyClass> staffs)
        {// Append means add to the last one
            FileStream outFile = new FileStream("staffBinary.txt", FileMode.Append, FileAccess.Write);
            BinaryFormatter nzBinFile = new BinaryFormatter();
            foreach (MyClass staff in staffs)
                nzBinFile.Serialize(outFile, staff);
            outFile.Close();
            return true;
        }

        // add a method to open Binary File and deserialize to object
        public List<MyClass> openBinaryFile()
        {
            List<MyClass> staffs = new List<MyClass>();
            BinaryFormatter binData = new BinaryFormatter();
            MyClass nz = new MyClass();
            FileStream inFile = new FileStream("staffBinary.txt", FileMode.Open, FileAccess.Read);
            while (inFile.Position<inFile.Length)
            {
                nz = (MyClass)binData.Deserialize(inFile);
                staffs.Add(nz);
            }
            inFile.Close();
            return staffs;
        }
    }
}
