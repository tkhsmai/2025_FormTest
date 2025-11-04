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

        public TestButton(Form1 form1, Point position, Size size, string text)
        {
            // Form1の参照を保管
            _form1 = form1;

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

        // クリックしたときの出力内容を自分で設定
        private void ClickEvent(object sender, EventArgs e)
        {
            _form1.GetTestButton(1, 2).SetEnable(true);
            // ctrl+r+r
        }
    }
}
