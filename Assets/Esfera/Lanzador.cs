using UnityEngine;
using System.Collections;

public class Lanzador : MonoBehaviour {
    public GameObject Prefab;
    public Transform lanzador;
    // Use this for initialization
    void Start () {
        Prefab = Resources.Load("Sphere") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Sphere = Instantiate(Prefab) as GameObject;
            Sphere.transform.position = transform.position + lanzador.transform.forward * 2;
            Rigidbody rb = Sphere.GetComponent<Rigidbody>();
            rb.velocity = lanzador.transform.forward * 40;
        }
    }
}
