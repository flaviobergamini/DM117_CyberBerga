using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    [SerializeField] Button btnStartAgain;

    void Start()
    {
        btnStartAgain.onClick.AddListener(OnClickBtnStartAgain);
    }

    public void OnClickBtnStartAgain()
    {
        SceneManager.LoadScene("PhaseScene1");
    }
}