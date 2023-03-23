using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public bool PauseGame;
    public GameObject pauseGameMenu;

    [SerializeField] private Score SpawnPlanet;

    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (PauseGame)
            {
                RESUME();

            }
            else
            {
                PAUSE();
            }
        }

    }
    public void RESUME()
    {
        pauseGameMenu.SetActive(false);
        Time.timeScale = 1;
        PauseGame = false;



        SpawnPlanet.spawnPlanetCoroutineObj = StartCoroutine(nameof(SpawnPlanetCorounine));



    }
    public void PAUSE()
    {
        pauseGameMenu.SetActive(true);
        Time.timeScale = 0;
        PauseGame = true;


   


        var planetsAtScene = GameObject.FindGameObjectsWithTag("Planet");
        var planetsAtSceneLenght = planetsAtScene.Length;
        for (int i = 0; i < planetsAtSceneLenght; i++)
        {
            Destroy(planetsAtScene[i]);
        }

        StopCoroutine(SpawnPlanet.spawnPlanetCoroutineObj);
    }
    public void LOADMENU()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
    IEnumerator SpawnPlanetCorounine()
    {
        while (true)
        {
            SpawnPlanet.SpawnPlanet();
            yield return new WaitForSeconds(10);
        }

    }
}
