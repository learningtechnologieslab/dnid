using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipController : MonoBehaviour
{
    public float speed;

    private Vector2 newPos;

    public GameObject laser;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            float newX = gameObject.transform.position.x - speed; 
            float newY = gameObject.transform.position.y;
            newPos = new Vector2(newX, newY);
            gameObject.transform.position = newPos;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            float newX = gameObject.transform.position.x + speed;
            float newY = gameObject.transform.position.y;
            newPos = new Vector2(newX, newY);
            gameObject.transform.position = newPos;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            Instantiate(laser,
                gameObject.transform.position,
                Quaternion.identity);
        }
    }
}
