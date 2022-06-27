package lista.simple.iterador;
/**
 * Métodos para manejar una lista enlazada simple.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 * 
 * @version 1.00 13/04/11
 */
class ListaEnlazada {
	private Nodo primero; // hace referencia al primer nodo de la lista
	// -------------------------------------------------------------
	public ListaEnlazada() { // constructor
		primero = null; // la lista no tiene nodos
	}
	// -------------------------------------------------------------
	public Nodo getPrimero() { // obtiene el contenido de primero
	    return primero; 
	}
	// -------------------------------------------------------------
	public void setPrimero(Nodo p) { // cambia el contenido de primero
	    primero = p;
	}
	// -------------------------------------------------------------
	public boolean estaVacia() { // verdadero, si la lista está vacía
		return (primero == null);
	}
	// -------------------------------------------------------------
	public IteradorLista getIterador() {  // retorna iterador
	      return new IteradorLista(this);  // inicializado con ésta lista
	}                               
	// -------------------------------------------------------------
	public void despliegaLista() {
		System.out.print("Lista (primero-->último): ");
		Nodo actual = primero; // inicia al principio de la lista
		while (actual != null) { // hasta que sea fin de la lista,
			actual.despliegaNodo(); // imprime dato
			actual = actual.sig; // avanza al siguiente nodo
		}
		System.out.println("");
	}
	// -------------------------------------------------------------
} // fin clase ListaEnlazada
