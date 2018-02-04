using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodGeneration : MonoBehaviour {

    public float XSize = 8.8f;

    public float ZSize = 8.8f;

    public Vector3 currentPosition;

    public GameObject foodPrefab;

    public GameObject currentFood;

	// Use this for initialization
	void Start () {
                
	}

    void AddNewFood() {

        RandomPosition();
        currentFood = GameObject.Instantiate(foodPrefab, currentPosition, Quaternion.Euler(0,45,45));
    }

    void RandomPosition () {
        currentPosition = new Vector3(Random.Range(XSize * -1, XSize),0.5f, Random.Range(ZSize * -1, ZSize));
    }
	
	// Update is called once per frame
	void Update () {

        if (!currentFood)
        {
            AddNewFood();
        }
        else {
            return;
        }
	}
}
