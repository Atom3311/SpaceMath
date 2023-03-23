using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private GameObject[] healthQ;
    private int health = 4;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("fhfik");
        
        health = health - 1;
        if (health == 3)
            Destroy(healthQ[0]);

        if (health == 2)
            Destroy(healthQ[1]);


        if (health == 1)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(0);
        }



    }

}






