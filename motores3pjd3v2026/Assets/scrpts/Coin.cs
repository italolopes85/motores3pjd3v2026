using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCoins playerCoins =
                other.GetComponent<PlayerCoins>();

            if (playerCoins != null)
            {
                playerCoins.CollectCoin();
            }

            Destroy(gameObject);
        }

    [SerializeField] private float rotationSpeed = 100f;

    private void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime, 0, 0);

    }
}
