using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessibilityModifiers8523
{
    // private - protected - internal - public
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            //customer. // alan,özellik ve methodlar private olduğundan ulaşılamaz
            GoodCustomer goodCustomer = new GoodCustomer();
            //goodCustomer. // alan,özellik ve methodlara base class private olduğundan ulaşılamaz
            Person person = new Person();
            //person. // alan,özellik ve methodlara private veya protected olduğundan ulaşılamaz
            Animal animal = new Animal();
            animal.id1_internal = 1;
            animal.Id1_internal = 1;
            animal.SetAnimal();
            Vehicle vehicle = new Vehicle();
            vehicle.id1_puclic = 1;
            vehicle.Id1_public = 1;
            vehicle.Drive();
        }
    }
    #region Private Accessibility Modifier
    class Customer
    {
        int id1_private;
        private int id2_private;

        private int Id4_private { get; set; }

        void Shop() // private
        {
            id1_private = 1;
            id2_private = 2;
            Id4_private = 4;
            int id3_local;
            id3_local = 3;
        }
        private void Pay() 
        {
            id1_private = 1;
            id2_private = 2;
            Id4_private = 4;
            //id3_local = 3; // KULLANILAMAZ
        }
    }
    class GoodCustomer : Customer 
    { 
    
    }
    #endregion

    #region Protected Accessibilit Modifier
    class Person 
    {
        protected int id1_protected;
        protected int Id1_protected { get; set; }

        private int id2_private;

        private void Work()
        {
            id1_protected = 1;
            Id1_protected = 1;
            id2_private = 2;
        }
        protected void PersonWork() 
        {
            Work();
        }
    }
    class GoodPerson : Person 
    {
        private void Work()
        {
            id1_protected = 1;
            Id1_protected = 1;
            //id2_private = 2;
            PersonWork();
        }
    }
    #endregion

    #region Internal Accessibility Modifier
    internal class Animal // yazılmazsa default'u internal 
    {
        internal int id1_internal;
        internal int Id1_internal { get; set; }

        internal void SetAnimal() 
        {
            id1_internal = 1;
            Id1_internal = 1;
        }
    }
    class Dog : Animal 
    { 
        void SetTheDog() 
        {
            id1_internal = 1;
            Id1_internal = 1;
            SetAnimal();
        }
    }
    #endregion

    #region Public Accessibility Modifier
    public class Vehicle 
    {
        public int id1_puclic;
        public int Id1_public { get; set; }

        public void Drive() 
        {
            id1_puclic = 1;
            Id1_public = 1;
        }
    }
    public class Car : Vehicle 
    { 
        public void DriveTheCar() 
        {
            id1_puclic = 1;
            Id1_public = 1;
            Drive();
        }
    }
    #endregion
}
