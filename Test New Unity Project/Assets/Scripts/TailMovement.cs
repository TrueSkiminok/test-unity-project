using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TailMovement : MonoBehaviour {

    public float speed;

    public Vector3 tailTarget;

    public int index;

    public GameObject tailTargetObject;

    public SnakeMovement mainSnake;

    // Use this for initialization
    void Start() {

        mainSnake = GameObject.FindGameObjectWithTag("SnakeMain").GetComponent<SnakeMovement>();
        speed = mainSnake.speed+1.5f;
        tailTargetObject = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        index = mainSnake.tailObjects.IndexOf(gameObject);

    }

    // Update is called once per frame
    void Update() {

        tailTarget = tailTargetObject.transform.position;
        // tailTarget.z -= mainSnake.zOffset;
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position, tailTarget, Time.deltaTime * speed);


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeMain")) {
            if (index > 2) {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }

}