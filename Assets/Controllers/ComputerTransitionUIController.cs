using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ComputerTransitionUIController : MonoBehaviour
{
    [SerializeField] Button btnNextScene;

    void Start()
    {
        btnNextScene.onClick.AddListener(OnClickBtnNextScene);
    }

    void OnClickBtnNextScene()
    {
        SceneManager.LoadScene("PhaseScene2");
    }
}
