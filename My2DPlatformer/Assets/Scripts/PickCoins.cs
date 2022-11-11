using UnityEngine;

public class PickCoins : MonoBehaviour
{
    private int _countCoins = 0;
    private int _maxCoins = 3;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Coin"))
        {
            Destroy(collider.gameObject);
            _countCoins++;
            Debug.Log(_countCoins + " монет у игрока");

            if (_countCoins == _maxCoins)
            {
                Debug.Log("Вы собрали все монеты!");
            }
        }
    }
}
