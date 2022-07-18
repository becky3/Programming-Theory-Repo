using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encapsulation
{
    class CapsuledObject
    {
        public string name { get; private set; }

        public void ChangeName(string name)
        {
            this.name = name;
        }
    }
}
