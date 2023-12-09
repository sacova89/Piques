using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject buttonsPanel;
    [SerializeField] private GameObject dosButtonsPanel;
    [SerializeField] private GameObject canvasFooter;

    //public GameObject sprclassicPanel;

    public static bool isPaused;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }


    void Update()
    {

        /**  Condicional: Si se presiona la letra "P", validará si la variable bool 'isPaused' es verdadera o no.
            Si es verdadera, DESPAUSARÁ el juego LLAMANDO A LA FUNCION 'Resume()' que despausa el juego
            Si NO es verdadera, PAUSARÁ el juego LLAMANDO A LA FUNCION 'Pause()' que pausa el juego.    **/

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                Resume();
            }
            else
            {
                Pause();

            }
        }
    }

    void Buttons()
    {
        //buttonsPanel.SetActive(true);
    }

    public void Pause()
    {
        canvasFooter.SetActive(false);
        pauseMenu.SetActive(true);
        //testAnimator.GetComponent<Animator>().Play("Test");
        //Time.unscaledDeltaTime = 0f;
        Time.timeScale = 0f;
        isPaused = true;
        //Invoke ("Buttons", 2f);
        buttonsPanel.SetActive(true);
        dosButtonsPanel.SetActive(false);
    }


    /** FUNCION: Resume o Continuar
     *  DESACTIVA o APAGA el GameObject 'pauseMenu' asignado en el Inspecto
     *  Descongela el tiempo
     *  Le asigna el valor FALSO a la variable booleana isPaused**/
    public void Resume()
    {
        pauseMenu.SetActive(false);
        dosButtonsPanel.SetActive(false);
        canvasFooter.SetActive(true);
        Time.timeScale = 1f;
        isPaused = false;
        
    }

    
    public void Restart()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        isPaused = false;
    }


    public void exitToMenuYes()
    {
        
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        Time.timeScale = 1f;
        isPaused = false;
    }

   public void nextLevel()
    {
        
        SceneManager.LoadScene("Level2", LoadSceneMode.Single);
        Debug.Log("Siguiente Nivel");
        Time.timeScale = 1f;
        isPaused = false;
    }
}
