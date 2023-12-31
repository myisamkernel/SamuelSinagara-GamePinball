using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperControllerWithColor : MonoBehaviour { 

    public Color color;
    public Collider bola;
    private Renderer renderer;

    public AudioManager audioManager;
    public VFXManager VFXManager;

    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material.color = color;
        Debug.Log(color);
    }

    private void OnCollisionEnter(Collision collision)
    {
        // memastikan yang menabrak adalah bola
        // object harus dari scene ?
        Debug.Log(collision.collider);
        if (collision.collider == bola)
        {
            // kita lakukan debug
            Debug.Log("Kena Bola");
            audioManager.PlaySFX(collision.transform.position);
            VFXManager.PlayVFX(collision.transform.position);
        }
    }
}
