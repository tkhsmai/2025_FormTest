using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //インスタンスの作成
                    TestButton testButton = new TestButton();

                    //ボタンの位置を設定
                    testButton.Location = new Point(i * 90, j * 50);

                    //ボタンの大きさ設定
                    testButton.Size = new Size(80, 40);

                    //ボタンの名前設定
                    testButton.Text = "TestButton";

                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }
        }
           
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form始動！");
        }
    }
}

