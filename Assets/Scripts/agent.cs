using UnityEngine;
using System.Collections;

public class agent : MonoBehaviour {


    public Transform target;
    private NavMeshAgent agnte;
	// Use this for initialization
	void Start () {
        agnte = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
        agnte.SetDestination(target.position);
	}
}
