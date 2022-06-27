package heaps;
/**
 * Clase Nodo.
 * 
 * Código del libro:
 * 		Data Structures & Algorithms in Java 2nd Ed., Robert Lafore, 2003.
 *
 * @version 1.00 15/08/11
 */
class Nodo {
	private int clave; // dato (clave)
	// -------------------------------------------------------------
	public Nodo(int clave) { // constructor
		this.clave = clave;
	}
	// -------------------------------------------------------------
	public int getClave() {
		return clave;
	}
	// -------------------------------------------------------------
	public void setClave(int id) {
		clave = id;
	}
	// -------------------------------------------------------------
	@Override
	public String toString() {
		return "[" + clave + "]";
	}
	// -------------------------------------------------------------
} // fin de la clase Nodo