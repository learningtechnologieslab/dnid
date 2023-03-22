using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienController : MonoBehaviour
{
    public float speed;
    public float startBound, endBound;

    
    void Update()
    {
        Vector2 newPos = new Vector2(
            gameObject.transform.position.x + speed,
            gameObject.transform.position.y);

        if(newPos.x >= endBound || newPos.x <= startBound)
        {
            speed = speed * (-1);
        }

        gameObject.transform.position = newPos;
    }
}
