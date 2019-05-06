using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContarMonedas : MonoBehaviour
{
    public int puntuacion = 0;
    public GameObject prefab;

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Moneda"))
        {
            puntuacion += 1;
            Destroy(collision.gameObject);
        } 
        if (puntuacion < 3)
        {
            if (collision.gameObject.CompareTag("X"))
            {
                Destroy(gameObject);
            }
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            GameObject esfera = Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
