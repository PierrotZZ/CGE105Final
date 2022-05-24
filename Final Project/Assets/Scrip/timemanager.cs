using UnityEngine;
using UnityEngine.UI;

public class timemanager : MonoBehaviour
{

    public float currentTime;
    int roundup;
    public string currentTimetext;
    public Text scoreUI;
    public float speed;
    collsion collsion;

    private void Awake()
    {
        collsion = GameObject.FindObjectOfType<collsion>();
    }
    void Update()
    {
        stopwatch();
        collsion.healthbar(ref speed, currentTimetext);
    }

    public void stopwatch()
    {        
        roundup = (int)currentTime;
        currentTime += Time.deltaTime * speed;
        currentTimetext = roundup.ToString();
        scoreUI.text = currentTimetext;       
    }
}

