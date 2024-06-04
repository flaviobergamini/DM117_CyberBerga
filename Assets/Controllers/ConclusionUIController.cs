using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConclusionUIController : MonoBehaviour
{
    [SerializeField] Button btnStart;
    [SerializeField] Button btnQuit;

    void Start()
    {
        btnStart.onClick.AddListener(OnClickBtnStart);
        btnQuit.onClick.AddListener(OnClickBtnQuit);
    }

    public void OnClickBtnStart()
    {
        SceneManager.LoadScene("PhaseScene1");
    }

    public void OnClickBtnQuit()
    {
        Application.Quit();
    }
}
