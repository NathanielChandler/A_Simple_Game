using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

    public float speed = 1.0F;
    private float startTime;
    private float journeyLength;
    private Transform swordTransform;
    public GameObject Sword;
    
    void Start()
    {
        startTime = Time.time;
        swordTransform = Sword.transform;
        journeyLength = Vector3.Distance(swordTransform.position, new Vector3(1, 0, 1));
        
    }
    
    void FixedUpdate()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        Vector3 swordGoTo = new Vector3(swordTransform.localPosition.x + 1, swordTransform.localPosition.y, swordTransform.localPosition.z);
        swordTransform.position = Vector3.Lerp(swordTransform.localPosition, swordGoTo, fracJourney);
    }
    
    
}
