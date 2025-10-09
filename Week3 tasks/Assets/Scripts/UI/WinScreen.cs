using UnityEngine;

public class WinScreen : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            UIManager.instance.WinScreen();
        }
    }
}
