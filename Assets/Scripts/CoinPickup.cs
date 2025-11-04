using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip pickupSound;
    private bool wasCollected = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player") && !wasCollected)
        {
            wasCollected = true;
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }
}
