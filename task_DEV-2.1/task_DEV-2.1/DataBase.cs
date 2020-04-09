using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Xml.Linq;

namespace task_DEV_2._1
{
    class DataBase
    {
        static XDocument _dataBase;
        static DataBase _instance;
        public event EventHandler<TaskDoneEventArgs> TaskDone;
        private DataBase()
        {
            _dataBase = new XDocument();
        }
        public static DataBase GetInstance()
        {
            if(_instance == null)
            {
                _instance = new DataBase();
            }
            return _instance;
        }
        public void AddCar(Car car)
        {
            if(car == null)
            {
                throw new ArgumentNullException();
            }    
            var xcars = new XElement("cars");
            var xcar = new XElement("car");
            var xtrademark = new XAttribute("brand", car.TradeMark);
            var xmodel = new XAttribute("model", car.Model);
            var xcost = new XAttribute("cost", car.Cost);
            var xamount = new XAttribute("amount", car.Amount);

            if (_dataBase.Root != null)
            {
                foreach (XElement c in _dataBase.Root.Elements())
                {
                    xcars.Add(c);
                }
            }
            xcar.Add(xtrademark, xmodel, xcost, xamount);
            xcars.Add(xcar);
            _dataBase = new XDocument();
            _dataBase.Add(xcars);
            _dataBase.Save("Cars.xml");
        }
        /// <summary>
        /// Loads database from "cars.xml" file.
        /// </summary>
        public void LoadDatabaseFromXml()
        {
            _dataBase = XDocument.Load("Cars.xml");
        }
        /// <summary>
        /// Creates new database.
        /// </summary>
        public void CreateNewDatabase()
        {
            _dataBase = new XDocument();
        }
        /// <summary>
        /// Calculates average car cost for all cars. Returns data via TaskDone event.
        /// </summary>
        public void CalculateAverageCarСostForAll()
        {
            TaskDone?.Invoke(this, new TaskDoneEventArgs("Average car cost",
                GetAverageCarCost(AlwaysTrueCheck, string.Empty).ToString()));   // We need to put something here for delegate to work.
        }
        /// <summary>
        /// Calculates average car cost by brand. Returns data via TaskDone event.
        /// </summary>
        /// <param name="brand">Brand which needs average cost calculation</param>
        public void CalculateAverageCarCostByType(string brand)
        {
            TaskDone?.Invoke(this, new TaskDoneEventArgs("Average car cost for selected trademark",
                GetAverageCarCost(CorrectTradeMarkCheck, brand.ToLower()).ToString()));
        }
        /// <summary>
        /// Counts total amount of cars. Returns data via TaskDone event.
        /// </summary>
        public void CountAll()
        {
            XDocumentRootNullCheck();
            int totalamount = 0;
            foreach (XElement car in _dataBase.Root.Elements())
            {
                totalamount += Convert.ToInt32(car.Attribute("amount").Value);
            }
            TaskDone?.Invoke(this, new TaskDoneEventArgs("Total amount of cars", totalamount.ToString()));
        }
        /// <summary>
        /// Counts how many different types there are. Returns data via TaskDone event.
        /// </summary>
        public void CountTypes()
        {
            XDocumentRootNullCheck();
            List<string> brands = new List<string>();
            foreach (XElement car in _dataBase.Root.Elements())
            {
                brands.Add(car.Attribute("brand").Value);
            }
            TaskDone?.Invoke(this, new TaskDoneEventArgs("Total amount of trademarks: ", brands.Distinct().Count().ToString()));
        }
        /// <summary>
        /// Calculates average car cost
        /// </summary>
        /// <param name="ConditionChecking">Comparing condition</param>
        /// <param name="brand">Brand</param>
        /// <returns>Average car cost</returns>
        private double GetAverageCarCost(Func<XElement, string, bool> ConditionChecking, string brand)
        {
            XDocumentRootNullCheck();
            double totalcost = 0, totalamount = 0;
            foreach (XElement car in _dataBase.Root.Elements())
            {
                if (ConditionChecking(car, brand))
                {
                    totalamount += Convert.ToInt32(car.Attribute("amount").Value);
                    totalcost += Convert.ToInt32(car.Attribute("cost").Value) 
                        * Convert.ToInt32(car.Attribute("amount").Value);
                }
            }
            return totalcost / totalamount;
        }
        /// <summary>
        /// Checks if car brand equals to brand.
        /// </summary>
        /// <param name="car">Car to check</param>
        /// <param name="brand">Correct brand</param>
        /// <returns>True if equals, false if not</returns>
        private bool CorrectTradeMarkCheck(XElement car, string brand)
        {
            return car.Attribute("brand").Value == brand;
        }
        /// <summary>
        /// Always returns true. Used as delegate method in GetAveragecost.
        /// </summary>
        /// <param name="car"></param>
        /// <param name="brand"></param>
        /// <returns>Always true</returns>
        private bool AlwaysTrueCheck(XElement car, string brand)
        {
            return true;
        }
        private void XDocumentRootNullCheck()
        {
            if (_dataBase.Root == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}

