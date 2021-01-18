using UnityEngine;

public class FruitSalad : MonoBehaviour {
    private void Start() {
        Debug.Log("Creating the fruit");
        Fruit fruit = new Fruit();

        Debug.Log("Creating the apple");
        Apple apple = new Apple();
        

        fruit.SayHello();
        fruit.Chop();

        apple.SayHello();
        apple.Chop();
        

        Debug.Log("Creating the Fruit");
        fruit = new Fruit("yellow");
        Debug.Log("Creating the Apple");
        apple = new Apple("green");
        

        fruit.SayHello();
        fruit.Chop();
        
        apple.SayHello();
        apple.Chop();
    }
}