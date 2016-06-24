using UnityEngine;
using System.Collections;

public class EsferaColl : MonoBehaviour
{
   // public Transform explosionPrefab;
    public GameObject miluzChoca;
    public Transform SpawnPoint;
    public AudioSource miFuenteSonido;
    public AudioClip miCampana;
    public GameObject miEsfera;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Golpeo suelo");
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(-Vector3.forward, contact.normal);
        //Vector3 pos = contact.point;
        //Instantiate(explosionPrefab, pos, rot);
        Instantiate(miluzChoca, SpawnPoint.position, rot);
        miFuenteSonido.PlayOneShot(miCampana, 1);
        Invoke("Autodestruir",6);
    }

    public void Autodestruir()
    {
        Destroy(miEsfera);
    }
}
