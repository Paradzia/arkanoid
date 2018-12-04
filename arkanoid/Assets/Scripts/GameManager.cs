using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject paddle;
    private GameObject clonePaddle;
    public GameObject randomBrick;
    public GameObject deathParticles;
    public ScoreText scoreT;

    public static GameManager instance = null;
    public int score = 0;

    public Vector3 spawnValues;
    public float startWait;
    public float waveWait;
    public float fallingSpeed;
    public List<GameObject> objectList;
    private Boolean generateObjects = true;

    void Start()
    {
        initPrefs();
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        
        
        setup();
        StartCoroutine(SpawnWaves());
    }

    public static GameManager getInstance()
    {
        return instance;
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (generateObjects)
        {
            Vector3 spawnPosition = new Vector3(UnityEngine.Random.Range(-0.6f, 3f), spawnValues.y, spawnValues.z);
            Quaternion spawnRotation = Quaternion.identity;
            objectList.Add(Instantiate(randomBrick, spawnPosition, spawnRotation));
            yield return new WaitForSeconds(waveWait);
        }
    }


    public void setup()
    {
        objectList = new List<GameObject>();
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    private void initPrefs()
    {
        if (!PlayerPrefs.HasKey("lossCounter"))
        {
            PlayerPrefs.SetInt("lossCounter", 1);
        }

        if (!PlayerPrefs.HasKey("highScore"))
        {
            PlayerPrefs.SetInt("highScore", 1);
        }
    }

    private void incrementPlayerPref(string pref)
    {
        var value = PlayerPrefs.GetInt(pref);
        value += 1;
        PlayerPrefs.SetInt(pref, value);
    }

    public void die()
    {
        incrementPlayerPref("lossCounter");
        if (score > PlayerPrefs.GetInt("highScore"))
        {
            PlayerPrefs.SetInt("highScore", score);
        }

        if (PlayerPrefs.GetInt("lossCounter") % 5 == 0)
        {
            Debug.Log("add");
		    AdUtils.showSkipableAd();
        }

        Instantiate(deathParticles, clonePaddle.transform.position, Quaternion.identity);
        Destroy(clonePaddle);
        Invoke("SetupPaddle", 1f);
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    void SetupPaddle()
    {
        clonePaddle = Instantiate(paddle, transform.position, Quaternion.identity) as GameObject;
    }

    public void Update(){
        Debug.Log("PUNKTY"+ score.ToString());
        

    }

   

}