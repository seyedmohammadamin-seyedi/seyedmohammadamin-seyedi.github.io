using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alligator alligato = new Alligator();
            IMosse moose = new Moose();
            Animal baldeagle = new BaldEagle();

            alligato.Move();
            alligato.Eat();

            //moose.Move();
            //moose.Eat();

            baldeagle.Move();
            baldeagle.Eat();


            alligato.numberOfHandsAndFeet = 4;
          //moose.numberOfHandsAndFeet = 4; 
            baldeagle.numberOfHandsAndFeet = 2;

            Console.WriteLine(alligato.numberOfHandsAndFeet);
            Console.WriteLine(alligato._typeofanimal);




            alligato.Hunt();
            moose.Hunt();
          //baldeagle.hunt();
            
           

            Console.ReadLine();

        }

       
        
        
    }


   

    public abstract class Animal
    {
        public Animal(  )
        {
            
        }
        public abstract void Move();

        public abstract void Eat();


       public enum typeofanimal
    {
        crawling = 1,
        Bird = 2,
        mammal = 3
    }


        public virtual typeofanimal _typeofanimal { get; set; }

        public int numberOfHandsAndFeet { get; set; }
    }





    public interface IMosse
    {
        void Hunt();
    }

    public interface IEagle
    {
        void Hunt();
    }

    public interface IAlligator
    {
        void Hunt();

    }



    public class Alligator : Animal, IAlligator
    {

        public override typeofanimal _typeofanimal { get => base._typeofanimal; set => base._typeofanimal = value; }

        public override void Eat()
        {
            Console.WriteLine("The Alligator Eat");
        }

        public  void Hunt()
        {
            Console.WriteLine("The Alligator hunts");
        }

        public override void Move()
        {
            Console.WriteLine("The Alligator Move");
        }



    }

    public class Moose : Animal, IMosse
    {
        public override typeofanimal _typeofanimal { get => base._typeofanimal; set => base._typeofanimal = value; }

        public override void Eat()
        {
            Console.WriteLine("The Mosse Eat");
        }

        public void Hunt()
        {
            Console.WriteLine("The Mosse hunts");
        }

        public override void Move()
        {
            Console.WriteLine("The Mosse Move");
        }


    }

    public class BaldEagle : Animal, IEagle
    {
        public override typeofanimal _typeofanimal { get => base._typeofanimal; set => base._typeofanimal = value; }

        public override void Eat()
        {
            Console.WriteLine("The Eagle Eat");
        }

        public void Hunt()
        {
            Console.WriteLine("The Eagle hunts");
        }

        public override void Move()
        {
            Console.WriteLine("The Eagle Move");
        }
    }



  

}
