using UnityEngine;

public class Death : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }
}


