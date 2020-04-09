using System;
using System.Collections.Generic;
using System.Text;

namespace task_DEV_2._1
{
    interface ICommand
    {
        void Execute();
    }
    class AveragePriceByTypeCommand : ICommand
    {
        string _brand;
        public string Brand
        {
            get => _brand;
            private set
            {
                CorrectBrandCheck(value);
                _brand = value;
            }
        }
        public AveragePriceByTypeCommand(string brand)
        {
            Brand = brand;
        }
        public void Execute()
        {
            DataBase.GetInstance().CalculateAverageCarCostByType(Brand);
        }
        private void CorrectBrandCheck(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException();
            }
        }
    }
    class AddCarCommand : ICommand
    {
        public Car Car { get; private set; }
        public AddCarCommand(Car car)
        {
            this.Car = car;
        }
        public void Execute()
        {
            DataBase.GetInstance().AddCar(Car);
        }
    }
    class AveragePriceCommand : ICommand
    {
        public AveragePriceCommand() { }
        public void Execute()
        {
            DataBase.GetInstance().CalculateAverageCarСostForAll();
        }
    }
    class CountAllCommand : ICommand
    {
        public CountAllCommand() { }
        public void Execute()
        {
            DataBase.GetInstance().CountAll();
        }
    }
    class CountTypesCommand : ICommand
    {
        public CountTypesCommand() { }
        public void Execute()
        {
            DataBase.GetInstance().CountTypes();
        }
    }
    class ExitCommand : ICommand
    {
        public void Execute()
        {
            Environment.Exit(0);
        }
    }
    class LoadFileCommand : ICommand
    {
        public LoadFileCommand() { }
        public void Execute()
        {
            DataBase.GetInstance().LoadDatabaseFromXml();
        }
    }
    class NewFileCommand : ICommand
    {
        public NewFileCommand() { }
        public void Execute()
        {
            DataBase.GetInstance().CreateNewDatabase();
        }
    }
}
