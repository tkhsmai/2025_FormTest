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

        /// <summary>ボタンの横幅</summary>
        const int BUTTON_SIZE_X = 100;
        /// <summary>ボタンの縦幅</summary>
        const int BUTTON_SIZE_Y = 100;

　　　　/// <summary>ボタンが横に何個並ぶか</summary>
        const int BOARD_SIZE_X = 3;
        /// <summary>ボタンが縦に何個並ぶか</summary>
        const int BOARD_SIZE_Y = 3;

        /// <summary>TestButtonの二次元配列</summary>
        private TestButton[,] _buttonArray;

        public Form1()
        {
            InitializeComponent();
            _buttonArray = new TestButton[BOARD_SIZE_Y, BOARD_SIZE_X];
            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    // インスタンスの作成
                    TestButton testButton = new TestButton(this, i, j,
                                            new Point(i * BUTTON_SIZE_X, j * BUTTON_SIZE_Y), 
                                            new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y), "");

                    // 配列にボタンの参照を追加
                    _buttonArray[j, i] = testButton;
                    
                    // コントロールにボタンを追加
                    Controls.Add(testButton);
                }
            }

        }

        public TestButton GetTestButton(int x, int y)
        {
            return _buttonArray[y, x];
        }

        // 自動生成
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリック");
        }
    }
}


         
         
         
         
         
         
         
         
         
         
         
         

