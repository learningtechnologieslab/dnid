using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("HERE");
        if(collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
