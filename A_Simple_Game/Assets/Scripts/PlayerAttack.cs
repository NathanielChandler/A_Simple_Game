using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public float swingTime;

    private bool leftClick;
    private Animator attackAnim;
    private float timer;
    private PlayerMovement playerMovement;
    private float defaultMoveMod;
    private float defaultTurnSpeed;

    void Start()
    {
        attackAnim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        // leftClick = attackAnim.GetBool("LeftClick");
        defaultMoveMod = playerMovement.moveMod;
        defaultTurnSpeed = playerMovement.turnSpeed;
    }


    void FixedUpdate()
    {
        timer += Time.deltaTime;
        if(Input.GetMouseButtonDown(0) && timer >= swingTime)
        {
            timer = 0;
           // leftClick = true;
           // attackAnim.SetBool("LeftClick", leftClick);
            attackAnim.SetTrigger("LeftClicked");
            playerMovement.turnSpeed = 1;
            playerMovement.moveMod = 1;
            
        }
        if(timer >= 1)
        {
            playerMovement.turnSpeed = defaultTurnSpeed;
            playerMovement.moveMod = defaultMoveMod;
        }
    }
}
