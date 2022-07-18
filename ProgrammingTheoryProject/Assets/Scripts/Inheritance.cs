using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Inheritance
{
    class Car
    {
        public void Drive()
        {
            Debug.Log("driving!");
        }
    }

    class OpenCar : Car
    {
        public void OpenCeiling()
        {
            Debug.Log("See the sky !!");
        }
    }

    class Van : Car
    {
        public void PutLuggage(string item)
        {
            Debug.Log($"Put {item} !!");
        }
    }
}

