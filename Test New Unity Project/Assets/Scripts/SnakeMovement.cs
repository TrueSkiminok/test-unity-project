using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class SnakeMovement : MonoBehaviour {

    public float speed;

    public float rotationSpeed;

    public List<GameObject> tailObjects = new List<GameObject>();

    public float zOffset = 0.01f;

    public GameObject tailPrefab;

    public Text scoreText;

    public int score = 0;

	// Use this for initialization
	void Start () {

        tailObjects.Add(gameObject);

    }
	
	// Update is called once per frame
	void Update () {

        scoreText.text = score.ToString();
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
        }
    }

   public void AddTail()
    {

        score++;
        Vector3 newTailPosition = tailObjects[tailObjects.Count-1].transform.position;
        newTailPosition.z -= zOffset;

        tailObjects.Add(GameObject.Instantiate(tailPrefab, newTailPosition, Quaternion.identity) as GameObject);
    }


}
