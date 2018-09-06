using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Obstacle : MonoBehaviour {

    // public Obstacle obstacle;
    public EndGame endgame;
    bool over;
    bool game;

    // Use this for initialization
    void Start()
    {
        over = false;
        game = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-2f * Time.deltaTime, 0f, 0f);

        if (over && !game)
        {
            game = true;
            // Gameover            
            EndGame Gameover = Instantiate<EndGame>(endgame);
            // Gameover.transform.localPosition = transform.position;
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("collision");
            over = true;
        }
    }
}
