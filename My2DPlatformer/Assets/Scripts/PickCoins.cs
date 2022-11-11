using UnityEngine;

public class PickCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
            Destroy(collider.gameObject);
    }
}
