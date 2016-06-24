using UnityEngine;
using System.Collections;

public class Fuerza : MonoBehaviour {
    public float thrust;
    public Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(-thrust, 0, 0, ForceMode.Impulse);
    }
}

    
