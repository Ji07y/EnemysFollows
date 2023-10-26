using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollow : MonoBehaviour

{

    public NavMeshAgent myEnemy;
    public Transform myPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        myEnemy.SetDestination(myPlayer.position);
        
    }
}
