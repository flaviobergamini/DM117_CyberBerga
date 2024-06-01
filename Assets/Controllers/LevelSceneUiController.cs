using TMPro;
using UnityEngine;

public class LevelSceneUiController : MonoBehaviour
{
    [SerializeField] TMP_Text playerName;
    [SerializeField] HPComponent hPComponent;
    [SerializeField] TMP_Text scoreText;

    public static LevelSceneUiController Instance;

    private int scoreCount;

    public int ScoreCount
    {
        get { return scoreCount; }
        set 
        { 
            scoreCount = value;
            scoreText.text = $"Pontos: {scoreCount}";
        }
    }

    private void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        playerName.text = "Flavio teste";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        hPComponent.TakeDamage(10);
    }
}
