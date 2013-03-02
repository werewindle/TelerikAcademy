using System;
using System.Linq;
using System.Text;


namespace Points
{
    struct Point3D
    {
        private int x;
        private int y;
        private int z;

        private static readonly Point3D blank = new Point3D(0, 0, 0);

        public Point3D(int pointX, int pointY, int pointZ) : this()
        {
            this.x = pointX;
            this.y = pointY;
            this.z = pointZ;
        }

        
        public static Point3D BlankPoint
        {
            get
            {
                return blank;
            }
        }

        public int PointX
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int PointY
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }


        public int PointZ
        {
            get
            {
                return this.z;
            }
            set
            {
                this.z = value;
            }
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("Point X: {0} ", this.PointX.ToString());
            
            output.AppendFormat("Point Y: {0} ", this.PointY.ToString());
            
            output.AppendFormat("Point Z: {0} ", this.PointZ.ToString());
            output.AppendLine();
            return output.ToString();
        }
    }
}
