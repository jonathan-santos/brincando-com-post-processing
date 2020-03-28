using UnityEngine;

public class Carro : MonoBehaviour
{
    public float velocidadeMovimento = 30f;
    public float velocidadeRotacao = 150f;

    void Update()
    {
        var praFrente = Input.GetAxis("Vertical") * velocidadeMovimento * Time.deltaTime;
        transform.Translate(0, 0, praFrente);

        var praDireita = Input.GetAxis("Horizontal") * velocidadeRotacao * Time.deltaTime;
        transform.Rotate(0, praDireita, 0);
    }
}
