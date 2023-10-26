using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemigoDispara : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform target;

    private float timer = 0.2f;
    private float lastShotTime = 0f;
    private int cont = 0;
    private int vidasPlayer = 5;


    public Transform player;
    
    public TextMeshProUGUI textVidas;
    public TextMeshProUGUI textGameOver;

    private void Start()
    {

        textVidas.text = "Vidas: " + vidasPlayer;
        textGameOver.enabled = false;
    }

    private void Update()
    {

        if (DeberiaDisparar())
        {

            if (cont < 20 && Time.time - lastShotTime >= timer)
            {
                DisparoBalas();
                lastShotTime = Time.time;
            }

        }



    }

    private void DisparoBalas()
    {

        RaycastHit hit;
        Ray myRay = new Ray(transform.position, transform.forward);

        Vector3 targetOrientation = target.position - transform.position;
        Debug.DrawRay(transform.position, targetOrientation, Color.green);


        if (Physics.Raycast(myRay, out hit))
        {

            if (hit.transform.CompareTag("Player"))
            {
                Vector3 origin = transform.position;
                Vector3 destination = player.position;
                Vector3 direction = (destination - origin).normalized;

                GameObject bulletInstance = Instantiate(bulletPrefab, origin, Quaternion.LookRotation(direction));
                Rigidbody bulletRigidbody = bulletInstance.GetComponent<Rigidbody>();

                bulletRigidbody.AddForce(direction * 30, ForceMode.VelocityChange);

                Destroy(bulletInstance, 0.5f);

                vidasPlayer--;
                textVidas.text = "Vidas: " + vidasPlayer;

               if (VidasJugador(vidasPlayer) == "game over")
                {
                    Application.Quit();
                }
                Debug.Log(vidasPlayer);
            }


        }

    }

    private string VidasJugador(int vidasPlayer)
    {
        if (vidasPlayer == 0)
        {
            textGameOver.enabled = true;
            enabled = false;


        }

        return "en juego";
    }


    private bool DeberiaDisparar()
    {

        float distanciaAlJugador = Vector3.Distance(transform.position, player.position);
        return distanciaAlJugador < 30f;
    }


    private void ColisionConJugador(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            vidasPlayer--;
            textVidas.text = "Vidas: " + vidasPlayer;
        }
    }
}
