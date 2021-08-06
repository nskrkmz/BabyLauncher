using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticalMakerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);
    }
}
