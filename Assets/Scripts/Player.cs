using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidad;
    public float FuerzaSalto;

    public LayerMask Layers;
    public float DistanciaRayo;
    public Color RayColor;

    private Vector3 Move;
    private Rigidbody Rigidbody;
    private bool Salto;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {    
        Move  = new Vector3(Input.GetAxisRaw("Horizontal"), Rigidbody.velocity.y, Input.GetAxisRaw("Vertical"));
        transform.rotation = Quaternion.Euler(0,0,0);
        Salto = Physics.Raycast(transform.position, Vector3.down, DistanciaRayo, Layers);

        Debug.DrawRay(transform.position, Vector3.down * DistanciaRayo, RayColor);
    }
    void FixedUpdate()
    {
        Rigidbody.velocity = Vector3.Scale(Move, new Vector3(velocidad, 1, velocidad));

        if (Input.GetKeyDown(KeyCode.Space)&&Salto)
        {
            Rigidbody.AddForce(Vector3.up * FuerzaSalto, ForceMode.Impulse);
        }
    }
}
