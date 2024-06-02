using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ConclusionUIController : MonoBehaviour
{
    [SerializeField] Button btnStart;
    void Start()
    {
        btnStart.onClick.AddListener(OnClickBtnStart);
    }

    public void OnClickBtnStart()
    {
        SceneManager.LoadScene("PhaseScene1");
    }
}
