using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerCoinCollector player =
            other.GetComponent<PlayerCoinCollector>();

        if(player != null)
        {
            player.CollectCoin();
            Destroy(gameObject);
        }
    }
}