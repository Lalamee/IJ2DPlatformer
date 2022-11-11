using UnityEngine;
using UnityEngine.UI;

public class PickCoins : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.TryGetComponent(out Coin coin))
            Destroy(collider.gameObject);
    }
}
