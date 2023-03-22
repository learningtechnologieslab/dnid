using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LaserController : MonoBehaviour
{
    public float speed;
    public GameObject score;


    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score");
        Debug.Log(score);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 laserPos = new Vector2(gameObject.transform.position.x,
            gameObject.transform.position.y + speed);
        gameObject.transform.position = laserPos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Debug.Log(collision.gameObject.name);

        /*
         * 
         */
        if(collision.gameObject.tag == "destroy")
        {
            if(collision.gameObject.name.ToLower() == "alien")
            {
                // Destroy the alien
                // int val = int.Parse(score.GetComponent<TMP_InputField>().text);
                // score.GetComponent<TMP_InputField>().text = (val + 1).ToString();
                Destroy(collision.gameObject);
            }
            // Destroy laser itself!
            Destroy(gameObject);
        }
    }
}
