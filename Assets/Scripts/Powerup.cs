using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{

    [SerializeField]
    private float _speed = 3.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // acceso al jugador
            Player player = other.GetComponent<Player>();

            if (player != null)
            {
                //Habilitar el tiro triple
                player.TripleShotPowerupOn();


            }

            //Destruir el objeto
            Destroy(this.gameObject);
        }

    }
}

