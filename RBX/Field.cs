using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RBX
{
    public class Field
    {
        public Int32 field_width { get; set; }
        public Int32 field_heigth { get; set; }
        public Point field_center { get; set; }
        public Point field_corner_left_top { get; set; }
        public Point field_corner_rigth_top { get; set; }
        public Point field_corner_left_bottom { get; set; }
        public Point field_corner_rigth_bottom { get; set; }
        public Point field_side_left_center { get; set; }
        public Point field_side_top_center { get; set; }
        public Point field_side_rigth_center { get; set; }
        public Point field_side_bottom_center { get; set; }

        public Field(Int32 field_width, Int32 field_heigth)
        {

        }
    }
}