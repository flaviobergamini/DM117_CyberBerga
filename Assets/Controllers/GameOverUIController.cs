using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    [SerializeField] Button btnStartAgain;
    [SerializeField] Button btnQuit;

    void Start()
    {
        btnStartAgain.onClick.AddListener(OnClickBtnStartAgain);
        btnQuit.onClick.AddListener(OnClickBtnQuit);
    }

    public void OnClickBtnStartAgain()
    {
        SceneManager.LoadScene("PhaseScene1");
    }

    public void OnClickBtnQuit()
    {
        Application.Quit();
    }
}