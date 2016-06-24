using UnityEngine;
using System.Collections;

public class MovimientosJugador : MonoBehaviour {
    public float speedX = 0.1f;
    public float speedY = 0.1f;
    public float speedZ = 0.1f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(speedX, 0.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(-speedX, 0.0f, 0.0f));
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, speedZ));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0.0f, 0.0f, -speedZ));
        }

    }

}
