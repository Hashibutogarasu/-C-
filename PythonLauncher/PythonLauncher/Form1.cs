using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PythonLauncher
{
    
    public partial class Form1 : Form
    {
        private Point mousePoint;

        public Form1()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.None;
            CloseButton.Location = new Point(x:(this.Size.Width-this.CloseButton.Width), y:0);
            
            Debug.Print("フォームX座標 = {0}", this.Location.X);
            Debug.Print("フォームY座標 = {0}", this.Location.Y);
            Debug.Print("フォームの横幅 = {0}", this.Size.Width);
            Debug.Print("フォームの高さ = {0}", this.Size.Height);

            Debug.Print("フォームX座標 = {0}", this.Bounds.X);
            Debug.Print("フォームY座標 = {0}", this.Bounds.Y);
            Debug.Print("フォームの横幅 = {0}", this.Bounds.Width);
            Debug.Print("フォームの高さ = {0}", this.Bounds.Height);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
            
        }

        private void MoveForm(object sender, MouseEventArgs e)
        {

            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void Form1_MouseMove(object sender,System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }
    }
}
