using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace _2eab
{
    class Point
    {
        public double X, Y, Z;
        public double W;
        public Point Vcam;

        public Point(double X, double Y, double Z, double W = 1)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.W = W;
            Vcam = null;
        }

        public Point(String str)
        {
            string[] coordinates = str.Split(' ');
            X = Double.Parse(coordinates[0]);
            Y = Double.Parse(coordinates[1]);
            Z = Double.Parse(coordinates[2]);
            W = 1;
            Vcam = null;
        }

        public Point(System.Drawing.Point point)
        {
            X = point.X;
            Y = point.Y;
            Z = 0;
            W = 1;
            Vcam = null;
        }

        public double getX()
        {
            return X / W;
        }

        public double getY()
        {
            return Y / W;
        }

        public double getZ()
        {
            return Z / W;
        }

        public double length
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y + Z * Z);
            }
        }

        // Векторное произведение на вектор src
        public Point getVectorMult(Point src)
        {
            double x, y, z;
            x = getY() * src.getZ() - getZ() * src.getY();
            y = getZ() * src.getX() - getX() * src.getZ();
            z = getX() * src.getY() - getY() * src.getX();
            return new Point(x, y, z);
        }

        public Point applyMatrix(Matrix matrix)
        {
            Point result = new Point(0, 0, 0, 0);
            double[] input = { X, Y, Z, W };
            for (int i = 0; i < 4; i++)
            {
                result.X += input[i] * matrix.fields[i, 0];
                result.Y += input[i] * matrix.fields[i, 1];
                result.Z += input[i] * matrix.fields[i, 2];
                result.W += input[i] * matrix.fields[i, 3];
            }
            return result;
        }

        // Находит угол между двумя веторами
        public double findAngle(Point src)
        {
            if (length == 0 || src.length == 0)
                return 0;
            double cos = (getX() * src.getX() + getY() * src.getY() + getZ() * src.getZ()) / (length * src.length);
            return Math.Acos(cos);
        }

        // Считаем координаты точки относительно камеры
        public void rotateForCam(Camera camera)
        {
            Vcam = applyMatrix(camera.toRotate);
        }

        public Point minus(Point src)
        {
            return new Point(getX() - src.getX(), getY() - src.getY(), getZ() - src.getZ());
        }

        public Point scale(double mnozh)
        {
            return new Point(getX() * mnozh, getY() * mnozh, getZ() * mnozh);
        }
    }
}