using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneUIController : MonoBehaviour
{
    [SerializeField] Button btnStart;
    [SerializeField] Button btnQuit;
    [SerializeField] TMP_InputField InputName;

    void Start()
    {
        btnStart.onClick.AddListener(OnClickBtnStart);
        btnQuit.onClick.AddListener(OnClickBtnQuit);
    }

    private void Update()
    {
        PlayerPrefs.SetString("userName", InputName.text);  
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
