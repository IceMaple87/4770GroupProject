using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public Transform player;
    public Sword sword;
    float moveSpeed = 4f;
    int minDist = 2;
    int maxDist = 3;

    float attackDist = 2.5f;

    public Vector3 swordStartPosition;
    public Vector3 swordEndPosition;

    Vector3 currentEulerAngles;

    float swordSwingSpeed = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(player);

        if (Vector3.Distance(transform.position, player.position) >= minDist) {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, player.position) <= attackDist) {
                // Attack player
                Debug.Log("ATTACK");
                sword.performAttack();
            }
        }
    }
}
