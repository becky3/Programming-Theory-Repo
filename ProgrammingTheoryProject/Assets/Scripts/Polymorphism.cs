using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Polymorphism
{
    class Animal {

        public virtual void Cry()
        {
            Debug.Log("...");
        }
        
    }

    class Dog : Animal
    {
        public override void Cry()
        {
            Debug.Log("Bow wow!");
        }
    }

    class Cat : Animal
    {
        public override void Cry()
        {
            Debug.Log("Mew mew!");
        }
    }
}
