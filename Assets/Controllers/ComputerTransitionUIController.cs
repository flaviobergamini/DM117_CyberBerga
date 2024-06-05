using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComputerTransitionUIController : MonoBehaviour
{
    [SerializeField] Button btnNextScene;
    [SerializeField] Button btnQuit;

    void Start()
    {
        btnNextScene.onClick.AddListener(OnClickBtnNextScene);
        btnQuit.onClick.AddListener(OnClickBtnQuit);
    }

    void OnClickBtnNextScene()
    {
        SceneManager.LoadScene("PhaseScene2");
    }

    public void OnClickBtnQuit()
    {
        Application.Quit();
    }
}
