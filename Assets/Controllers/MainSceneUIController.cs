using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainSceneUIController : MonoBehaviour
{
    [SerializeField] Button btnSingIn;
    [SerializeField] Button btnSingUp;

    [SerializeField] TMP_InputField InputEmail;
    [SerializeField] TMP_InputField InputPassword;

    //IUserService _userService = new UserService(new UserRepository());

    void Start()
    {
        InputPassword.contentType = TMP_InputField.ContentType.Password;

        btnSingIn.onClick.AddListener(OnClickBtnLogin);
    }


    void Update()
    {

    }

    public async void OnClickBtnLogin()
    {
        Debug.Log(InputEmail.text);
        Debug.Log(InputPassword.text);


        //var t = _userService.LoginUserAsync(txtEmail, txtPassword);

        SceneManager.LoadScene("PhaseScene1");
    }
}
