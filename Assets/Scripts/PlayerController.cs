using UnityEngine;
using UnityEngine.SceneManagement;
using Articy.Unity;

public class PlayerController : MonoBehaviour
{
    private float speed = 15f;
    private float jumpForce = 25f;
    private bool isGrounded = true;

    private Rigidbody2D playerRB;
    private DialogueManager dialogueManager;
    private ArticyObject availableDialogue;

    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        dialogueManager = FindObjectOfType<DialogueManager>();
    }

    void Update()
    {
        PlayerInteraction();
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    // Simple player movement
    void PlayerMovement()
    {
        // Remove movement control while in dialogue
        if (dialogueManager.DialogueActive)
            return;

        playerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, playerRB.velocity.y);
    }

    // Handle player jumping
    void Jump()
    {
        playerRB.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        isGrounded = false;
    }

    // All interactions and key inputs player can use
    void PlayerInteraction()
    {
        // Key option to start dialogue when near NPC
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (availableDialogue != null)
            {
                Debug.Log("Starting dialogue with: " + availableDialogue.name);
                dialogueManager.StartDialogue(availableDialogue);
            }
            else
            {
                Debug.Log("No available dialogue to start.");
            }
        }

        // Key option to abort dialogue
        if (dialogueManager.DialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Closing dialogue box.");
            dialogueManager.CloseDialogueBox();
        }

        // Key option to reset entire scene
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("Restarting scene.");
            RestartScene();
        }
    }

    // Simple scene restart for testing purposes
    void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Trigger Enter/Exit used to determine if interaction with NPC is possible
    void OnTriggerEnter2D(Collider2D aOther)
    {
        Debug.Log("Entered trigger with: " + aOther.name);

        var articyReferenceComp = aOther.GetComponent<ArticyReference>();
        if (articyReferenceComp != null)
        {
            availableDialogue = articyReferenceComp.reference.GetObject();
            Debug.Log("Available dialogue found: " + availableDialogue.name);
        }
        else
        {
            Debug.Log("ArticyReference component not found on: " + aOther.name);
        }
    }

    void OnTriggerExit2D(Collider2D aOther)
    {
        Debug.Log("Exited trigger with: " + aOther.name);

        if (aOther.GetComponent<ArticyReference>() != null)
        {
            availableDialogue = null;
            Debug.Log("Dialogue availability reset.");
        }
    }

    // Detect when the player lands on the ground
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
