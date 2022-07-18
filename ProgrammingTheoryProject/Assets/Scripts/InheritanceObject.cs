using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inheritance;

public class InheritanceObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var car = new Car();
        var openCar = new OpenCar();
        var van = new Van();

        car.Drive();

        openCar.Drive();
        openCar.OpenCeiling();

        van.Drive();
        van.PutLuggage("Ice box");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
