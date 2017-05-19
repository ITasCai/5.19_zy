using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._19_zy
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1.	学校要编写一个学生信息处理的程序，要求能够处理学生学号、姓名、系（院）、年龄等信息，其中，学校名称的信息属于共享的，凡是这个系统中处理的学生信息必须是本校学生。学号是学生入学时生成的，在学生在校期间学号不得改变。在增加新生数据的时候，既可增加学号、姓名、系、年龄等完整的信息，也可只为其中的学号、姓名字段赋值（必须有学号）。要求编写函数能够输出学生的所有信息数据。在使用过程中可以修改和读取学生的院系、年龄资料。

            //Console.WriteLine("请输入您的学号：");
            //int id = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的姓名：");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入您的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入您的院系：");
            //string faculty = Console.ReadLine();

            //Studet student = new Studet(id,name,age,faculty);

            //Console.WriteLine(student.ToString());

            //Console.ReadLine();

            #endregion
            #region 2.	现有资金1000元，目前银行存款利息为3%，这笔钱在银行存n年，请编写函数，求n年后的本金利息的和以及最后一年的利息。

            //Console.WriteLine("请输入您要存的钱数：");
            //double money = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("请输入您要存的年数：");
            //int year = Convert.ToInt32(Console.ReadLine());
            //Interest i= new Interest();
            //i.Money = money;
            //i.Year = year;
            //double sum= i.GetInterest(money,year);
            //Console.WriteLine("您一共存了{0}元，存了{1}年，一共获得{2}元",money,year,sum);
            //Console.ReadLine();


            #endregion
            #region 3.	定义一个学生类,有六个属性,分别为姓名、性别、年龄、语文、数学、英语成绩。 有2个方法：一个打招呼的方法：介绍自己叫XX，今年几岁了。是男同学还是女同学。   两个计算自己总分数和平均分的方法。{ 显示: 我叫XX,这次考试总成绩为X分,平均成绩为X分}   实化两个对象并测试:    张三 男 18  三科成绩为: 90 95 80 小兰 女 16  三科成绩为: 95 85 100

            //Console.WriteLine("输入你的姓名:");
            //string name = Console.ReadLine();
            //Console.WriteLine("输入你的性别：");
            //string sex = Console.ReadLine();
            //Console.WriteLine("输入你的年龄：");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("输入你的语文成绩");
            //double languages = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("输入你的数学成绩：");
            //double math = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("输入的你英语成绩：");
            //double english = Convert.ToDouble(Console.ReadLine());
            //Score score = new Score(name, sex, age, languages, math, english);
            //Console.WriteLine(score.ToString());
            //score.GetSunAsAvg(languages, math, english);
            //Console.ReadKey();

            #endregion
            #region 4.	给前面写的学生类添加构造方法.使在实例化学生类的时候可以通过构造方法对姓名性别年龄语数英等属性赋值,也可以只对姓名和性别赋值.年龄默认为18岁,语数英成绩默认为0分.


            //Score score = new Score("张三", "男", 18, 88, 77, 0);
            //Console.WriteLine(score.ToString());
            //score.GetSunAsAvg(88, 77, 0);
            //Console.ReadKey();

            #endregion
            #region 5.	写一个Ticket类,有一个距离属性(本属性只读,在构造方法中赋值),不能为负数,有一个价格属性,价格属性只读,并且根据距离计算价格(1元/公里): 0 - 100公里 票价不打折   101 - 200公里 总额打9.5折    201 - 300公里 总额打9折     300公里以上 总额打8折   有一个方法,可以显示这张票的信息.   测试上面的类.      参数中使用out 和  ref的区别  数组做为参数param




            #endregion

        }
    }
    /// <summary>
    /// 第一题，定义了一个学生类
    /// </summary>
    class Studet {

        private int id;
        private string name;
        private int age;
        private string faculty;

        static string school = "山东理工职业学院";

        /// <summary>
        /// 有参数的构造方法
        /// </summary>
        /// <param name="id">学号</param>
        /// <param name="name">姓名</param>
        /// <param name="age">年龄</param>
        /// <param name="faculty">院系</param>
        public Studet(int id,string name,int age,string faculty) {
            this.id = id;
            this.name = name;
            this.age = age;
            this.faculty = faculty;
        }

       /// <summary>
       /// get/set方法
       /// </summary>
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Faculty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }

        /// <summary>
        /// 重写tostring方法，用于信息的输出
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "学校为："+Studet.school+"\n学号为:"+id+"\n姓名为:"+name+"\n年龄为:"+age+"\n院系为："+faculty;
        }  
    }


    /// <summary>
    ///第二题，计算利息 
    /// </summary>
    class Interest
    {
        private double money;
        private int year;

        public double Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }

            set
            {
                year = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="money"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        public double GetInterest(double money,int year) {
            double sum = 0;
            for (int i = 1; i <=year; i++)
            {
                sum += money + (money*0.03);
            
            }

            return sum;
        }
    }


    /// <summary>
    /// 第三题,第四题，学生成绩类
    /// </summary>
    class Score
    {
        private string name;
        private string sex;
        private int age;
        private double languages;
        private double math;
        private double english;

        /// <summary>
        /// 学生属性的构造方法
        /// </summary>
        /// <param name="name">姓名</param>
        /// <param name="sex">性别</param>
        /// <param name="age">年龄</param>
        /// <param name="languages">语文</param>
        /// <param name="math">数学</param>
        /// <param name="english">英语</param>
        public Score(string name,string sex,int age,double languages,double math,double english) {
            this.name =name;
            this.sex = sex;
            this.age = age;
            this.languages = languages;
            this.math = math;
            this.english = english;
        }


        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public double Languages
        {
            get
            {
                return languages;
            }

            set
            {
                languages = value;
            }
        }

        public double Math
        {
            get
            {
                return math;
            }

            set
            {
                math = value;
            }
        }

        public double English
        {
            get
            {
                return english;
            }

            set
            {
                english = value;
            }
        }

        /// <summary>
        /// 用于计算成绩的总分和平均分
        /// </summary>
        /// <param name="languages">语文成绩</param>
        /// <param name="math">数学成绩</param>
        /// <param name="english">英语成绩</param>
        public void GetSunAsAvg(double languages,double math,double english) {
            double sum = languages + math + english;
            double avg = (sum /3);
            Console.WriteLine("总分为:{0},平均分为:{1}",sum,avg);
        }

        /// <summary>
        /// 重写tostring()方法用于信息的输出
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "姓名:"+name+"\t性别:"+sex+"\t年龄:"+age+"\n语文成绩:"+languages+"\t数学成绩"+math+"\t英语成绩"+english;
        }
    }


    /// <summary>
    /// 第五题，一个自定义的票类
    /// </summary>
    class Ticket {
        private double distance;
        private double price;

        /// <summary>
        /// 带参数的构造方法
        /// </summary>
        /// <param name="distance">距离</param>
        /// <param name="price">价格</param>
        public Ticket(double distance,double price) {
            this.Distance =distance;
            Price = 100;
        }

        public double Distance
        {
            get
            {
                return distance;
            }

            set
            {
                distance = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public void GetPrice(double distance,double price) {
            if ()
            {

            }
        }
    }
}
