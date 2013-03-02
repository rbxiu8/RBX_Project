using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RBX
{
    public class Robot
    {
        private Int32 engineCapacity;
        private Int32 armor;
        private Int32 bulletSpeed;
        private Int32 firepower;
        public String name { get; }
        private String dll;
        public Int32 hp { get; set; }
        public Vector location { get; set; } // Заменили на вектор
        private Size size = new Size(20, 20);
        public Rectangle rect { get; }
        public List<Robot> Robots { get; set; }

        public Robot(String sdll, Vector slocation)
        {
            dll = sdll;
            location = slocation;

        }
        void Main()
        {

        }
        void GoTo(Vector pos)
        {
            location = pos;
        }
        void FireTo(Vector pos)
        {
            Bullet bullet = new Bullet(location, pos, firepower);
        }
    }
}

