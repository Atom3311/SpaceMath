using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public void Play() {
        SceneManager.LoadScene(1);
    }

    public void Quite() {
        Application.Quit();
    }
}
