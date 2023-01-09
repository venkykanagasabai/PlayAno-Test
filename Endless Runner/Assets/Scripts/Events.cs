using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{
    public Text gameOverText;
    public Button skipSavingScoreBtn;
    public GameObject gameOverPanel;

    public void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }

    private void HideUIElements()
    {
        this.gameOverText.gameObject.SetActive(false);
        this.skipSavingScoreBtn.gameObject.SetActive(false);
    }

    public void UnhideUIElements()
    {
        this.gameOverText.gameObject.SetActive(true);
    }

    public void OnSkipBtnClick()
    {
        this.gameOverPanel.SetActive(true);
    }

    public void UnhideGameOverPanel()
    {
        this.gameOverPanel.SetActive(true);
    }

    public void HideGameOverPanel()
    {
        this.gameOverPanel.SetActive(false);
    }
}
