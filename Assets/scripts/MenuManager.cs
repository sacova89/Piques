using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] private GameObject blackFade;
    [SerializeField] private GameObject startPanel;
    [SerializeField] private GameObject mainMenuPanel;
    [SerializeField] private GameObject settingsPanel;
    [SerializeField] private GameObject levelsPanel;


    // Start is called before the first frame update
    void Start()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(false);
        levelsPanel.SetActive(false);
        blackFade.SetActive(true);
        startPanel.SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            ChangePanels();
            Debug.Log("ENTER");
        }


    }

    private void ChangePanels()
    {
        blackFade.SetActive(false);
        startPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    private void GoBack()
    {
        mainMenuPanel.SetActive(false);
        startPanel.SetActive(true);

    }

    public void LevelOne()
    {
        SceneManager.LoadScene("Level1", LoadSceneMode.Single);
    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
