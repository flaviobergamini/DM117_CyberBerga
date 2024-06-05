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

    void Update()
    {
        PlayerPrefs.SetString("userName", InputName.text);
    }

    public void OnClickBtnStart()
    {
        SceneManager.LoadScene("FirstPhaseIntrodutionScene");
    }

    public void OnClickBtnQuit()
    {
        Application.Quit();
    }
}