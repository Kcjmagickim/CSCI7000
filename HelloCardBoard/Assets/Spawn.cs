using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    int mili;
    float tree;
    public Obstacle obstacle;
    double nextUpdate;
    Vector3 start = new Vector3(3f, 0f, 0f);

    // Use this for initialization
    void Start()
    {
        nextUpdate = 0.5;
    }

// Update is called once per frame
void Update()
    {
        if (Time.time >= nextUpdate)
        {
            tree = Random.Range(1, 3);
            if (tree <= 2.5)
            {
                Obstacle tree = Instantiate<Obstacle>(obstacle);
                // obstacle.transform.position = start;
            }
            // Debug.Log(Time.time + ">=" + nextUpdate);
            nextUpdate = Time.time + 2.5;

        }
    }
}
