using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public GameObject gameOverPanel;

    public static bool isGameStarted;
    public GameObject startingText;

    public int speed;

    private static string playerName;
    bool alreadyDone = false;

    [SerializeField]
    Events events;
    // Start is called before the first frame update
    void Start()
    {
        speed = 0;

        gameOver = false;
        Time.timeScale = 1;
        isGameStarted = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            if (!alreadyDone)
            {
                events.UnhideGameOverPanel();
                alreadyDone = true;
            }
        }
        StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        if (SwipeManager.tap)
        {
            if (!isGameStarted)
            {
                yield return new WaitForSeconds(1);
                
                isGameStarted = true;

                Destroy(startingText);
            }
        }
    }

    public static string getPlayerName()
    {
        return playerName;
    }

    public static void SetPlayerName(string _playerName)
    {
        playerName = _playerName;
    }
}
