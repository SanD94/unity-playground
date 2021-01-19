using UnityEngine;

namespace UnityPolymorphism
{

    public class Apple : Fruit
    {
        public Apple()
        {
            Debug.Log("1st Apple Constructor Called");
        }

        new public void Chop()
        {
            Debug.Log("The apple has been chopped.");
        }

        new public void SayHello()
        {
            Debug.Log("Hello, I am an apple.");
        }
    }
}