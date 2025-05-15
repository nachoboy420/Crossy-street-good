using UnityEngine;
using UnityEngine.UIElements;

public class CarSpawner : MonoBehaviour
{

    public GameObject[] objectToSpawn; // Assign car or fireball prefab here
    public float spawnInterval = 4f; // Time between spawns
    public Vector2 spawnRangeX = new Vector2(-5f, 5f);
    public float spawnRadius = 1.5f; // Avoids overlap

    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObject", 0f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            // Only spawn if there's nothing already in the way
            Collider2D hit = Physics2D.OverlapCircle(transform.position, spawnRadius);
            if (hit == null)
            {
                int random = Random.Range(0, objectToSpawn.Length);
                Instantiate(objectToSpawn[random], transform.position, transform.rotation);
            }

            timer = 0f; // Reset timer either way
        }
    }

    public void SpawnObject()
        {
            Vector3 spawnPos = transform.position;
            spawnPos.x += Random.Range(spawnRangeX.x, spawnRangeX.y);
            int random = Random.Range(0, objectToSpawn.Length);
            Instantiate(objectToSpawn[random], spawnPos, transform.rotation);
        }
    }


    
