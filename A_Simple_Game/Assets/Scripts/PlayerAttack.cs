using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
    public int swingTime;
    private bool leftClick;
    private Animator attackAnim;

    void Start()
    {
        attackAnim = GetComponent<Animator>();
       // leftClick = attackAnim.GetBool("LeftClick");
    }


    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
           // leftClick = true;
           // attackAnim.SetBool("LeftClick", leftClick);
            attackAnim.SetTrigger("LeftClicked");
            
        }
    }
}
