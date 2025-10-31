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
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //インスタンスの作成
                    TestButton testButton = new TestButton(new Point(i * 50, j * 50), new Size(50, 50), "TestButton");

                    //ボタンの位置を設定
                    //testButton.Location = new Point(i * 90, j * 50);

                    //ボタンの大きさ設定
                    //testButton.Size = new Size(80, 40);

                    //ボタンの名前設定
                    //testButton.Text = "TestButton";

                    //ボタンをクリックしたときに何を出力するか
                    //ここでは下の処理の"クリックされてしまいました"という言葉が出力される
                    //testButton.MouseHover += hogehogeClick;

                    //コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }   
        }

        //private void hogehogeClick(object sender, EventArgs e)
        //{
        //    MessageBox.Show("クリックされてしまいました");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form始動！");
        }
    }
}

