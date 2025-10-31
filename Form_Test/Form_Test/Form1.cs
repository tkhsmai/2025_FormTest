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
        //これを使うと、サイズなどを全部一気に変えたいとき簡単
        //constをつけると初期化時にのみ値の変更が可能になる
        /// <summary>
        /// ボタンの横幅
        /// </summary>
        const int BUTTON_SIZE_X = 100;
        /// <summary>
        /// ボタンの縦幅
        /// </summary>
        const int BUTTON_SIZE_Y = 100;
　　　　/// <summary>
        /// ボタンが横に何個並ぶか
        /// </summary>
        const int BOARD_SIZE_X = 3;
        /// <summary>
        /// ボタンが縦に何個並ぶか
        /// </summary>
        const int BOARD_SIZE_Y = 3;

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    //インスタンスの作成
                    TestButton testButton = new TestButton(new Point(i * BUTTON_SIZE_X, j * BUTTON_SIZE_Y), 
                                            new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");

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

