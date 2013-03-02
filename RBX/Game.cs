using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RBX
{
    public class Game
    {
        #region Fields
        private Field field;
        private List<Robot> Robots;       
        private Graphics graph;
        #endregion
        
        public Game (String dll1, String dll2, String dll3, Int32 fieldw, Int32 fieldh)
        {
            Random rand = new Random();
            
            Robots.Add(new Robot(dll1, new Vector((float)rand.Next(), (float)rand.Next())));
            Robots.Add(new Robot(dll2, new Vector((float)rand.Next(), (float)rand.Next())));
            Robots.Add(new Robot(dll3, new Vector((float)rand.Next(), (float)rand.Next())));

            field = new Field(fieldw, fieldh);
            Bmp = new Bitmap(field.width, field.height);
            graph = Graphics.FromImage(Bmp);
        }

        #region Properties
        public Bitmap Bmp
        {
            get;
        }

 
        

        #endregion

        #region Public methods
        public void NextStep()
        {
            
            foreach (Robot robot in Robots)
            {
                robot.Main();
                if (robot.HP <= 0)
                {
                    DestroyRobot(robot);
                    Robots.Remove(robot);
                }                
            }
            if (Robots.Count == 1)
            {
                Finish(Robots[0]);
            }
            Draw();
        }
        #endregion

        #region Private methods
        private void Draw()
        {
            foreach (Robot robot in Robots)
            {
                graph.DrawRectangle(new Pen(robot.Color, 2), robot.Rect);
            }
        }
       
        private void DestroyRobot(Robot robot)
        {
            graph.FillRectangle(new SolidBrush(Color.Black), robot.Rect);
        }

        private void Finish(Robot robot)
        {
            graph.FillRectangle(new SolidBrush(Color.Gold), robot.Rect);
            graph.DrawString("Robot " + robot.Name + " wins !");
        }
        #endregion
    }
}
