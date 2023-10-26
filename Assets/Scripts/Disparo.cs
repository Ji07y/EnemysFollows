using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject bulletPrefab;
    private float timer = 2f; // Temporizador de 2 segundos
    private float lastShotTime = 0f; // Guarda el tiempo del último disparo
    private int cont = 0;

    // Update is called once per frame
    void Update()
    {
        if (cont < 20 && Time.time - lastShotTime >= timer)
        {
            DispararBala();
            lastShotTime = Time.time; // Actualiza el tiempo del último disparo
        }
    }

    private void DispararBala()
    {
        // Instancia el prefabricado del proyectil
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        // Obtiene el componente Rigidbody del proyectil
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // Aplica una fuerza hacia adelante al proyectil
        bulletRigidbody.AddForce(transform.forward * 30, ForceMode.VelocityChange);

        cont++;
    }
}
