using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colidiu com: " + other.name);

        if (other.CompareTag("Coin"))
        {
            coins++;

            Debug.Log("Collected Coin");
            PlayerObserverManager.NotifyCoinCollected(coins);

            Destroy(other.gameObject);
        }
    }
}