using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inheritance;
using Polymorphism;
using Encapsulation;
using Abstraction;

public class TestObject : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    [SerializeField] GameObject cube;

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

        Debug.Log("======================");
        Debug.Log("Abstraction");
        Debug.Log("======================");

        Debug.Log("Move the cube");
        AbstractionWorks.MoveWithLog(cube, new Vector3(5, 5, 5));

        Debug.Log("Move the sphere");
        AbstractionWorks.MoveWithLog(sphere, new Vector3(-5, -5, -5));


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
