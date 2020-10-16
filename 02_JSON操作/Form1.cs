using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_JSON操作
{
    public partial class Form1 : Form
    {
        //形成一个JSON字符串
        string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个集合
            List<Student> stuList = new List<Student>()
            {
                new Student(){ StudentID=1,StudentName="龙嗷嗷",ClassName="视觉班"},
                new Student(){ StudentID=2,StudentName="龙傲天",ClassName="语言班"},
                new Student(){ StudentID=3,StudentName="龙傲地",ClassName="视觉班"}
            };
            //对象转换成字符串
            str = JSONHelper.EnitiyToJSON(stuList);
            //显示一下字符串
            Console.WriteLine(str);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Student> studList = JSONHelper.JSONToEntity<List<Student>>(str);
            //自动创建列表
            //this.dataGridView1.AutoGenerateColumns = false;
            //清空资源为显示做准备
            this.dataGridView1.DataSource = null;
            //绑定数据源
            this.dataGridView1.DataSource = studList;
        }
    }
}
