using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * speed * Time.deltaTime;
    }
}
