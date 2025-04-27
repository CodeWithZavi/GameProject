using UnityEngine;
using UnityEngine.SceneManagement;

public class RotatingScript : MonoBehaviour
{
    public float rotationSpeed = 100f;

    void Update()
    {
        // Rotate around Y-axis, in local space
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0, Space.Self);
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
