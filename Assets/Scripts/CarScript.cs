using UnityEditor;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public Rigidbody2D fireballRB;
    public float speed = 5f;
    public float destroyTimer = 5f;

    void Start()
    {
        fireballRB.linearVelocity = transform.right * speed;
        Destroy(gameObject, destroyTimer);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player hit by car!");
            FindObjectOfType<GameManager>().GameOver();
            Destroy(other.gameObject); // or call a custom player death method here
        }
    }
}

    
