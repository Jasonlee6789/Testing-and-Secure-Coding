using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAssign_lijing
{
    [Serializable]
    public class MyClass
    {
        private int staffID;//private 让variable 不能再其他类里访问，不写的话 也是默认 
        private string name;// these 5 can  be seen in the ClassDiagram as "Fields" format
        private string birthday;
        private string email;
        private int salary;
           
        //understand using 用下面的 public 公开 int   属性 properties ——  封装起来（ATM机器类比）
        public int StaffID     //注意此处首字母是大写，跟小写是不同的， the fice following 写的都是属性，而且是get set是固定格式
        {
            get { return staffID; }//  at last 读字段的值
            set { staffID = value; }// 可以 implement 改写字段staffID的值
        }

        public string Name      
        {
            get { return name; }
            set { name = value; }
        }

       
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public int Salary        //  int 
        {
            get { return salary; }
            set { salary = value; }
        }

        
        public string Birthday   // string  ? whether or nor there  is  an  specialized format for  Birthaday  to  limit input?
        {
            get => birthday;
            set => birthday = value;
        }

        public MyClass()   // optput use these   in case a  NULL value

        {
            StaffID = 0;
            Name = "NA";
            Birthday = "NA";
            Email = "NA";
            Salary = 0;
        }

        public override string ToString()// overrride  a  ToString method is a ordinary thing  , this place  is to  ToString  the txt 
        {
            return StaffID +"("+ Name +")" + Birthday + Email + "Salary:" + Salary;
        }

    }

}
