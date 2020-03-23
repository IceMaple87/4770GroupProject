using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPacingMovement : MonoBehaviour
{
    public Transform player;
    int moveSpeed = 4;
    int minDist = 3;
    int maxDist = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) >= minDist) {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, player.position) <= maxDist) {
                // Call some type of attack logic 
            }
        }
    }
}
