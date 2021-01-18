using UnityEngine;

namespace UnityPolymorphism
{

    public class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("1st Apple Constructor Called");
        }

        public new void Chop()
        {
            Debug.Log("The apple has been chopped.");
        }

        public new void SayHello()
        {
            Debug.Log("Hello, I am an apple.");
        }
    }
}