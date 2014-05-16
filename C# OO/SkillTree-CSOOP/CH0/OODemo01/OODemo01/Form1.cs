using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODemo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OODoor door = new CarDoor();
            door.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonOODoor door= new NonOODoor();
            //如果你是車門
            OpenCardDoor(door);
        }

        private void OpenCardDoor(NonOODoor door)
        {

            //開車門的程序
            door.Opened = true;
        }

        private void OpenRoomDoor(NonOODoor door)
        {
            //開房間門的程序
            door.Opened = true;
        }

       
    }
}
