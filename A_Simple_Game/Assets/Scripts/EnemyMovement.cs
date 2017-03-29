using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 

public class EnemyMovement : MonoBehaviour
{

    public GameObject target;
    private Vector3 targetLocation;
    private NavMeshAgent agent;

	void Start ()
    {
        targetLocation = target.transform.localPosition;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = targetLocation;
	}
	
	void FixedUpdate ()
    {
        //file:///C:/Program%20Files/Unity/Editor/Data/Documentation/en/ScriptReference/AI.NavMeshAgent-destination.html
        if (Vector3.Distance(targetLocation, target.transform.position) > 1.0f)
        {
            targetLocation = target.transform.position;
            agent.destination = targetLocation;
        }

    }
}
