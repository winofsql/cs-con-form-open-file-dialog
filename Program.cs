using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace cs_console_open_file_dialog
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog obj = new OpenFileDialog();
            obj.Filter = "PHP|*.php";
            obj.InitialDirectory = @"C:\";

            if (obj.ShowDialog() != DialogResult.OK){
                return;
            }

            try
            {
                StreamReader sr = new StreamReader(obj.FileName, Encoding.GetEncoding("utf-8"));

                string text;

                // 内容を一気に読み込む
                Console.Write( text = sr.ReadToEnd() ); 

                sr.Close();

            }
            catch (Exception ex)
            {

                string error = ex.ToString();
                MessageBox.Show(error);
                return;

            }
        }
    }
}
