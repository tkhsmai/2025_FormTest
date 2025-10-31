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
    internal class TestButton : Button
    {
        /// <summary>onの時の色</summary>
        private Color _onColor = Color.HotPink;

        /// <summary>offの時の色</summary>
        private Color _offColor = Color.Gray;

        /// <summary>現在onかoffか</summary>
        private bool _enable;


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
        


        public TestButton(Point position, Size size, string text)
        {
            //ボタンの位置を設定
            Location = position;

            //ボタンの大きさ設定
            Size = size;

            //ボタンの名前設定
            Text = text;

            SetEnable(false);

            //ボタンをクリックしたときに何を出力するか
            Click += ClickEvent;


        }

    // クリックしたときの出力内容を自分で設定
    private void ClickEvent(object sender, EventArgs e)
        {
            //クリックしたら色変わる(!は否定だからtrue⇔falseになる)
            SetEnable(!_enable);
        }
    }
}
