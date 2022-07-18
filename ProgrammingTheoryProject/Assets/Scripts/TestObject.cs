using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inheritance;
using Polymorphism;
using Encapsulation;

public class TestObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("======================");
        Debug.Log("Inheritance");
        Debug.Log("======================");

        var car = new Car();
        var openCar = new OpenCar();
        var van = new Van();

        car.Drive();

        openCar.Drive();
        openCar.OpenCeiling();

        van.Drive();
        van.PutLuggage("Ice box");

        
        Debug.Log("======================");
        Debug.Log("Polymophism");
        Debug.Log("======================");

        var animal = new Animal();
        var dog = new Dog();
        var cat = new Cat();

        animal.Cry();
        dog.Cry();
        cat.Cry();

        Debug.Log("======================");
        Debug.Log("Encapsulation");
        Debug.Log("======================");

        var capusuleObject = new CapsuledObject();

        // capusuleObject.name = "newName" // can't access
        capusuleObject.ChangeName("newName");
        Debug.Log($"capsule name is {capusuleObject.name}");



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
