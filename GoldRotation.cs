using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldRotation : MonoBehaviour
{

    private float rotationSpeed = 40f;

    // Update is called once per frame
    void Update()
    {

        this.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
