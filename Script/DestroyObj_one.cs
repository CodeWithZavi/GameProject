using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyObj_one : MonoBehaviour
{
    public int hitCount = 0; 
    public int hitsToDestroy = 3; 
    public int currentSeen = 0; 
    public int nextSeen = 0; 

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hitCount++;

            if (hitCount >= hitsToDestroy)
            {
                Destroy(gameObject);
                SceneManager.LoadScene(nextSeen);

            }
           
        }
    }
}
