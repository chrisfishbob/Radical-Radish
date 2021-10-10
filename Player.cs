using UnityEngine;
using UnityEngine.UI;
using EZCameraShake;

public class Player : MonoBehaviour
{
    public Vector2 targetPos;

    public float upIncrement;
    public float downIncrement;
    public float maxHeight;
    public float minHeight;
    public float speed;

    public int health = 3;
    public int playerPosition;

    public GameObject effect;
    public Text healthDisplay;

    public GameObject gameOver;
    public GameObject moveSound;


    private void Update()
    {
        healthDisplay.text = health.ToString();

      if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
    }

    public void MovePlayerUp()
    {
        if (transform.position.y < maxHeight)
        {
            CameraShaker.Instance.ShakeOnce(1.5f, 1.5f, 0.1f, 1f); //Shakes the screen
            Instantiate(moveSound, transform.position, Quaternion.identity); //Sound efx
            targetPos = new Vector2(transform.position.x, transform.position.y + upIncrement); //Determines the target position
            transform.position = targetPos; //Moves to target position
            Instantiate(effect, transform.position, Quaternion.identity); //Particle efx
        }

    }

    public void MovePlayerDown()
    {
        
        if (transform.position.y > minHeight)
        {
            CameraShaker.Instance.ShakeOnce(1f, 1f, 0.1f, 1f); 
            Instantiate(moveSound, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - downIncrement);
            transform.position = targetPos;
            Instantiate(effect, transform.position, Quaternion.identity);
        }       
    }
}
