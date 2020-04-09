using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._1
{
    class DataBase
    {
        List<Car> _data;
        private DataBase()
        {
            _data = new List<Car>();
        }
        public void AddCar(Car car)
        {
            if (car == null)
            {
                throw new ArgumentNullException();
            }    
            _data.Add(car);
        }
    }
}
