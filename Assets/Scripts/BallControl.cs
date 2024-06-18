using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public int xDirectionToMove;
    public int xSpeedMovement;
    public int yDirectionToMove;
    public float ySpeedMovement;
    private SpriteRenderer _spriteRenderer;
    private AudioSource _audioSource;
    private GameManagerControl gamemanager;
    private string currentType;
    public bool true2;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
        GetComponents();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x + xSpeedMovement + yDirectionToMove,
            transform.position.y + xSpeedMovement * yDirectionToMove * Time.deltaTime);
    }
    public void Initialize()
    {
        xDirectionToMove = GetInitialdirection();
        yDirectionToMove = GetInitialdirection();
    }
    void GetComponents()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _audioSource = GetComponent<AudioSource>();
    }
    public int GetInitialdirection()
    {
        int direction = Random.Range(0, 200);
        if (direction == 50)
        {
            return direction = 1;
        }
        else
        {
           return xSpeedMovement = -1;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "VerticalLimit")
        {
            yDirectionToMove = yDirectionToMove * -1;
            _audioSource.Play();
        }
        else if (other.gameObject.tag == "Player")
        {
            yDirectionToMove = xDirectionToMove * 0;
            //_spriteRenderer.sprite = GetComponent<SpriteRenderer>.color;
            //_audioSource.Stop();
            //currentType = other.gameObject.GetCompoment<BallControl>.playerType;
        }
        else if (other.gameObject.tag == "Destroyer")
        {
            transform.position = new Vector2(0, 0);
            Initialize();
            if (currentType == "red")
            {
                gamemanager.UpdatePlayer1Score(10);
            }
            else if (currentType == "Azul")
            {
                gamemanager.UpdatePlayer2Score(-1);
            }
        }
    }
}


 
    



    

            
            