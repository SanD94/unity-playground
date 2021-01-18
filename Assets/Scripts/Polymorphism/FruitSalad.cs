using UnityEngine;

namespace UnityPolymorphism
{
    public class FruitSalad : MonoBehaviour {
        private void Start() {
            Fruit fruit = new Apple();

            fruit.SayHello();
            fruit.Chop();
            

            Apple apple = (Apple) fruit;
            
            apple.SayHello();
            apple.Chop();
        }
        
    }
    
}