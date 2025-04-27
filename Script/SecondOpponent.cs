using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondOpponent : MonoBehaviour
{
    public int hitCount = 0;
    public int hitsToDestroy = 3;
    public int nextSceneIndex = 0;
    public int curentSceneIndex = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hitCount++;

            if (hitCount >= hitsToDestroy)
            {
                Destroy(gameObject);

               
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }
}
