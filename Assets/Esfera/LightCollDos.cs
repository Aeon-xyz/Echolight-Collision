using UnityEngine;
using System.Collections;

public class LightCollDos : MonoBehaviour {

    public Light miLuz;
    public float nivelLuz;
    public float RangoLuz;
    public GameObject miobjLuz;
    // Use this for initialization
    void Start()
    {
        RangoLuz = 0;
        nivelLuz = 2f;
        miLuz.intensity = nivelLuz;
        miLuz.range = RangoLuz;
        InvokeRepeating("desvanecer", 0.1f, 0.1f);
        InvokeRepeating("AberturaCreciente", 0.001f, 0.001f);
    }

    public void desvanecer()
    {
        nivelLuz = nivelLuz - 0.1f;
        miLuz.intensity = nivelLuz;
        if (nivelLuz < 0)
        {
            Destroy(miobjLuz, 0);
        }
    }

    public void AberturaCreciente()
    {
        RangoLuz = RangoLuz + 0.1f;
        miLuz.range = RangoLuz;
        
    }
}
