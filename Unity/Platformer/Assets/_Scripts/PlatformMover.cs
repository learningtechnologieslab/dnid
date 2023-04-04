using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public GameObject platformPrefab;
    List<GameObject> platforms = new List<GameObject>();
    public float delay = 2f;
    public float speed = 0.01f;
    public float spacing = 6f;

    // Start is called before the first frame update
    void Start()
    {
        // CreatePlatform();
        StartCoroutine("SpawnPlatform");
    }

    // Update is called once per frame
    void Update()
    {
        foreach(GameObject p in platforms)
        {
            Move(p);
        }
    }

    IEnumerator SpawnPlatform()
    {
        bool exitCondition = false;
        do
        {
            CreatePlatform();

            yield return new WaitForSeconds(delay);
        }
        while (exitCondition == false);
    }

    void CreatePlatform()
    {
        float x = 10f;
        if(platforms.Count > 0)
        {
            x = platforms[^1].transform.position.x + spacing;
        }

        float y = Random.Range(-4, 0);
        Vector2 newPos = new Vector2(x, y);
        GameObject newPlatform = Instantiate(platformPrefab, newPos, Quaternion.identity);
        platforms.Add(newPlatform);
    }

    void Move(GameObject item)
    {
        Vector2 newItemPos = new Vector2(
            item.transform.position.x - speed,
            item.transform.position.y
            );

        item.transform.position = newItemPos;
    }
}
