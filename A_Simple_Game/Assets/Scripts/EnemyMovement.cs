using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    public GameObject destination;
    private Vector3 destinationLocation;
    private Mes

	void Start () {
        destinationLocation = destination.transform.localPosition;
	}
	
	void FixedUpdate () {
    file:///C:/Program%20Files/Unity/Editor/Data/Documentation/en/ScriptReference/AI.NavMeshAgent-destination.html
	}
}
