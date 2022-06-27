package lista.simple.iterador;

/**
 * Nodo es parte de una lista enlazada simple.
 * 
 * C�digo del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 25/09/2011
 */
class Nodo {
	public int dato; // clave
	public Nodo sig; // enlace al siguiente nodo
	// -------------------------------------------------------------
	public Nodo(int d) { // constructor
		dato = d; // inicializa dato ('sig' tiene automaticamente el valor de nulo)
	}
	// -------------------------------------------------------------
	public void despliegaNodo() { // se despliega asimismo
		System.out.print(dato + " ");
	}
} // fin clase Nodo

