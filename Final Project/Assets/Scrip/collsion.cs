using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collsion : MonoBehaviour
{
    public Text healthUI;
    public GameObject gameoverUI;
    [SerializeField] int health;
    string healthString;
    public Button gameover;
    float takeinspeed;
    public Text finalscore;
    string finalscoreString;
    public Button quitbutton;
    public GameObject Woods;
    public PlayerControl BaseControl;




    private void Start()
    {
        gameover.gameObject.SetActive(false);   
        gameoverUI.gameObject.SetActive(false);
        finalscore.gameObject.SetActive(false);
        quitbutton.gameObject.SetActive(false);
        Woods.gameObject.SetActive(false);

    }
    private void Update()
    {
        healthbar( ref takeinspeed, finalscoreString);
    
    }
    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "rain")
        {
            health = health - 1;
            if (health <= 0)
            {
                health = 0;
            }
        }
    }

   public void healthbar( ref float speed,string currentTimetext)
    {
        finalscoreString = currentTimetext; 
        healthString = health.ToString();
        healthUI.text = healthString;
        finalscore.text = finalscoreString;
        if (health <= 0)
        {
            speed = 0;
            gameover.gameObject.SetActive(true);
            gameoverUI.gameObject.SetActive(true);
            finalscore.gameObject.SetActive(true);
            quitbutton.gameObject.SetActive(true);
            Woods.gameObject.SetActive(true);
            BaseControl.enabled = false;
        }
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void getout()
    {
        Application.Quit();
    }
    

    
}
