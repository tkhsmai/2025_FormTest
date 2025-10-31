using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Form_Test
{
    internal class TestButton : Button
    {
       public TestButton(Point position, Size size, string text)
        {
            //ボタンの位置を設定
            Location = position;

            //ボタンの大きさ設定
            Size = size;

            //ボタンの名前設定
            Text = text;

            //ボタンをクリックしたときに何を出力するか
            Click += ClickEvent;
        }

    // クリックしたときの出力内容を自分で設定
    private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("TestButton内で設定");
        }
    }
}
