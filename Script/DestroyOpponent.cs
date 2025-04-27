using UnityEngine;

public class FirstOpponent : MonoBehaviour
{
    public int hitCount = 0;
    public int hitsToDestroy = 3;

    public GameObject newOpponentPrefab;
    public Transform spawnPoint;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hitCount++;

            if (hitCount >= hitsToDestroy)
            {
                Destroy(gameObject);

                // Spawn the second enemy
                if (newOpponentPrefab != null && spawnPoint != null)
                {
                    Instantiate(newOpponentPrefab, spawnPoint.position, Quaternion.identity);
                }
            }
        }
    }
}
