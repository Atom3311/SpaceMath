using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text mathText;
    [SerializeField] private ScriptForObject planet;
    [SerializeField] private Control2D PlayerScore;
    public GameObject ListSave;
    public GameObject Pause;

    private int randMathCount;
    private string sym = " ";

    public Coroutine spawnPlanetCoroutineObj;

    private Vector2[] positions = new Vector2[] {

        new Vector2(4,8),

        new Vector2(0,8),

        new Vector2(-4,8),


    };

    void Start()
    {
        spawnPlanetCoroutineObj = StartCoroutine(nameof(SpawnPlanetCorounine));


    }

    IEnumerator SpawnPlanetCorounine()
    {
        while (true)
        {
            SpawnPlanet();
            yield return new WaitForSeconds(10);
        }

    }

    public void SpawnPlanet()
    {
        var randInstantiate = Random.Range(0, 3);

        ScriptForObject a = null;

        ScriptForObject b = null;

        ScriptForObject c = null;

        if (randInstantiate == 0)
        {
            a = Instantiate(planet, positions[0], transform.rotation);

            b = Instantiate(planet, positions[1], transform.rotation);

            c = Instantiate(planet, positions[2], transform.rotation);
        }
        else if (randInstantiate == 1)
        {
            a = Instantiate(planet, positions[1], transform.rotation);

            b = Instantiate(planet, positions[0], transform.rotation);

            c = Instantiate(planet, positions[2], transform.rotation);
        }
        else if (randInstantiate == 2)
        {
            a = Instantiate(planet, positions[2], transform.rotation);

            b = Instantiate(planet, positions[0], transform.rotation);

            c = Instantiate(planet, positions[1], transform.rotation);
        }

        a.GetComponent<CircleCollider2D>().isTrigger = true;

        var randMathQ1 = Random.Range(1, 99);

        var randMathQ2 = Random.Range(1, 99);

        var randSym = 0;

        int PlayerScoreInt = PlayerScore.ScoreGet;

        if (PlayerScoreInt >= 100)
        {
            randSym = Random.Range(0, 4);
        }

        else if (PlayerScoreInt >= 75)
        {
            randSym = Random.Range(0, 3);
        }

        else if (PlayerScoreInt >= 25)
        {
            randSym = Random.Range(0, 2);
        }


        if (PlayerScoreInt <= 25)
        {
            randMathQ1 = Random.Range(2, 20);

            randMathQ2 = Random.Range(2, 20);
            if (randSym == 0)
            {
                sym = "+";

                randMathCount = randMathQ1 + randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 1)
            {
                sym = "-";

                randMathCount = randMathQ1 - randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 2)
            {
                sym = "*";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 3)
            {
                sym = "/";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathCount + " " + sym + " " + randMathQ2 + " = ?";

                randMathCount = randMathQ1;
            }
        }
        if (PlayerScoreInt > 25 && PlayerScoreInt <= 50)
        {
            randMathQ1 = Random.Range(10, 51);

            randMathQ2 = Random.Range(10, 51);
            if (randSym == 0)
            {
                sym = "+";

                randMathCount = randMathQ1 + randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 1)
            {
                sym = "-";

                randMathCount = randMathQ1 - randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 2)
            {
                sym = "*";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 3)
            {
                sym = "/";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathCount + " " + sym + " " + randMathQ2 + " = ?";

                randMathCount = randMathQ1;
            }
        }
        if (PlayerScoreInt > 50 && PlayerScoreInt <= 100)
        {
            randMathQ1 = Random.Range(50, 100);

            randMathQ2 = Random.Range(50, 100);
            if (randSym == 0)
            {
                sym = "+";

                randMathCount = randMathQ1 + randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 1)
            {
                sym = "-";

                randMathCount = randMathQ1 - randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 2)
            {
                sym = "*";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 3)
            {
                sym = "/";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathCount + " " + sym + " " + randMathQ2 + " = ?";

                randMathCount = randMathQ1;
            }
        }
        if (PlayerScoreInt > 100 && PlayerScoreInt <= 125)
        {
            randMathQ1 = Random.Range(50, 100);

            randMathQ2 = Random.Range(50, 100);
            if (randSym == 0)
            {
                sym = "+";

                randMathCount = randMathQ1 + randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 1)
            {
                sym = "-";

                randMathCount = randMathQ1 - randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 2)
            {
                sym = "*";

                randMathQ1 = Random.Range(2, 15);
                randMathQ2 = Random.Range(2, 15);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 3)
            {
                sym = "/";

                randMathQ1 = Random.Range(2, 11);
                randMathQ2 = Random.Range(2, 11);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathCount + " " + sym + " " + randMathQ2 + " = ?";

                randMathCount = randMathQ1;
            }
        }
        if (PlayerScoreInt > 125)
        {
            randMathQ1 = Random.Range(100, 200);

            randMathQ2 = Random.Range(100, 200);
            if (randSym == 0)
            {
                sym = "+";

                randMathCount = randMathQ1 + randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 1)
            {
                sym = "-";

                randMathCount = randMathQ1 - randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 2)
            {
                sym = "*";

                randMathQ1 = Random.Range(3, 20);
                randMathQ2 = Random.Range(3, 20);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathQ1 + " " + sym + " " + randMathQ2 + " = ?";
            }
            else if (randSym == 3)
            {
                sym = "/";

                randMathQ1 = Random.Range(3, 20);
                randMathQ2 = Random.Range(3, 20);

                randMathCount = randMathQ1 * randMathQ2;

                mathText.text = randMathCount + " " + sym + " " + randMathQ2 + " = ?";

                randMathCount = randMathQ1;
            }
        }


        var randMathFalsePlus1 = randMathCount + Random.Range(1, 6);

        var randlist1 = Random.Range(0, 4);

        var randMathFalseMinus1 = randMathCount - Random.Range(1, 6);

        var randlist2 = Random.Range(0, 4);

        var randMathFalsePlus2 = randMathCount + Random.Range(1, 6);

        var randMathFalseMinus2 = randMathCount - Random.Range(1, 6);

        List<int> randMath = new List<int>() { randMathFalsePlus1, randMathFalseMinus1, randMathFalsePlus2, randMathFalseMinus2 };

        while (randMath[randlist1] == randMath[randlist2])
        {
            randlist1 = Random.Range(0, 4);

            randMath[randlist1].ToString();
        }

        a.Text = randMathCount.ToString();

        b.Text = randMath[randlist1].ToString();

        c.Text = randMath[randlist2].ToString();

        b.GetComponent<CircleCollider2D>().isTrigger = true;
        c.GetComponent<CircleCollider2D>().isTrigger = true;
        a.GetComponent<CircleCollider2D>().isTrigger = false;

    }

    public void Save()
    {

        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/save.dat");
        Save data = new Save();

        data.ScoreSave = PlayerScore.ScoreGet;


        formatter.Serialize(file, data);
        file.Close();
    }

    public void Load()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Open(Application.persistentDataPath + "/save.dat", FileMode.Open);
        Save data = (Save)formatter.Deserialize(file);
        file.Close();
        PlayerScore.ScoreGet = data.ScoreSave;
        ListSave.SetActive(false);
        Pause.SetActive(true);  

    }

    public void ExitSavesList()
    {
        ListSave.SetActive(false);
        Pause.SetActive(true);

    }
    public void OpenSaveList()
    {
        ListSave.SetActive(true);
        Pause.SetActive(false);
    }

    public void save25()
    {
        PlayerScore.ScoreGet = 25;
        ListSave.SetActive(false);
        Pause.SetActive(true);
    }
    public void save75() 
    {
        PlayerScore.ScoreGet = 75;
        ListSave.SetActive(false);
        Pause.SetActive(true);
    }
    public void save100() 
    {
        PlayerScore.ScoreGet = 100;
        ListSave.SetActive(false);
        Pause.SetActive(true);
    }
}