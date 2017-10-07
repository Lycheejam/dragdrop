using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drugdrop_test
{
    public partial class Form1 : Form
    {
        /*
         * drag&dropでファイルパスを取得して画像を表示するプログラム
         * 参考 : Drag&Dropされたファイルのファイル名を取得する: .NET Tips: C#, VB.NET
         * https://dobon.net/vb/dotnet/control/droppedfile.html
         */
        public Form1()
        {
            InitializeComponent();
        }

        private void filePathBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] fileName = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
            filePathBox.Text = fileName[0];

            pb1.Image = Image.FromFile(@fileName[0]);
        }

        //コントロール内にドラッグされた時に実行される。
        // 参考 : Control.DragEnter イベント (System.Windows.Forms)
        // https://msdn.microsoft.com/ja-jp/library/system.windows.forms.control.dragenter(v=vs.90).aspx
        private void filePathBox_DragEnter(object sender, DragEventArgs e)
        {
            //ファイルかどうかを判断する。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                //ファイルならばコピー
                e.Effect = DragDropEffects.Copy;
            }else{
                //ファイルでなければ何もしない。
                e.Effect = DragDropEffects.None;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            //picturBox,textBox初期化
            pb1.Image = null;
            filePathBox.Text = "";

            //fileName配列は呼び出し時に宣言されるので初期化不要？
        }
    }
}
