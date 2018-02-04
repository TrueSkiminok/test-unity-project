using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour {

    public float speed;

    public GameObject tailTarget;

    public SnakeMovement mainSnake;

    // Use this for initialization
    void Start () {

        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        speed = mainSnake.speed-0.5f;
        tailTarget = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];

	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(tailTarget.transform);
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

	}
}
