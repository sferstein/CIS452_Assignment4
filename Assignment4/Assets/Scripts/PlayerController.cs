using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent (typeof (CharacterController))]
public class PlayerController : MonoBehaviour
{
    // Note: For some reason adding a rigidbody causes the movement of the player to not work as well if there is no rigidbody.
    // It may be better to disable the rigidbody for testing.

    public Character character;
    public PlayerController playerController;
    public Material[] materials;
    public GameObject barrel;
    public GameObject playerColor;
    private MeshRenderer meshRenderer;
    public GameObject winScreen;
    public GameObject loseScreen;
    public bool isGameLost = false;
    public float playerHealth;
    public float speed;
    private Quaternion rotation;
    private CharacterController controller;
    private Camera camera;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 20;
    public TextMeshProUGUI healthText;

    // Start is called before the first frame update
    void Start()
    {
        playerHealth = 5;
        playerController = GetComponent<PlayerController>();
        controller = GetComponent<CharacterController>();
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerHealth;
        moveMouse();
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
        if(playerController.playerHealth <= 0)
        {
            isGameLost = true;
            Destroy(gameObject);
            loseScreen.gameObject.SetActive(true);
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab.transform, firePoint.transform.position, firePoint.transform.rotation);
    }

    void moveMouse()
    {
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        Vector3 mousePos = Input.mousePosition;
        mousePos = camera.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, camera.transform.position.y - transform.position.y));
        rotation = Quaternion.LookRotation(mousePos - new Vector3(transform.position.x,0,transform.position.z));
        transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, rotation.eulerAngles.y, 500 * Time.deltaTime);

        Vector3 movement = input;
        input *= (Mathf.Abs(input.x) == 1 && Mathf.Abs(input.z) == 1) ? .7f : 1;
        movement *= playerController.speed;
        movement += Vector3.up * -8;
        controller.Move(movement * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyBullet"))
        {
            playerHealth = playerHealth - 1;
        }
    }
}
