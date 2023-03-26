using System.Collections;
using UnityEngine;


public class ScriptForObject : MonoBehaviour
{
    
    public float speed;

    private string text;

    public string Text 
    {
        get 
        {
            return text;
        }

        set {
            text = value;
            gameObject.GetComponentInChildren<UnityEngine.UI.Text>().text = text;
        }
    }
    void Start()
    {
        StartCoroutine(waiter());
    }

    void Update()
    {
        
        
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);

        speed = 0;

        yield return new WaitForSeconds(3);

        speed = 4;
    }





}