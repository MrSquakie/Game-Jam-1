using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    private GameObject gO1;
    private HealthSystem playerHealth, gateHealth;
    private WaveSpawner ws;
    public bool win;
    public bool lose;
    void Start()
    {
        win = false;
        lose = false;

    }

    void Update()
    {
        Debug.Log(win);
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>();
        gateHealth = GameObject.FindGameObjectWithTag("Gate").GetComponent<HealthSystem>();
        ws = gO1.GetComponent<WaveSpawner>();
        
        if (ws.wavesComplete == true)
        {
            win = true;
        }

        if(playerHealth.health == 0f || gateHealth.health == 0f)
        {
            lose = true;
        }

        if(win == true)
        {
            SceneManager.LoadScene("WinScene");
        }

        if(lose == true)
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
