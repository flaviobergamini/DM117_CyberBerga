using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneUIController : MonoBehaviour
{
    [SerializeField] Button btnStart;

    [SerializeField] TMP_InputField InputName;

    void Start()
    {
        btnStart.onClick.AddListener(OnClickBtnStart);
    }

    private void Update()
    {
        PlayerPrefs.SetString("userName", InputName.text);
    }

    public async void OnClickBtnStart()
    {
        SceneManager.LoadScene("PhaseScene1");
    }
}
