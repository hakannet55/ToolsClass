using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace ToolsClass
{
    public class Tools
    {
        public static string glob_proje = "";

        public void setVal(string s) {
            glob_proje = s;
        }

        public string getVal()
        {
            return glob_proje;
        }

        public void print(string s) {
            Console.WriteLine(s);
        }

        public string var_dump(Array t){
          string sr = string.Join(",",t);
          return sr;
        }

        public void echo(Form t,string s) {
            t.Controls.Add(
                new Label 
                {
                    Location = new Point(1, 2), 
                    Size = new System.Drawing.Size(143, 18), 
                    BorderStyle = BorderStyle.FixedSingle, 
                    Text = s 
                });
        }
        public void alert(string s)
        {
            MessageBox.Show(s);
        }
        public bool empty(string s)
        {
            return String.IsNullOrWhiteSpace(s);
        }
        public void go_to(Form t, Form a)
        {
            a.Show();
            t.Hide();
        }
        public void unlink(string s) {
            if (File.Exists(s)) {
                System.GC.Collect();
                System.GC.WaitForPendingFinalizers(); 
                File.Delete(s);
            }
        }
        public void dir_add(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }
        public Array dir_scan(string path,string filetype) { 
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles(filetype); //Getting Text files

            return Files;
        }
        public string get_cw() {
            string st="";
            var pat = Application.ExecutablePath;
            st = System.IO.Path.GetDirectoryName(pat);
            return st;
        }
        public void go_url(string st) {
            System.Diagnostics.Process.Start("http://" + st);
        }
    }
}
