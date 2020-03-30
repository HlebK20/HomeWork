using System;

namespace task_DEV_4
{

    public struct Point
    {
        float _pointX,
              _pointY,
              _pointZ;
        public Point(float x, float y, float z)
        {

            _pointX =
            _pointY =
            _pointZ = 0;
            PointX = x;
            PointY = y;
            PointZ = z;
        }
        /// <summary>
        /// 
        /// </summary>
        public float PointX
        {
            get { return _pointX; }
            set
            {
                CheckValue(value);
                _pointX = value;
            }
        }
        public float PointY
        {
            get { return _pointY; }
            set
            {
                CheckValue(value);
                _pointY = value;
            }
        }
        public float PointZ
        {
            get { return _pointZ; }
            set
            {
                CheckValue(value);
                _pointZ = value;
            }
        }
        private float CheckValue(float value)
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            return value;

        }
        public override string ToString()
        {
            return _pointX.ToString() + " " + _pointY.ToString() + " " + _pointZ.ToString();
        }
        //public bool Equals(Point p)
        //{
        //    return ((Math.Abs(p.PointX - _pointX) < float.Epsilon ) && (Math.Abs(p.PointY - _pointY) < float.Epsilon) && (Math.Abs(p.PointZ - _pointZ) < float.Epsilon));
        //}
        public float Distance(Point p)
        {
            return (float)(Math.Sqrt(Math.Pow(p.PointX - _pointX, 2) + Math.Pow(p.PointY - _pointY, 2) + Math.Pow(p.PointZ - _pointZ, 2)));
        }
        public override bool Equals(object p)
        {
            try
            {
                if (p.GetType() == typeof(Point))
                    return ((Math.Abs(((Point)p).PointX - _pointX) < float.Epsilon) && (Math.Abs(((Point)p).PointY - _pointY) < float.Epsilon) && (Math.Abs(((Point)p).PointZ - _pointZ) < float.Epsilon));
                return false;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
    }
}
