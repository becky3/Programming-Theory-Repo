using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Abstraction 
{
    class AbstractionWorks
    {
        public static void MoveWithLog(GameObject gameObject, Vector3 targetPosition)
        {
            var rigitBody = gameObject.GetComponent<Rigidbody>();

            if (rigitBody == null)
            {
                Debug.Log("have not rigitBody...");
                return;
            }

            var nowPosition = gameObject.transform.position;
            rigitBody.MovePosition(targetPosition);

            Debug.Log($"move from {nowPosition} to {targetPosition}");
        }

    }


}
