using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.bs23.ss2.packageDemo
{
    /// <summary>
    /// Just for demoing that a script works from a package
    /// </summary>
    public class SpinTest : MonoBehaviour
    {
        public float rotationSpeed = 100;

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }
}
