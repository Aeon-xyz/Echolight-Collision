using UnityEngine;
using System.Collections;

public class LightColl : MonoBehaviour {

    public Light miLuz;
    public float nivelLuz;
    public float aperturaLuz;
    public GameObject miobjLuz;
    
	// Use this for initialization
	void Start () {
        aperturaLuz = 0;
        nivelLuz = 2f;
        miLuz.intensity = nivelLuz;
        miLuz.spotAngle = aperturaLuz;
        InvokeRepeating("desvanecer", 0.6f,0.6f);
        InvokeRepeating("AberturaCreciente", 0.0003f, 0.0003f);
        
    }

    public void desvanecer()
    {
        nivelLuz = nivelLuz - 0.1f;
        miLuz.intensity = nivelLuz;
        
    }

    public void AberturaCreciente()
    {
        aperturaLuz = aperturaLuz + 0.8f;
        miLuz.spotAngle = aperturaLuz;
        if (aperturaLuz > 150)
        {
            Destroy(miobjLuz, 0);
        }
    }
}
