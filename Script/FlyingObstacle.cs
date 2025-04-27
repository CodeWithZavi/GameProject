using UnityEngine;
using UnityEngine.SceneManagement;

public class FlyingObstacle : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f;

    void Start()
    {
        if (player == null)
        {
            Debug.LogError("Player GameObject is not assigned!");
        }
    }

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
    