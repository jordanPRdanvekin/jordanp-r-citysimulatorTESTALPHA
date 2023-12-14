using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcionbotones : MonoBehaviour
{
    public GameObject menlat;
    public GameObject meninf;
    public float speed = 1.0f;
    // Start is called before the first frame update
    void Update() //aqui van las lineas del codigo que afectan globalmente y no a un solo boton por ejemplo el raycast
    {
        
    }

    // Update is called once per frame
    public void crear() //controla lo que ocurre al pulsar el boton crear es la variable que activa el modo crear
    //en el modo crear deveria: abrirse un nuevo menu llamado ''menlat'' animandolo hacia la izquierda y esconder el menu llamado ''meninf'' de forma animada hacia abajo el cual se mostrara de nuevo si se activa el togle llamado ''mostrar''
    {
            menlat.SetActive(true);
            meninf.SetActive(false);
    }
    public void camara() //controla lo que ocurre al pulsar el boton camara es variable que activa el modo camara
    //en el modo camara deveria desaparecer el menu ''meninf'' de forma animada siendo arrastrado hacia abajo y poder controlar la camara con el raton y de ser`posible usar wasd para moverse por todo el terreno pudiendo volver atras usando el click derecho saliendo del modo camara
    {
        menlat.SetActive(false);
        meninf.SetActive(false);
        //movimiento de la camara
        if (Input.GetMouseButton(1))
        {
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");
            Vector3 direction = new Vector3(-mouseX, 0, -mouseY);
            Camera.main.transform.Translate(direction * Time.deltaTime * speed);
        }

    }
    public void mostrar () //controla lo que ocurre al activar un toggle llamado mostrar es variable que permite mostrar el menu inferior animandolo hacia arriba para que se muestre
    {
        meninf.SetActive(true);
    }
    public void arbol1 () //controla lo que ocurre al pulsar el boton arbol 1 es la variable que te permite usando un raycast (definido previamente en el codigo antes de los public void) crear el objeto llamado arbol 1 en el terreno del juego siempre que haya espacio.
    {

    }
    public void arbol2() //controla lo que ocurre al pulsar el boton arbol 2 es la variable que te permite usando un raycast (definido previamente en el codigo antes de los public void) crear el objeto llamado arbol 2 en el terreno del juego siempre que haya espacio.
    {

    }
    public void rascacielos() //controla lo que ocurre al pulsar el boton rascacielo es la variable que te permite usando un raycast (definido previamente en el codigo antes de los public void) crear el objeto llamado rascacielo en el terreno del juego siempre que haya espacio.
    {

    }
    public void residencias() //controla lo que ocurre al pulsar el boton residencia es la variable que te permite usando un raycast (definido previamente en el codigo antes de los public void) crear el objeto llamado residencias en el terreno del juego siempre que haya espacio.
    {

    }
    public void borrar()//controla lo que ocurre al pulsar el boton borrar es la variable que usando el raycast definido previamente en el codigo te permita eliminar los objetos creados en el terreno al pulsar sobre estos.
    {

    }
    public void borrartodo()//controla lo que ocurre al pulsar el boton borrar todo basicamente borra todos los objetos creados previamente.
    {
        
    }
}
