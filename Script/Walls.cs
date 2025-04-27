using UnityEngine;
using UnityEngine.SceneManagement;

public class WallsOut : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
