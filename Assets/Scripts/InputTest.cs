using UnityEngine;

public class InputTest : MonoBehaviour
{
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (horizontal != 0 || vertical != 0)
        {
            Debug.Log("Horizontal: " + horizontal + " | Vertical: " + vertical);
        }

        if (Input.GetKeyDown(KeyCode.W)) Debug.Log("W pressed");
        if (Input.GetKeyDown(KeyCode.A)) Debug.Log("A pressed");
        if (Input.GetKeyDown(KeyCode.S)) Debug.Log("S pressed");
        if (Input.GetKeyDown(KeyCode.D)) Debug.Log("D pressed");

        Debug.Log("W: " + Input.GetKey(KeyCode.W));
        Debug.Log("A: " + Input.GetKey(KeyCode.A));
        Debug.Log("S: " + Input.GetKey(KeyCode.S));
        Debug.Log("D: " + Input.GetKey(KeyCode.D));
    }
}
