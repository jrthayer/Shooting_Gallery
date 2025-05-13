using UnityEngine;

public class flip : MonoBehaviour
{
    private bool flipped = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Flip();
    }

    private void Flip(){
        flipped = !flipped;
        Vector3 vector3 = new(0, flipped ? 0f : 180f, .25f);
        transform.eulerAngles = vector3;
    }
}
