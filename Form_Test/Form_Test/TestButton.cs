using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form_Test
{
    public class TestButton : Button
    {
        /// <summary>onの時の色</summary>
        private Color _onColor = Color.HotPink;

        /// <summary>offの時の色</summary>
        private Color _offColor = Color.Gray;

        /// <summary>現在onかoffか</summary>
        private bool _enable;

        /// <summary>Form1の参照</summary>
        private Form1 _form1;

        /// <summary>横位置</summary>
        private int _x;

        /// <summary>縦位置</summary>
        private int _y;


        // コンストラクタ
        public TestButton(Form1 form1, int x, int y, Size size, string text)
        {
            // Form1の参照を保管
            _form1 = form1;

            // 横位置を保管
            _x = x;

            // 縦位置を保管
            _y = y;


            //ボタンの位置を設定
            Location = new Point(x * size.Width, y * size.Height);

            //ボタンの大きさ設定
            Size = size;
            
            //ボタンの名前設定
            Text = text;
 
            SetEnable(true);

            //ボタンをクリックしたときに何を出力するか
            Click += ClickEvent;


        }

        public bool IsEnabled => _enable;

        /// <summary>onとoffの設定</summary>
        /// <param name="on"></param>
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }


        public void Toggle()
        {
            SetEnable(!_enable);
        }


        //楽な書き方
        //_form1.GetTestButton(_x, _y)?.Toggle();
        //_form1.GetTestButton(_x + 1, _y)?.Toggle();
        //_form1.GetTestButton(_x - 1, _y)?.Toggle();
        //_form1.GetTestButton(_x, _y + 1)?.Toggle();
        //_form1.GetTestButton(_x, _y - 1)?.Toggle();

        /// <summary>
        /// 各ボタンがクリックされたときに呼び出される関数
        /// クリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // 押したボタンの上下左右の色が変わる処理
        private void ClickEvent(object sender, EventArgs e)
        {
            for (int i = 0; i < _toggleData.Length; i++)
            {
                var data = _toggleData[i];
                var button = _form1.GetTestButton(_x + data[0], _y + data[1]);

                if (button != null)
                {
                    button.Toggle();     // 色反転
                }
            }

            // ゲームクリア表示処理


            bool first = _form1.GetTestButton(0, 0).IsEnabled;

            // すべてのボタンが同じ状態かチェック
            for(int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    var btn = _form1.GetTestButton(x, y);
                    if (btn == null) continue;
                    
                    if (btn.IsEnabled != first)
                    {
                        return;    // 1つでも違えばクリアじゃない
                    }
                }
            }
            
            // 全部同じならクリア
            MessageBox.Show("ゲームクリア！");
           

        }
        private int[][] _toggleData =
        {
            new int []{0,0},
            new int []{1,0},
            new int []{-1,0},
            new int []{0,1},
            new int []{0,-1},
        };

    }
}
// ctrl+r+rすると他のクラスに書いた変数も変えられる    
