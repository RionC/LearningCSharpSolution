using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xunit;

namespace LearningCSharp
{
    public class VariablesAndDataTypes
    {
        [Fact]
        public void SomeOfTheBuiltInTypes()
        {
            // Type Identifier;
            int age;
            age = 22;
            Int32 yourAge;
            yourAge = 22;
            string name;
            name = "Rion";
            String yourName;
            yourName = "Jeff";

            // Initializing - assigning a value when declaring
            Double pay = 33.22;
            decimal yourPay = 33.22M;

            Boolean isAwake = true;
            bool over = 12 > 13;

            int x;
            x = 0;

            Assert.Equal(0, x);
        }

        // scope
        string Thingy = "Tacos";
        [Fact]
        public void ImplicitlyTypedLocalVariables()
        {
            Assert.Equal("Tacos", Thingy);

            // c# 3.0
            var pay = 33.50M;
            var myName = "Rion";
        }

        [Fact]
        public void ValueTypes()
        {
            // structs
            int age = 52;
            DateTime myBirthday = new DateTime(1992, 7, 22);
            string name = "Jeff";

            DoubleIt(age);
            Assert.Equal(52, age);

            var rover = new Dog();
            rover.Name = "Rover";
            DoSomething(rover);
            Assert.Equal("Fido", rover.Name);
        }

        [Fact]
        public void UsingRefAndOut()
        {
            int y = 50;
            DoubleItRef(ref y);
            Assert.Equal(100, y);

            int p = 100;
            GimmeSomething(out p);
            Assert.Equal(42, p);
        }

        public void DoubleItRef(ref int x)
        {
            x *= 2;
        }

        public void GimmeSomething(out int z)
        {
            z = 42;
        }

        public void DoubleIt(int x)
        {
            x *= 2;
        }

        public void DoSomething(Dog d)
        {
            d.Name = "Fido";
        }

        public void AgeExample()
        {
            Console.Write("What is your age: ");
            string enteredAge = Console.ReadLine();
            int age;

            if (int.TryParse(enteredAge, out age))
            {
                if (age > 20)
                    Console.WriteLine("Old enough");
                else
                    Console.WriteLine("No Admission");
            }
            else
                Console.WriteLine("Enter a number");
        }
    }

    public class Dog
    {
        public string Name;
    }

}
