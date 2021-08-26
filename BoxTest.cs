using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace _3DRenderer
{
    public partial class BoxTest : Form
    {
        Cube cube;
        Point center;
        bool Dragging;

        public BoxTest()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cube = new Cube(tbSizeX.Value);
            center = new Point(DrawingArea.Width / 2, DrawingArea.Height / 2);
            render();
        }

        private void render()
        {
            //Set the rotation values
            cube.RotateX = tbX.Value;
            cube.RotateY = tbY.Value;
            cube.RotateZ = tbZ.Value;

            //Cube is positioned based on center
            DrawingArea.Image = cube.drawCube(center);
        }

        private void tX_Scroll(object sender, EventArgs e)
        {
            render();
        }

        private void tY_Scroll(object sender, EventArgs e)
        {
            render();
        }

        private void tZ_Scroll(object sender, EventArgs e)
        {
            render();
        }

        private void tAnimator_Tick(object sender, EventArgs e)
        {
            bool X = cbAnimateX.Checked;
            bool Y = cbAnimateY.Checked;
            bool Z = cbAnimateZ.Checked;

            if (X)
            {
                int predictedX = tbX.Value + tbSpeed.Value;
                if (predictedX > tbX.Maximum)
                    tbX.Value = tbX.Minimum;
                else if (predictedX < tbX.Minimum)
                    tbX.Value = tbX.Maximum;
                else
                    tbX.Value = predictedX;
            }

            if (Y)
            {
                int predictedY = tbY.Value + tbSpeed.Value;
                if (predictedY > tbY.Maximum)
                    tbY.Value = tbY.Minimum;
                else if (predictedY < tbY.Minimum)
                    tbY.Value = tbY.Maximum;
                else
                    tbY.Value = predictedY;
            }

            if (Z)
            {
                int predictedZ = tbZ.Value + tbSpeed.Value;
                if (predictedZ > tbZ.Maximum)
                    tbZ.Value = tbZ.Minimum;
                else if (predictedZ < tbZ.Minimum)
                    tbZ.Value = tbZ.Maximum;
                else
                    tbZ.Value = predictedZ;
            }

            if (X || Y || Z)
                render();
        }

        private void tbSizeX_Scroll(object sender, EventArgs e)
        {
            if (cbSyncSize.Checked)
            {
                tbSizeY.Value = tbSizeX.Value;
                tbSizeZ.Value = tbSizeX.Value;
            }

            UpdateSize(tbSizeX.Value, tbSizeY.Value, tbSizeZ.Value);
        }
        private void tbSizeY_Scroll(object sender, EventArgs e) => UpdateSize(tbSizeX.Value, tbSizeY.Value, tbSizeZ.Value);
        private void tbSizeZ_Scroll(object sender, EventArgs e) => UpdateSize(tbSizeX.Value, tbSizeY.Value, tbSizeZ.Value);

        public void UpdateSize(int X, int Y, int Z)
        {
            cube = new Cube(X, Y, Z);
            render();
        }

        private void cbSyncSize_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSyncSize.Checked)
            {
                tbSizeY.Value = tbSizeX.Value;
                tbSizeZ.Value = tbSizeX.Value;
                tbSizeY.Enabled = false;
                tbSizeZ.Enabled = false;
            }
            else
            {
                tbSizeY.Enabled = true;
                tbSizeZ.Enabled = true;
            }
            UpdateSize(tbSizeX.Value, tbSizeY.Value, tbSizeZ.Value);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cubeColor.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = cubeColor.Color;
                cube.Color = cubeColor.Color;
            }
        }

        private void DrawingArea_MouseDown(object sender, MouseEventArgs e)
        {
            Point MousePos = e.Location;
            if (MousePos.X > DrawingArea.Width || MousePos.X < 0 || MousePos.Y > DrawingArea.Height || MousePos.Y < 0)
                return;

            center = MousePos;
            Dragging = true;
            render();
        }

        private void DrawingArea_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging)
            {
                Point MousePos = e.Location;
                if (MousePos.X > DrawingArea.Width || MousePos.X < 0 || MousePos.Y > DrawingArea.Height || MousePos.Y < 0)
                    return;

                center = MousePos;
                render();
            }
        }

        private void DrawingArea_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
    }

    internal class Math3D
    {
        public class Vector3
        {
            public double X;
            public double Y;
            public double Z;

            public Vector3(int x, int y, int z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Vector3(float x, float y, float z)
            {
                X = (double)x;
                Y = (double)y;
                Z = (double)z;
            }

            public Vector3(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }

            public Vector3()
            {
            }
        }

        public class Camera 
        {
            public Vector3 Position = new Vector3();
        }

        public static Vector3 RotateX(Vector3 MyVec, double degrees)
        {
            //Euler's matrix formula for rotating a 3D point x degrees around the x-axis

            //[ a  b  c ] [ x ]   [ x*a + y*b + z*c ]
            //[ d  e  f ] [ y ] = [ x*d + y*e + z*f ]
            //[ g  h  i ] [ z ]   [ x*g + y*h + z*i ]

            //[ 1    0        0   ]
            //[ 0   cos(x)  sin(x)]
            //[ 0   -sin(x) cos(x)]

            double cDegrees = (Math.PI * degrees) / 180.0f; //Convert degrees to radian for .Net Cos/Sin functions
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double y = (MyVec.Y * cosDegrees) + (MyVec.Z * sinDegrees);
            double z = (MyVec.Y * -sinDegrees) + (MyVec.Z * cosDegrees);

            return new Vector3(MyVec.X, y, z);
        }

        public static Vector3 RotateY(Vector3 MyVec, double degrees)
        {
            //Y-axis

            //[ cos(x)   0    sin(x)]
            //[   0      1      0   ]
            //[-sin(x)   0    cos(x)]

            double cDegrees = (Math.PI * degrees) / 180.0; //Radians
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double x = (MyVec.X * cosDegrees) + (MyVec.Z * sinDegrees);
            double z = (MyVec.X * -sinDegrees) + (MyVec.Z * cosDegrees);

            return new Vector3(x, MyVec.Y, z);
        }

        public static Vector3 RotateZ(Vector3 MyVec, double degrees)
        {
            //Z-axis

            //[ cos(x)  sin(x) 0]
            //[ -sin(x) cos(x) 0]
            //[    0     0     1]

            double cDegrees = (Math.PI * degrees) / 180.0; //Radians
            double cosDegrees = Math.Cos(cDegrees);
            double sinDegrees = Math.Sin(cDegrees);

            double x = (MyVec.X * cosDegrees) + (MyVec.Y * sinDegrees);
            double y = (MyVec.X * -sinDegrees) + (MyVec.Y * cosDegrees);

            return new Vector3(x, y, MyVec.Z);
        }

        public static Vector3 Translate(Vector3 MyVec, Vector3 OldVec, Vector3 NewVec)
        {
            //Moves a 3D point based on a moved reference point
            Vector3 difference = new Vector3(NewVec.X - OldVec.X, NewVec.Y - OldVec.Y, NewVec.Z - OldVec.Z);
            MyVec.X += difference.X;
            MyVec.Y += difference.Y;
            MyVec.Z += difference.Z;
            return MyVec;
        }

        //These are to make the above functions workable with arrays of 3D points
        public static Vector3[] RotateX(Vector3[] MyVecArray, double degrees)
        {
            for (int i = 0; i < MyVecArray.Length; i++)
            {
                MyVecArray[i] = RotateX(MyVecArray[i], degrees);
            }
            return MyVecArray;
        }

        public static Vector3[] RotateY(Vector3[] MyVecArray, double degrees)
        {
            for (int i = 0; i < MyVecArray.Length; i++)
            {
                MyVecArray[i] = RotateY(MyVecArray[i], degrees);
            }
            return MyVecArray;
        }

        public static Vector3[] RotateZ(Vector3[] MyVecArray, double degrees)
        {
            for (int i = 0; i < MyVecArray.Length; i++)
            {
                MyVecArray[i] = RotateZ(MyVecArray[i], degrees);
            }
            return MyVecArray;
        }

        public static Vector3[] Translate(Vector3[] MyVecArray, Vector3 OldVec, Vector3 NewVec)
        {
            for (int i = 0; i < MyVecArray.Length; i++)
            {
                MyVecArray[i] = Translate(MyVecArray[i], OldVec, NewVec);
            }
            return MyVecArray;
        }

    }

    internal class Cube
    {
        public Color Color = Color.Black;

        public int X = 0;
        public int Y = 0;
        public int Z = 0;

        double xRotation = 0.0;
        double yRotation = 0.0;
        double zRotation = 0.0;

        Math3D.Camera Camera = new Math3D.Camera();
        Math3D.Vector3 CubeCenter;

        public double RotateX
        {
            get { return xRotation; }
            set { xRotation = value; }
        }

        public double RotateY
        {
            get { return yRotation; }
            set { yRotation = value; }
        }

        public double RotateZ
        {
            get { return zRotation; }
            set { zRotation = value; }
        }

        public Cube(int side)
        {
            X = side;
            Y = side;
            Z = side;
            CubeCenter = new Math3D.Vector3(X / 2, Y / 2, Z / 2);
        }

        public Cube(int side, Math3D.Vector3 origin)
        {
            X = side;
            Y = side;
            Z = side;
            CubeCenter = origin;
        }

        public Cube(int Width, int Height, int Depth)
        {
            X = Width;
            Y = Height;
            Z = Depth;
            CubeCenter = new Math3D.Vector3(X / 2, Y / 2, Z / 2);
        }

        public Cube(int Width, int Height, int Depth, Math3D.Vector3 origin)
        {
            X = Width;
            Y = Height;
            Z = Depth;
            CubeCenter = origin;
        }

        //Finds the othermost points. Used so when the cube is drawn on a bitmap,
        //the bitmap will be the correct size
        public static Rectangle getBounds(PointF[] points)
        {
            double left = points[0].X;
            double right = points[0].X;
            double top = points[0].Y;
            double bottom = points[0].Y;
            for (int i = 1; i < points.Length; i++)
            {
                if (points[i].X < left)
                    left = points[i].X;
                if (points[i].X > right)
                    right = points[i].X;
                if (points[i].Y < top)
                    top = points[i].Y;
                if (points[i].Y > bottom)
                    bottom = points[i].Y;
            }

            return new Rectangle(0, 0, (int)Math.Round(right - left), (int)Math.Round(bottom - top));
        }

        public Bitmap drawCube(Point drawOrigin)
        {
            //FRONT FACE
            //Top Left - 7
            //Top Right - 4
            //Bottom Left - 6
            //Bottom Right - 5

            //Vars
            PointF[] MyVec = new PointF[24]; //Will be actual 2D drawing points
            Point TempCenter = new Point(0, 0);

            Math3D.Vector3 point0 = new Math3D.Vector3(0, 0, 0); //Used for reference

            //Zoom factor is set with the monitor width to keep the cube from being distorted
            double zoom = (double)Screen.PrimaryScreen.Bounds.Width / 1.5;

            //Set up the cube
            Math3D.Vector3[] CubeCorners = fillCubeVertices(X, Y, Z);

            //Calculate the camera Z position to stay constant despite rotation            
            Math3D.Vector3 anchorPoint = (Math3D.Vector3)CubeCorners[4]; //anchor point
            double cameraZ = -(((anchorPoint.X - CubeCenter.X) * zoom) / CubeCenter.X) + anchorPoint.Z;
            Camera.Position = new Math3D.Vector3(CubeCenter.X, CubeCenter.Y, cameraZ);

            //Apply Rotations, moving the cube to a corner then back to middle
            CubeCorners = Math3D.Translate(CubeCorners, CubeCenter, point0);
            CubeCorners = Math3D.RotateX(CubeCorners, xRotation); //The order of these
            CubeCorners = Math3D.RotateY(CubeCorners, yRotation); //rotations is the source
            CubeCorners = Math3D.RotateZ(CubeCorners, zRotation); //of Gimbal Lock
            CubeCorners = Math3D.Translate(CubeCorners, point0, CubeCenter);

            //Convert 3D Points to 2D
            Math3D.Vector3 CurrentVec;
            for (int i = 0; i < MyVec.Length; i++)
            {
                CurrentVec = CubeCorners[i];
                if (CurrentVec.Z - Camera.Position.Z >= 0)
                {
                    MyVec[i].X = (int)((double)-(CurrentVec.X - Camera.Position.X) / (-0.1f) * zoom) + drawOrigin.X;
                    MyVec[i].Y = (int)((double)(CurrentVec.Y - Camera.Position.Y) / (-0.1f) * zoom) + drawOrigin.Y;
                }
                else
                {
                    TempCenter.X = (int)((double)(CubeCenter.X - Camera.Position.X) / (double)(CubeCenter.Z - Camera.Position.Z) * zoom) + drawOrigin.X;
                    TempCenter.Y = (int)((double)-(CubeCenter.Y - Camera.Position.Y) / (double)(CubeCenter.Z - Camera.Position.Z) * zoom) + drawOrigin.Y;

                    MyVec[i].X = (float)((CurrentVec.X - Camera.Position.X) / (CurrentVec.Z - Camera.Position.Z) * zoom + drawOrigin.X);
                    MyVec[i].Y = (float)(-(CurrentVec.Y - Camera.Position.Y) / (CurrentVec.Z - Camera.Position.Z) * zoom + drawOrigin.Y);

                    MyVec[i].X = (int)MyVec[i].X;
                    MyVec[i].Y = (int)MyVec[i].Y;
                }
            }

            //Now to plot out the points
            Rectangle bounds = getBounds(MyVec);
            bounds.Width += drawOrigin.X;
            bounds.Height += drawOrigin.Y;

            Bitmap tmpBmp = new Bitmap(bounds.Width, bounds.Height);
            Graphics g = Graphics.FromImage(tmpBmp);
            Pen pen = new Pen(this.Color);
            //Back Face
            g.DrawLine(pen, MyVec[0], MyVec[1]);
            g.DrawLine(pen, MyVec[1], MyVec[2]);
            g.DrawLine(pen, MyVec[2], MyVec[3]);
            g.DrawLine(pen, MyVec[3], MyVec[0]);

            //Front Face
            g.DrawLine(pen, MyVec[4], MyVec[5]);
            g.DrawLine(pen, MyVec[5], MyVec[6]);
            g.DrawLine(pen, MyVec[6], MyVec[7]);
            g.DrawLine(pen, MyVec[7], MyVec[4]);

            //Right Face
            g.DrawLine(pen, MyVec[8], MyVec[9]);
            g.DrawLine(pen, MyVec[9], MyVec[10]);
            g.DrawLine(pen, MyVec[10], MyVec[11]);
            g.DrawLine(pen, MyVec[11], MyVec[8]);

            //Left Face
            g.DrawLine(pen, MyVec[12], MyVec[13]);
            g.DrawLine(pen, MyVec[13], MyVec[14]);
            g.DrawLine(pen, MyVec[14], MyVec[15]);
            g.DrawLine(pen, MyVec[15], MyVec[12]);

            //Bottom Face
            g.DrawLine(pen, MyVec[16], MyVec[17]);
            g.DrawLine(pen, MyVec[17], MyVec[18]);
            g.DrawLine(pen, MyVec[18], MyVec[19]);
            g.DrawLine(pen, MyVec[19], MyVec[16]);

            //Top Face
            g.DrawLine(pen, MyVec[20], MyVec[21]);
            g.DrawLine(pen, MyVec[21], MyVec[22]);
            g.DrawLine(pen, MyVec[22], MyVec[23]);
            g.DrawLine(pen, MyVec[23], MyVec[20]);

            g.Dispose(); //Clean-up

            return tmpBmp;
        }

        public static Math3D.Vector3[] fillCubeVertices(int width, int height, int depth)
        {
            Math3D.Vector3[] verts = new Math3D.Vector3[24];

            //front face
            verts[0] = new Math3D.Vector3(0, 0, 0);
            verts[1] = new Math3D.Vector3(0, height, 0);
            verts[2] = new Math3D.Vector3(width, height, 0);
            verts[3] = new Math3D.Vector3(width, 0, 0);

            //back face
            verts[4] = new Math3D.Vector3(0, 0, depth);
            verts[5] = new Math3D.Vector3(0, height, depth);
            verts[6] = new Math3D.Vector3(width, height, depth);
            verts[7] = new Math3D.Vector3(width, 0, depth);

            //left face
            verts[8] = new Math3D.Vector3(0, 0, 0);
            verts[9] = new Math3D.Vector3(0, 0, depth);
            verts[10] = new Math3D.Vector3(0, height, depth);
            verts[11] = new Math3D.Vector3(0, height, 0);

            //right face
            verts[12] = new Math3D.Vector3(width, 0, 0);
            verts[13] = new Math3D.Vector3(width, 0, depth);
            verts[14] = new Math3D.Vector3(width, height, depth);
            verts[15] = new Math3D.Vector3(width, height, 0);

            //top face
            verts[16] = new Math3D.Vector3(0, height, 0);
            verts[17] = new Math3D.Vector3(0, height, depth);
            verts[18] = new Math3D.Vector3(width, height, depth);
            verts[19] = new Math3D.Vector3(width, height, 0);

            //bottom face
            verts[20] = new Math3D.Vector3(0, 0, 0);
            verts[21] = new Math3D.Vector3(0, 0, depth);
            verts[22] = new Math3D.Vector3(width, 0, depth);
            verts[23] = new Math3D.Vector3(width, 0, 0);

            return verts;
        }
    }
}